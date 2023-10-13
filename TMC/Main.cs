using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace TMC
{
    public partial class Main : Form
    {
        public Main() => InitializeComponent();
        public DialogResult SendMessage(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon) { return MessageBox.Show(text, caption, buttons, icon); }


        void ReadFiles(string Dir1)
        {
            Variables.Files.Clear();
            Variables.Folders.Clear();

            _3_TreeView.Nodes.Clear();
            _3_TreeView.BeginUpdate();

            Variables.TreeNodes = new List<TreeNode>();
            TreeNode NewNode = new TreeNode(Variables.ModName, 2, 0);

            Read(Dir1, NewNode);
            void Read(string Dir, TreeNode node)
            {
                int GetID(string Line)
                {
                    int Type = 0;
                    if (!Directory.Exists(Line))
                    {
                        Type = 1;
                        if (Line.ToLower().EndsWith(".tmc")) Type = 1;
                        else if (Line.ToLower().EndsWith(".cs") || Line.ToLower().EndsWith(".txt")) Type = 4;
                        else if (Line.ToLower().EndsWith(".png") || Line.ToLower().EndsWith(".jpg")) Type = 5;
                        else if (Line.ToLower().EndsWith(".mp3") || Line.ToLower().EndsWith(".ogg")) Type = 6;
                        else if (Line.ToLower().EndsWith(".mp4") || Line.ToLower().EndsWith(".mov")) Type = 7;
                        else if (Line.ToLower().EndsWith(".json") || Line.ToLower().EndsWith(".config")) Type = 8;
                        else if (Line.ToLower().EndsWith(".exe") || Line.ToLower().EndsWith(".msi")) Type = 9;
                        else if (Line.ToLower().EndsWith(".zip")) Type = 10;
                        else Type = 11;
                    }
                    else
                        Type = 3;
                    return Type;
                }
                string Name(string Dir)
                {
                    return Dir.Substring(Dir.LastIndexOf("\\") + 1);
                }
                for (int i = 0; i < Directory.GetFiles(Dir).Length; i++)
                {
                    Variables.Files.Add(new FileInfo(Directory.GetFiles(Dir)[i]));

                    node.Nodes.Add(new TreeNode(
                        Name(Directory.GetFiles(Dir)[i]),
                        GetID(Directory.GetFiles(Dir)[i]),
                        0));
                }
                for (int i = 0; i < Directory.GetDirectories(Dir).Length; i++)
                {
                    Variables.Folders.Add(new DirectoryInfo(Directory.GetDirectories(Dir)[i]));

                    TreeNode Newer = new TreeNode(Name(Directory.GetDirectories(Dir)[i]), GetID(Directory.GetDirectories(Dir)[i]), 0);
                    node.Nodes.Add(Newer);

                    Read(Directory.GetDirectories(Dir)[i], Newer);
                }
                NewNode = node;
            }

            _3_TreeView.Nodes.Add(NewNode);

            _3_TreeView.EndUpdate();
            _3_TreeView.Update();
        }
        string GetFolderDir(out bool Empty, out bool Valid)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog();
            string FolderPath = folderBrowserDialog1.SelectedPath;
            Empty = false;
            Valid = Directory.Exists(FolderPath);
            if (FolderPath == "" || FolderPath == null || FolderPath == string.Empty)
                Empty = true;
            return FolderPath;
        }
        public void OpenMod(int openValue)
        {
            int InitializeMod(out string ModPath, out string MissingFiles)
            {
                bool ValidPath;
                bool EmptyPath;

                ModPath = "";
                MissingFiles = "";

                if (Variables.openedType != Variables.OpenedType.None)
                {
                    DialogResult dialogResult = SendMessage("Are you sure you want to open a mod?\nAll current preogress will be lost!", "caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogResult.Equals(DialogResult.Cancel))
                        return -1;
                }

                ModPath = GetFolderDir(out EmptyPath, out ValidPath);
                if (EmptyPath)
                    return -1;
                if (!ValidPath)
                    return 1;

                Variables.Reset();
                Variables._ModFolder = new DirectoryInfo(ModPath);

                ReadFiles(ModPath);

                Variables.openedType = Variables.OpenedType.Open;

                Variables.FoundBuild = Variables.GetAllFileDirs.Contains(ModPath + @"\build.txt");
                Variables.FoundDesc = Variables.GetAllFileDirs.Contains(ModPath + @"\description.txt");
                Variables.FoundProj = Variables.GetAllFileDirs.Contains(ModPath + @$"\{Variables.ModName}.csproj");
                Variables.FoundIcon = Variables.GetAllFileDirs.Contains(ModPath + @$"\icon.png");

                ReadFoundFiles(ref ModPath);
                void ReadFoundFiles(ref string ModPath)
                {
                    if (Variables.FoundBuild)
                    {
                        foreach (string Line in File.ReadAllLines(ModPath + @"\build.txt"))
                        {
                            if (Line.StartsWith("displayName")) _2_ModDetails_InputName.Text = Line.Substring(Line.IndexOf("=") + 1).Trim();
                            if (Line.StartsWith("author")) _2_ModDetails_InputAuthor.Text = Line.Substring(Line.IndexOf("=") + 1).Trim();
                            if (Line.StartsWith("version")) _2_ModDetails_InputVersion.Text = Line.Substring(Line.IndexOf("=") + 1).Trim();
                        }
                        Variables.Build = ModPath + @"\build.txt";
                    }
                    if (Variables.FoundDesc)
                    {
                        _2_ModDetails_InputDescription.Text = File.ReadAllText(ModPath + @"\description.txt");
                        Variables.Desc = ModPath + @"\description.txt";
                    }
                    if (Variables.FoundIcon)
                    {
                        Variables.IconData = ModPath + @"\icon.png";
                        _2_More_IconView.Image = Image.FromFile(Variables.IconData);
                    }

                    _2_More_InputModName.Text = Variables.ModName;
                    _2_More_InputPath.Text = Variables.ModPath;
                }

                OverViewUpdate(false);

                if (Variables.FoundProj)
                {
                    if (!Variables.FoundBuild) MissingFiles += "\n'Build.txt'";
                    if (!Variables.FoundDesc) MissingFiles += "\n'Description.txt'";
                    if (!Variables.FoundIcon) MissingFiles += "\n'icon.png'";
                    if (MissingFiles.Length > 1) return 2;
                    return 0;
                }
                else
                {
                    MissingFiles = $"{Variables.ModName}.csproj";
                    return 3;
                }
            }

            string ModPath, MissingFiles;
            int MsgBoxValue = InitializeMod(out ModPath, out MissingFiles);

            switch (MsgBoxValue)
            {
                case 0:
                    MessageBox.Show("Successfully Opened Mod", "Compleat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    MessageBox.Show($"Invalid Folder Path, Faild To Open Mod\n{ModPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CloseMod();
                    break;
                case 2:
                    MessageBox.Show($"Missing Files: {MissingFiles}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 3:
                    MessageBox.Show($"Could not find {MissingFiles}, unable to load mod", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CloseMod();
                    break;
                default:
                    CloseMod();
                    break;
            }
        }
        bool OpenDirectory(string path)
        {
            bool Opened = Directory.Exists(path) || File.Exists(path);
            if (Directory.Exists(path) || File.Exists(path))
                Process.Start("explorer.exe", path);
            else
                SendMessage("Invalid File Path", "Invalid File Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return Opened;
        }
        void NodeInteraction(TreeViewEventArgs Tree)
        {
            if (Directory.Exists(Variables.SubModPath + "\\" + Tree.Node.FullPath)) OpenedDirectory.Set(new DirectoryInfo(Variables.SubModPath + "\\" + Tree.Node.FullPath));
            if (File.Exists(Variables.SubModPath + "\\" + Tree.Node.FullPath))
            {
                OpenedDirectory.Set(new FileInfo(Variables.SubModPath + "\\" + Tree.Node.FullPath));
                if (OpenedDirectory._fileInfo.Length > 5e+8)
                {
                    DialogResult dialogResult = SendMessage(
                        "The file you have clicked on is larger then 500 MB\n" +
                        "This program can read it, however it will reqire a lot of ram and could posible crash the program\n" +
                        "Are you sure you want to continue?",
                        "caption", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (dialogResult.Equals(DialogResult.Cancel) || dialogResult.Equals(DialogResult.No))
                        return;
                }
            }
            OpenedDirectory.Open = true;

            FileViewUpdate(0);
        }
        void FileViewUpdate(int Type)
        {
            if (Type == 0)//read
            {
                OpenedDirectory.AllowEdit = false;
                _3_FileView_2_FilePath.Text = OpenedDirectory.Path;
                _3_FileView_2_FileName.Text = OpenedDirectory.Name;
                _3_FileView_2_FileData.Text = OpenedDirectory.Data;
            }
            if (Type == 1)//dealert
            {
                _3_FileView_2_AllowEditBtn.Enabled = false;
                _3_FileView_2_FilePath.Text = "";
                _3_FileView_2_FileName.Text = "";
                _3_FileView_2_FileData.Text = "";
            }
            if (Type == 4)//edit
            {
                if (!OpenedDirectory.AllowEdit)
                {
                    DialogResult dialogResult = SendMessage("Are you sure you want to allow file edit?\nYou will need to know how the file works.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogResult.Equals(DialogResult.Cancel))
                        return;
                }
                OpenedDirectory.AllowEdit = !OpenedDirectory.AllowEdit;
            }
            _3_FileView_2_SaveFile.Enabled = OpenedDirectory.AllowEdit;
            _3_FileView_2_Rename.Enabled = OpenedDirectory.AllowEdit;
            _3_FileView_2_MoveFile.Enabled = OpenedDirectory.AllowEdit;
            _3_FileView_2_Deleat.Enabled = OpenedDirectory.AllowEdit;
            _3_FileView_2_FileData.ReadOnly = !OpenedDirectory.AllowEdit;

            _3_FileView_2_AllowEditTick.Checked = OpenedDirectory.AllowEdit;

            _3_FileView_2_AllowEditBtn.Enabled = OpenedDirectory.Open;
        }
        void Create(int type)
        {
            string oftype = "NULL";
            if (type == 0) oftype = "File";
            if (type == 1) oftype = "Folder";
            bool EmptyPath;
            bool ValidPath;
            string Basepath = GetFolderDir(out EmptyPath/*false*/, out ValidPath/*ture*/);
            string name = "";
            string Newpath = "";

            int Val = 10;
            if (EmptyPath == false && ValidPath == true)
            {
                name = Prompt.GetLineInput("Name");
                if (name == "?") return;
                if (
                    name.Contains("\\") ||
                    name.Contains("/") ||
                    name.Contains(":") ||
                    name.Contains("*") ||
                    name.Contains("?") ||
                    name.Contains("\"") ||
                    name.Contains("<") ||
                    name.Contains(">") ||
                    name.Contains("|")
                    )
                {
                    MessageBox.Show("Input can not contain the fallowing: \\/:*?\"<>|", "Invalid Characters", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Newpath = Basepath + "\\" + name;
                Val = Run();
            }

            int Run()
            {
                if (EmptyPath)
                    return 10;
                if (!ValidPath)
                    return 2;

                if (type == 0)//file
                {
                    if (Directory.Exists(Newpath) || File.Exists(Newpath))
                        return 1;

                    File.Create(Newpath);
                }
                if (type == 1)//folder
                {
                    if (Directory.Exists(Newpath) || File.Exists(Newpath))
                        return 1;

                    Directory.CreateDirectory(Newpath);
                }
                return 0;
            }


            if (Val == 1)
                MessageBox.Show($"A {oftype} with this\nname or path alredy exists.", "Path alredy exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (Val == 2)
                MessageBox.Show($"{oftype} path is invalid\n\n{Basepath}", "Invalid path", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (Val != 0) return;


            ReadFiles(Variables.ModPath);
        }
        string GetFileDir(out bool Empty, out bool Valid, string Filter)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = Filter;
            dialog.ShowDialog();
            string Path = dialog.FileName;
            Empty = false;
            Valid = File.Exists(Path);
            if (Path == "" || Path == null || Path == string.Empty)
                Empty = true;
            return Path;
        }
        void UpleadIcon()
        {
            string path;
            path = GetFileDir(out bool Empty, out bool Valid, "Sellect a png file or else (*.png)|*.png");
            if (File.Exists(Variables.ModPath + "\\icon.png"))
            {
                DialogResult dialogResult = SendMessage("There is alredy an icon conected to this mod\nPressing OK will override the previous icon file.", "Are you sure you are want to of do this?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult.Equals(DialogResult.Cancel))
                    return;
            }
            if (path == Variables.ModPath + "\\icon.png")
            {
                int i = 0;
                DialogResult dialogResult = SendMessage("The is the same file that was alredy there...", "Why even?", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                while (dialogResult.Equals(DialogResult.Retry))
                {
                    MessageBoxButtons messageBoxButtons = MessageBoxButtons.RetryCancel;
                    MessageBoxIcon messageBoxIcon = MessageBoxIcon.Information;
                    string str = "Retrying isnt going to do anything";
                    i++;
                    if (i >= 5)
                    { str = "Leave now"; messageBoxIcon = MessageBoxIcon.Warning; }
                    if (i >= 15)
                    { str = "Stop"; messageBoxButtons = MessageBoxButtons.OK; messageBoxIcon = MessageBoxIcon.Error; }
                    dialogResult = SendMessage(str, "Why even?", messageBoxButtons, messageBoxIcon);
                }
                return;
            }
            Image image = Image.FromFile(path);
            if (image.Size.Width == 80 && image.Size.Height == 80)
            {
                try
                {
                    File.Move(path, Variables.ModPath + "\\icon.png");
                }
                catch (Exception)
                {
                    MessageBox.Show("Unknows error while trying to move file", "Unknows Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            MessageBox.Show("The mod icon needs to be 80 by 80", "Invalid image size", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void SaveMod()
        {
            if (Variables.FoundBuild)
            {
                if (Version.TryParse(_2_ModDetails_InputVersion.Text, out Version result) == false)
                {
                    MessageBox.Show("Invalid Version!\nCould not save mod.", "Invalid Version", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string[] Lines = File.ReadAllLines(Variables.Build);
                string[] NewLines = new string[File.ReadAllLines(Variables.Build).Length];
                for (int i = 0; i < Lines.Length; i++)
                {
                    string Line = Lines[i];
                    if (Line.StartsWith("displayName"))
                    {
                        NewLines[i] = Line.Replace(Line.Substring(Line.IndexOf("=") + 1).Trim(), _2_ModDetails_InputName.Text);
                    }
                    else if (Line.StartsWith("author"))
                    {
                        NewLines[i] = Line.Replace(Line.Substring(Line.IndexOf("=") + 1).Trim(), _2_ModDetails_InputAuthor.Text);
                    }
                    else if (Line.StartsWith("version"))
                    {
                        NewLines[i] = Line.Replace(Line.Substring(Line.IndexOf("=") + 1).Trim(), result.ToString());
                    }
                    else
                        NewLines[i] = Lines[i];
                }
                if (!File.Exists(Variables.Build))
                {
                    MessageBox.Show("Why was the build file deleated\nwhile the mod was being edited...", "Could not save file because SOMEONE dealeated it...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    File.WriteAllLines(Variables.Build, NewLines);
                }
                catch (Exception)
                {
                    MessageBox.Show("Unknows error while trying to wright to file", "Unknows Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (Variables.FoundDesc)
            {
                if (!File.Exists(Variables.Desc))
                {
                    MessageBox.Show("Why was the description file deleated\nwhile the mod was being edited...", "Could not save file because SOMEONE dealeated it...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    File.WriteAllText(Variables.Desc, _2_ModDetails_InputDescription.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Unknows error while trying to wright to file", "Unknows Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("Successfully saved description.txt & build.txt", "Successfully dided", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        void OverViewUpdate(bool Reset)
        {
            if (Reset)
            {
                Variables.openedType = Variables.OpenedType.None;

                _2_ModDetails_InputAuthor.Text = string.Empty;
                _2_ModDetails_InputDescription.Text = string.Empty;
                _2_ModDetails_InputName.Text = string.Empty;
                _2_ModDetails_InputVersion.Text = string.Empty;

                _2_More_InputPath.Text = string.Empty;
                _2_More_InputModName.Text = string.Empty;

                _2_More_IconView.Image = new Bitmap(80, 80);

                FileViewUpdate(1);
            }

            bool Bool = Variables.openedType != Variables.OpenedType.None;

            _2_ModDetails_InputAuthor.Enabled = Bool;
            _2_ModDetails_InputDescription.Enabled = Bool;
            _2_ModDetails_InputName.Enabled = Bool;
            _2_ModDetails_InputVersion.Enabled = Bool;

            _2_Save.Enabled = Bool;
            _2_More_UpleadIcon.Enabled = Bool;
            _2_More_OpenIcon.Enabled = Bool && Variables.FoundIcon;

            _3_FileContent_NewFile.Enabled = Bool;
            _3_FileContent_NewFolder.Enabled = Bool;
            _3_UpdateTree.Enabled = Bool;
            _3_FileContent_Open.Enabled = Bool;
            _3_NewModThing.Enabled = Bool;

            label3.Text = label3.Text.Replace("{1}", VERSION.NUMBER);
        }
        void CloseMod()
        {
            Variables.Reset();
            OverViewUpdate(true);
            //FileViewUpdate(1);
            OpenedDirectory.AllowEdit = false;
            OpenedDirectory.Close();
            _3_TreeView.Nodes.Clear();
        }

        ///
        ///        BUTTONS
        ///
        private void _1_OpenMod_Click(object sender, EventArgs e) => OpenMod(0);
        public void _3_UpdateTree_Click(object sender, EventArgs e) => ReadFiles(Variables.ModPath);
        private void _2_OpenMod_Click(object sender, EventArgs e) => OpenMod(0);
        private void _2_NewMod_Click(object sender, EventArgs e) { }
        private void _2_More_OpenPath_Click(object sender, EventArgs e) => OpenDirectory(Variables.ModPath);
        private void _3_FileContent_SaveAs_Click(object sender, EventArgs e) { }
        private void _3_FileContent_KeyDown(object sender, KeyEventArgs e) { }
        private void _2_More_OpenIcon_Click(object sender, EventArgs e) { Prompt.ShowIcon(Variables.IconData); }
        private void trackBar1_Scroll(object sender, EventArgs e) => Opacity = _4_TransInput.Value;
        private void Tab1_Click(object sender, EventArgs e) { }
        private void _3_FileContent_TextChanged(object sender, EventArgs e) { }
        private void _3_TreeView_AfterSelect(object sender, TreeViewEventArgs e) => NodeInteraction(e);
        private void _3_FileContent_Open_Click(object sender, EventArgs e) { if (_3_TreeView.SelectedNode != null) OpenDirectory(Variables.SubModPath + "\\" + _3_TreeView.SelectedNode.FullPath); }
        private void _3_FileView_2_Rename_Click(object sender, EventArgs e) { if (OpenedDirectory.Rename()) { FileViewUpdate(0); ReadFiles(Variables.ModPath); } }
        private void _3_FileView_2_MoveFile_Click(object sender, EventArgs e) { if (OpenedDirectory.Move()) { FileViewUpdate(0); ReadFiles(Variables.ModPath); } }
        private void _3_FileView_2_Deleat_Click(object sender, EventArgs e) { if (OpenedDirectory.Deleat()) { FileViewUpdate(1); ReadFiles(Variables.ModPath); } }
        private void _3_FileView_2_AllowEditBtn_Click(object sender, EventArgs e) => FileViewUpdate(4);
        private void _3_FileView_2_SaveFile_Click(object sender, EventArgs e) { if (OpenedDirectory.Save(_3_FileView_2_FileData.Text)) { FileViewUpdate(0); ReadFiles(Variables.ModPath); } }
        private void _3_FileView_2_ZoomInput_ValueChanged(object sender, EventArgs e) { _3_FileView_2_FileData.ZoomFactor = (float)_3_FileView_2_ZoomInput.Value; }
        private void _3_FileContent_NewFolder_Click(object sender, EventArgs e) => Create(1);
        private void _3_FileContent_NewFile_Click(object sender, EventArgs e) => Create(0);
        private void _2_More_UpleadIcon_Click(object sender, EventArgs e) => UpleadIcon();
        private void Main_Load(object sender, EventArgs e) => OverViewUpdate(true);
        private void _2_Save_Click(object sender, EventArgs e) => SaveMod();

        private void _1_About_Click(object sender, EventArgs e) { Prompt.ShowAbout(); }

        private void _3_NewModThing_Click(object sender, EventArgs e) => Prompt.ShowCreateComponent();

        private void _1_NewMod_Click(object sender, EventArgs e)
        {

        }

        private void _1_Log_Click(object sender, EventArgs e) => Prompt.OpenLogView();
    }
}
/*

Variables.TreeNodes = new List<TreeNode>();
TreeNode LastNode = null;

for (int i = 0; i < Variables.GetAllDirs.Count; i++)
{
    string Line = Variables.GetAllDirs[i].Replace(Variables.SubModPath + "\\", "");
    int ID = GetID(Variables.GetAllDirs[i]);
    foreach (string NewLine in Line.Split("\\"))
    {
        TreeNode[] Nodes = _3_TreeView.Nodes.Find(NewLine, true);
        if (Nodes.Length == 0)
        {
            if (LastNode == null)
                LastNode = _3_TreeView.Nodes.Add(NewLine, NewLine);
            else
                LastNode = LastNode.Nodes.Add(NewLine, NewLine);
    
            Variables.TreeNodes.Add(LastNode);
        }
        else
        {
            LastNode = Nodes[0];
        }
        LastNode.ImageIndex = ID;
    }
    LastNode = null;
}



Variables.TreeNodes = new List<TreeNode>();
TreeNode NewNode = new TreeNode(Variables.ModName, 2, 0);

Read(Dir1, NewNode);
void Read(string Dir, TreeNode node)
{
    for (int i = 0; i < Directory.GetFiles(Dir).Length; i++)
    {
        node.Nodes.Add(new TreeNode(Name(Directory.GetFiles(Dir)[i]),GetID(Directory.GetFiles(Dir)[i]),0));
    }
    for (int i = 0; i < Directory.GetDirectories(Dir).Length; i++)
    {
        TreeNode Newer = new TreeNode(Name(Directory.GetDirectories(Dir)[i]), GetID(Directory.GetDirectories(Dir)[i]), 0);
        node.Nodes.Add(Newer);
        Read(Directory.GetDirectories(Dir)[i], Newer);
    }
    NewNode = node;
}
_3_TreeView.Nodes.Add(NewNode);
*/