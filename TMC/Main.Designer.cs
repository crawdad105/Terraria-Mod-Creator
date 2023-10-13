namespace TMC
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Tabs = new TabControl();
            Tab1 = new TabPage();
            _1_Log = new Button();
            label3 = new Label();
            _1_About = new Button();
            TitlePng = new PictureBox();
            Title2 = new Label();
            Title1 = new Label();
            _1_NewMod = new Button();
            _1_OpenMod = new Button();
            Tab2 = new TabPage();
            _2_OpenMod = new Button();
            _2_NewMod = new Button();
            _2_Save = new Button();
            groupBox1 = new GroupBox();
            _2_More_IconView = new PictureBox();
            _2_More_UpleadIcon = new Button();
            _2_More_LableIcon = new Label();
            _2_More_OpenIcon = new Button();
            _2_More_LableModName2 = new Label();
            _2_More_InputModName = new TextBox();
            _2_More_LableModName = new Label();
            _2_More_InputPath = new TextBox();
            _2_More_LablePath = new Label();
            _2_ModDetails = new GroupBox();
            _2_ModDetails_InputDescription = new RichTextBox();
            _2_ModDetails_LableDescription = new Label();
            _2_ModDetails_InputVersion = new TextBox();
            _2_ModDetails_LableVersion = new Label();
            _2_ModDetails_InputAuthor = new TextBox();
            _2_ModDetails_LableAuthor = new Label();
            _2_ModDetails_InputName = new TextBox();
            _2_ModDetails_LableName = new Label();
            Tab3 = new TabPage();
            _3_NewModThing = new Button();
            _3_FileContent_NewFolder = new Button();
            _3_FileContent_NewFile = new Button();
            _3_FileView = new TabControl();
            _3_FileView_Tab1 = new TabPage();
            treeView1 = new TreeView();
            imageList1 = new ImageList(components);
            _3_FileView_Tab2 = new TabPage();
            _3_FileView_2_ZoomInput = new NumericUpDown();
            _3_FileView_2_ZoomLable = new Label();
            _3_FileView_2_SaveFile = new Button();
            _3_FileView_2_AllowEditTick = new CheckBox();
            _3_FileView_2_AllowEditBtn = new Button();
            _3_FileView_2_Deleat = new Button();
            _3_FileView_2_MoveFile = new Button();
            _3_FileView_2_Rename = new Button();
            label1 = new Label();
            label2 = new Label();
            _3_FileView_2_FileName = new TextBox();
            _3_FileView_2_FilePath = new TextBox();
            _3_FileView_2_FileData = new RichTextBox();
            _3_TreeView_ButtonHoverLable = new Label();
            _3_FileContent_Open = new Button();
            _3_UpdateTree = new Button();
            _3_TreeView = new TreeView();
            Tab4 = new TabPage();
            _4_TransLable = new Label();
            _4_TransInput = new TrackBar();
            Tabs.SuspendLayout();
            Tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TitlePng).BeginInit();
            Tab2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_2_More_IconView).BeginInit();
            _2_ModDetails.SuspendLayout();
            Tab3.SuspendLayout();
            _3_FileView.SuspendLayout();
            _3_FileView_Tab1.SuspendLayout();
            _3_FileView_Tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_3_FileView_2_ZoomInput).BeginInit();
            Tab4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_4_TransInput).BeginInit();
            SuspendLayout();
            // 
            // Tabs
            // 
            Tabs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Tabs.Controls.Add(Tab1);
            Tabs.Controls.Add(Tab2);
            Tabs.Controls.Add(Tab3);
            Tabs.Controls.Add(Tab4);
            Tabs.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Tabs.ItemSize = new Size(80, 20);
            Tabs.Location = new Point(-6, 1);
            Tabs.Name = "Tabs";
            Tabs.SelectedIndex = 0;
            Tabs.Size = new Size(996, 468);
            Tabs.TabIndex = 0;
            // 
            // Tab1
            // 
            Tab1.BackColor = Color.DarkGray;
            Tab1.Controls.Add(_1_Log);
            Tab1.Controls.Add(label3);
            Tab1.Controls.Add(_1_About);
            Tab1.Controls.Add(TitlePng);
            Tab1.Controls.Add(Title2);
            Tab1.Controls.Add(Title1);
            Tab1.Controls.Add(_1_NewMod);
            Tab1.Controls.Add(_1_OpenMod);
            Tab1.Location = new Point(4, 24);
            Tab1.Name = "Tab1";
            Tab1.Padding = new Padding(3);
            Tab1.Size = new Size(988, 440);
            Tab1.TabIndex = 0;
            Tab1.Text = "TMcreator";
            Tab1.Click += Tab1_Click;
            // 
            // _1_Log
            // 
            _1_Log.Anchor = AnchorStyles.Bottom;
            _1_Log.BackColor = Color.LightGray;
            _1_Log.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            _1_Log.Location = new Point(6, 407);
            _1_Log.Name = "_1_Log";
            _1_Log.Size = new Size(91, 23);
            _1_Log.TabIndex = 11;
            _1_Log.Text = "View Update Log";
            _1_Log.UseVisualStyleBackColor = false;
            _1_Log.Click += _1_Log_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(820, 398);
            label3.Name = "label3";
            label3.Size = new Size(165, 36);
            label3.TabIndex = 10;
            label3.Text = "Author: Crawdad105\r\nVersion: {1}\r\nNOTE: This version is highly unstable";
            label3.TextAlign = ContentAlignment.BottomRight;
            // 
            // _1_About
            // 
            _1_About.Anchor = AnchorStyles.Bottom;
            _1_About.BackColor = Color.LightGray;
            _1_About.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _1_About.Location = new Point(6, 371);
            _1_About.Name = "_1_About";
            _1_About.Size = new Size(91, 30);
            _1_About.TabIndex = 9;
            _1_About.Text = "About";
            _1_About.UseVisualStyleBackColor = false;
            _1_About.Click += _1_About_Click;
            // 
            // TitlePng
            // 
            TitlePng.Anchor = AnchorStyles.Top;
            TitlePng.Image = (Image)resources.GetObject("TitlePng.Image");
            TitlePng.Location = new Point(269, 105);
            TitlePng.Name = "TitlePng";
            TitlePng.Size = new Size(104, 104);
            TitlePng.SizeMode = PictureBoxSizeMode.Zoom;
            TitlePng.TabIndex = 8;
            TitlePng.TabStop = false;
            // 
            // Title2
            // 
            Title2.Anchor = AnchorStyles.Top;
            Title2.AutoSize = true;
            Title2.Font = new Font("Rockwell", 50F, FontStyle.Bold, GraphicsUnit.Point);
            Title2.Location = new Point(379, 105);
            Title2.Name = "Title2";
            Title2.Size = new Size(386, 82);
            Title2.TabIndex = 7;
            Title2.Text = "TMcreator";
            // 
            // Title1
            // 
            Title1.Anchor = AnchorStyles.Top;
            Title1.AutoSize = true;
            Title1.Font = new Font("Rockwell", 50F, FontStyle.Bold, GraphicsUnit.Point);
            Title1.Location = new Point(293, 23);
            Title1.Name = "Title1";
            Title1.Size = new Size(421, 82);
            Title1.TabIndex = 6;
            Title1.Text = "Welcome to";
            // 
            // _1_NewMod
            // 
            _1_NewMod.Anchor = AnchorStyles.Bottom;
            _1_NewMod.BackColor = Color.LightGray;
            _1_NewMod.Enabled = false;
            _1_NewMod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _1_NewMod.Location = new Point(499, 371);
            _1_NewMod.Name = "_1_NewMod";
            _1_NewMod.Size = new Size(108, 53);
            _1_NewMod.TabIndex = 5;
            _1_NewMod.Text = "New Mod";
            _1_NewMod.UseVisualStyleBackColor = false;
            _1_NewMod.Click += _1_NewMod_Click;
            // 
            // _1_OpenMod
            // 
            _1_OpenMod.Anchor = AnchorStyles.Bottom;
            _1_OpenMod.BackColor = Color.LightGray;
            _1_OpenMod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _1_OpenMod.Location = new Point(385, 371);
            _1_OpenMod.Name = "_1_OpenMod";
            _1_OpenMod.Size = new Size(108, 53);
            _1_OpenMod.TabIndex = 4;
            _1_OpenMod.Text = "OpenMod";
            _1_OpenMod.UseVisualStyleBackColor = false;
            _1_OpenMod.Click += _1_OpenMod_Click;
            // 
            // Tab2
            // 
            Tab2.BackColor = Color.DarkGray;
            Tab2.Controls.Add(_2_OpenMod);
            Tab2.Controls.Add(_2_NewMod);
            Tab2.Controls.Add(_2_Save);
            Tab2.Controls.Add(groupBox1);
            Tab2.Controls.Add(_2_ModDetails);
            Tab2.Location = new Point(4, 24);
            Tab2.Name = "Tab2";
            Tab2.Padding = new Padding(3);
            Tab2.Size = new Size(988, 440);
            Tab2.TabIndex = 1;
            Tab2.Text = "Mod Overview";
            // 
            // _2_OpenMod
            // 
            _2_OpenMod.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _2_OpenMod.BackColor = Color.Silver;
            _2_OpenMod.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _2_OpenMod.Location = new Point(6, 387);
            _2_OpenMod.Name = "_2_OpenMod";
            _2_OpenMod.Size = new Size(105, 43);
            _2_OpenMod.TabIndex = 22;
            _2_OpenMod.Text = "Open Mod";
            _2_OpenMod.UseVisualStyleBackColor = false;
            _2_OpenMod.Click += _2_OpenMod_Click;
            // 
            // _2_NewMod
            // 
            _2_NewMod.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _2_NewMod.BackColor = Color.Silver;
            _2_NewMod.Enabled = false;
            _2_NewMod.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _2_NewMod.Location = new Point(117, 387);
            _2_NewMod.Name = "_2_NewMod";
            _2_NewMod.Size = new Size(105, 43);
            _2_NewMod.TabIndex = 21;
            _2_NewMod.Text = "New Mod";
            _2_NewMod.UseVisualStyleBackColor = false;
            _2_NewMod.Click += _2_NewMod_Click;
            // 
            // _2_Save
            // 
            _2_Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _2_Save.BackColor = Color.Silver;
            _2_Save.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _2_Save.Location = new Point(443, 387);
            _2_Save.Name = "_2_Save";
            _2_Save.Size = new Size(105, 43);
            _2_Save.TabIndex = 20;
            _2_Save.Text = "Save Mod";
            _2_Save.UseVisualStyleBackColor = false;
            _2_Save.Click += _2_Save_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.DarkGray;
            groupBox1.Controls.Add(_2_More_IconView);
            groupBox1.Controls.Add(_2_More_UpleadIcon);
            groupBox1.Controls.Add(_2_More_LableIcon);
            groupBox1.Controls.Add(_2_More_OpenIcon);
            groupBox1.Controls.Add(_2_More_LableModName2);
            groupBox1.Controls.Add(_2_More_InputModName);
            groupBox1.Controls.Add(_2_More_LableModName);
            groupBox1.Controls.Add(_2_More_InputPath);
            groupBox1.Controls.Add(_2_More_LablePath);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(554, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 428);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "More";
            // 
            // _2_More_IconView
            // 
            _2_More_IconView.BackColor = Color.Red;
            _2_More_IconView.BorderStyle = BorderStyle.Fixed3D;
            _2_More_IconView.Location = new Point(96, 110);
            _2_More_IconView.Name = "_2_More_IconView";
            _2_More_IconView.Size = new Size(84, 84);
            _2_More_IconView.TabIndex = 20;
            _2_More_IconView.TabStop = false;
            // 
            // _2_More_UpleadIcon
            // 
            _2_More_UpleadIcon.BackColor = Color.Silver;
            _2_More_UpleadIcon.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _2_More_UpleadIcon.Location = new Point(186, 164);
            _2_More_UpleadIcon.Name = "_2_More_UpleadIcon";
            _2_More_UpleadIcon.Size = new Size(105, 30);
            _2_More_UpleadIcon.TabIndex = 19;
            _2_More_UpleadIcon.Text = "Uplead Icon";
            _2_More_UpleadIcon.UseVisualStyleBackColor = false;
            _2_More_UpleadIcon.Click += _2_More_UpleadIcon_Click;
            // 
            // _2_More_LableIcon
            // 
            _2_More_LableIcon.AutoSize = true;
            _2_More_LableIcon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _2_More_LableIcon.Location = new Point(28, 118);
            _2_More_LableIcon.Name = "_2_More_LableIcon";
            _2_More_LableIcon.Size = new Size(61, 15);
            _2_More_LableIcon.TabIndex = 18;
            _2_More_LableIcon.Text = "Mod Icon:";
            // 
            // _2_More_OpenIcon
            // 
            _2_More_OpenIcon.BackColor = Color.Silver;
            _2_More_OpenIcon.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _2_More_OpenIcon.Location = new Point(186, 110);
            _2_More_OpenIcon.Name = "_2_More_OpenIcon";
            _2_More_OpenIcon.Size = new Size(105, 30);
            _2_More_OpenIcon.TabIndex = 17;
            _2_More_OpenIcon.Text = "Open Mod Icon";
            _2_More_OpenIcon.UseVisualStyleBackColor = false;
            _2_More_OpenIcon.Click += _2_More_OpenIcon_Click;
            // 
            // _2_More_LableModName2
            // 
            _2_More_LableModName2.AutoSize = true;
            _2_More_LableModName2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _2_More_LableModName2.Location = new Point(85, 81);
            _2_More_LableModName2.Name = "_2_More_LableModName2";
            _2_More_LableModName2.Size = new Size(231, 15);
            _2_More_LableModName2.TabIndex = 8;
            _2_More_LableModName2.Text = "*Mod Name refers to the assembily name*";
            // 
            // _2_More_InputModName
            // 
            _2_More_InputModName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _2_More_InputModName.BackColor = Color.LightGray;
            _2_More_InputModName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _2_More_InputModName.Location = new Point(96, 55);
            _2_More_InputModName.Name = "_2_More_InputModName";
            _2_More_InputModName.ReadOnly = true;
            _2_More_InputModName.Size = new Size(324, 23);
            _2_More_InputModName.TabIndex = 7;
            // 
            // _2_More_LableModName
            // 
            _2_More_LableModName.AutoSize = true;
            _2_More_LableModName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _2_More_LableModName.Location = new Point(20, 58);
            _2_More_LableModName.Name = "_2_More_LableModName";
            _2_More_LableModName.Size = new Size(70, 15);
            _2_More_LableModName.TabIndex = 6;
            _2_More_LableModName.Text = "Mod Name:";
            // 
            // _2_More_InputPath
            // 
            _2_More_InputPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _2_More_InputPath.BackColor = Color.LightGray;
            _2_More_InputPath.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _2_More_InputPath.Location = new Point(96, 26);
            _2_More_InputPath.Name = "_2_More_InputPath";
            _2_More_InputPath.ReadOnly = true;
            _2_More_InputPath.Size = new Size(324, 23);
            _2_More_InputPath.TabIndex = 5;
            // 
            // _2_More_LablePath
            // 
            _2_More_LablePath.AutoSize = true;
            _2_More_LablePath.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _2_More_LablePath.Location = new Point(28, 29);
            _2_More_LablePath.Name = "_2_More_LablePath";
            _2_More_LablePath.Size = new Size(62, 15);
            _2_More_LablePath.TabIndex = 0;
            _2_More_LablePath.Text = "Mod Path:";
            // 
            // _2_ModDetails
            // 
            _2_ModDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            _2_ModDetails.BackColor = Color.DarkGray;
            _2_ModDetails.Controls.Add(_2_ModDetails_InputDescription);
            _2_ModDetails.Controls.Add(_2_ModDetails_LableDescription);
            _2_ModDetails.Controls.Add(_2_ModDetails_InputVersion);
            _2_ModDetails.Controls.Add(_2_ModDetails_LableVersion);
            _2_ModDetails.Controls.Add(_2_ModDetails_InputAuthor);
            _2_ModDetails.Controls.Add(_2_ModDetails_LableAuthor);
            _2_ModDetails.Controls.Add(_2_ModDetails_InputName);
            _2_ModDetails.Controls.Add(_2_ModDetails_LableName);
            _2_ModDetails.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            _2_ModDetails.Location = new Point(6, 6);
            _2_ModDetails.Name = "_2_ModDetails";
            _2_ModDetails.Size = new Size(542, 375);
            _2_ModDetails.TabIndex = 0;
            _2_ModDetails.TabStop = false;
            _2_ModDetails.Text = "Mod Overview";
            // 
            // _2_ModDetails_InputDescription
            // 
            _2_ModDetails_InputDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _2_ModDetails_InputDescription.BackColor = Color.LightGray;
            _2_ModDetails_InputDescription.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _2_ModDetails_InputDescription.Location = new Point(8, 136);
            _2_ModDetails_InputDescription.Name = "_2_ModDetails_InputDescription";
            _2_ModDetails_InputDescription.Size = new Size(528, 233);
            _2_ModDetails_InputDescription.TabIndex = 11;
            _2_ModDetails_InputDescription.Text = "";
            // 
            // _2_ModDetails_LableDescription
            // 
            _2_ModDetails_LableDescription.AutoSize = true;
            _2_ModDetails_LableDescription.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _2_ModDetails_LableDescription.Location = new Point(8, 118);
            _2_ModDetails_LableDescription.Name = "_2_ModDetails_LableDescription";
            _2_ModDetails_LableDescription.Size = new Size(192, 15);
            _2_ModDetails_LableDescription.TabIndex = 10;
            _2_ModDetails_LableDescription.Text = "Mod Description ('\\n' for new line):";
            // 
            // _2_ModDetails_InputVersion
            // 
            _2_ModDetails_InputVersion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _2_ModDetails_InputVersion.BackColor = Color.LightGray;
            _2_ModDetails_InputVersion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _2_ModDetails_InputVersion.Location = new Point(128, 84);
            _2_ModDetails_InputVersion.Name = "_2_ModDetails_InputVersion";
            _2_ModDetails_InputVersion.Size = new Size(408, 23);
            _2_ModDetails_InputVersion.TabIndex = 9;
            // 
            // _2_ModDetails_LableVersion
            // 
            _2_ModDetails_LableVersion.AutoSize = true;
            _2_ModDetails_LableVersion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _2_ModDetails_LableVersion.Location = new Point(46, 87);
            _2_ModDetails_LableVersion.Name = "_2_ModDetails_LableVersion";
            _2_ModDetails_LableVersion.Size = new Size(76, 15);
            _2_ModDetails_LableVersion.TabIndex = 8;
            _2_ModDetails_LableVersion.Text = "Mod Version:";
            // 
            // _2_ModDetails_InputAuthor
            // 
            _2_ModDetails_InputAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _2_ModDetails_InputAuthor.BackColor = Color.LightGray;
            _2_ModDetails_InputAuthor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _2_ModDetails_InputAuthor.Location = new Point(128, 55);
            _2_ModDetails_InputAuthor.Name = "_2_ModDetails_InputAuthor";
            _2_ModDetails_InputAuthor.Size = new Size(408, 23);
            _2_ModDetails_InputAuthor.TabIndex = 7;
            // 
            // _2_ModDetails_LableAuthor
            // 
            _2_ModDetails_LableAuthor.AutoSize = true;
            _2_ModDetails_LableAuthor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _2_ModDetails_LableAuthor.Location = new Point(40, 58);
            _2_ModDetails_LableAuthor.Name = "_2_ModDetails_LableAuthor";
            _2_ModDetails_LableAuthor.Size = new Size(82, 15);
            _2_ModDetails_LableAuthor.TabIndex = 6;
            _2_ModDetails_LableAuthor.Text = "Author Name:";
            // 
            // _2_ModDetails_InputName
            // 
            _2_ModDetails_InputName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _2_ModDetails_InputName.BackColor = Color.LightGray;
            _2_ModDetails_InputName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _2_ModDetails_InputName.Location = new Point(128, 26);
            _2_ModDetails_InputName.Name = "_2_ModDetails_InputName";
            _2_ModDetails_InputName.Size = new Size(408, 23);
            _2_ModDetails_InputName.TabIndex = 5;
            // 
            // _2_ModDetails_LableName
            // 
            _2_ModDetails_LableName.AutoSize = true;
            _2_ModDetails_LableName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _2_ModDetails_LableName.Location = new Point(8, 29);
            _2_ModDetails_LableName.Name = "_2_ModDetails_LableName";
            _2_ModDetails_LableName.Size = new Size(114, 15);
            _2_ModDetails_LableName.TabIndex = 0;
            _2_ModDetails_LableName.Text = "Mod Desplay Name:";
            // 
            // Tab3
            // 
            Tab3.BackColor = Color.DarkGray;
            Tab3.Controls.Add(_3_NewModThing);
            Tab3.Controls.Add(_3_FileContent_NewFolder);
            Tab3.Controls.Add(_3_FileContent_NewFile);
            Tab3.Controls.Add(_3_FileView);
            Tab3.Controls.Add(_3_TreeView_ButtonHoverLable);
            Tab3.Controls.Add(_3_FileContent_Open);
            Tab3.Controls.Add(_3_UpdateTree);
            Tab3.Controls.Add(_3_TreeView);
            Tab3.Location = new Point(4, 24);
            Tab3.Name = "Tab3";
            Tab3.Padding = new Padding(3);
            Tab3.Size = new Size(988, 440);
            Tab3.TabIndex = 2;
            Tab3.Text = "Mod Tree View";
            // 
            // _3_NewModThing
            // 
            _3_NewModThing.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _3_NewModThing.BackColor = Color.Silver;
            _3_NewModThing.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _3_NewModThing.Location = new Point(133, 366);
            _3_NewModThing.Name = "_3_NewModThing";
            _3_NewModThing.Size = new Size(118, 66);
            _3_NewModThing.TabIndex = 43;
            _3_NewModThing.Text = "Create New Mod Component";
            _3_NewModThing.UseVisualStyleBackColor = false;
            _3_NewModThing.Click += _3_NewModThing_Click;
            // 
            // _3_FileContent_NewFolder
            // 
            _3_FileContent_NewFolder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _3_FileContent_NewFolder.BackColor = Color.Silver;
            _3_FileContent_NewFolder.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _3_FileContent_NewFolder.Location = new Point(257, 366);
            _3_FileContent_NewFolder.Name = "_3_FileContent_NewFolder";
            _3_FileContent_NewFolder.Size = new Size(118, 30);
            _3_FileContent_NewFolder.TabIndex = 42;
            _3_FileContent_NewFolder.Text = "New Folder";
            _3_FileContent_NewFolder.UseVisualStyleBackColor = false;
            _3_FileContent_NewFolder.Click += _3_FileContent_NewFolder_Click;
            // 
            // _3_FileContent_NewFile
            // 
            _3_FileContent_NewFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _3_FileContent_NewFile.BackColor = Color.Silver;
            _3_FileContent_NewFile.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _3_FileContent_NewFile.Location = new Point(257, 402);
            _3_FileContent_NewFile.Name = "_3_FileContent_NewFile";
            _3_FileContent_NewFile.Size = new Size(118, 30);
            _3_FileContent_NewFile.TabIndex = 41;
            _3_FileContent_NewFile.Text = "New File";
            _3_FileContent_NewFile.UseVisualStyleBackColor = false;
            _3_FileContent_NewFile.Click += _3_FileContent_NewFile_Click;
            // 
            // _3_FileView
            // 
            _3_FileView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _3_FileView.Controls.Add(_3_FileView_Tab1);
            _3_FileView.Controls.Add(_3_FileView_Tab2);
            _3_FileView.Location = new Point(381, 6);
            _3_FileView.Name = "_3_FileView";
            _3_FileView.SelectedIndex = 0;
            _3_FileView.Size = new Size(601, 426);
            _3_FileView.TabIndex = 41;
            // 
            // _3_FileView_Tab1
            // 
            _3_FileView_Tab1.BackColor = Color.DarkGray;
            _3_FileView_Tab1.Controls.Add(treeView1);
            _3_FileView_Tab1.Location = new Point(4, 22);
            _3_FileView_Tab1.Name = "_3_FileView_Tab1";
            _3_FileView_Tab1.Padding = new Padding(3);
            _3_FileView_Tab1.Size = new Size(593, 400);
            _3_FileView_Tab1.TabIndex = 0;
            _3_FileView_Tab1.Text = "File Overview";
            // 
            // treeView1
            // 
            treeView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            treeView1.BackColor = Color.LightGray;
            treeView1.ImageIndex = 0;
            treeView1.ImageList = imageList1;
            treeView1.Indent = 15;
            treeView1.ItemHeight = 15;
            treeView1.Location = new Point(6, 6);
            treeView1.Name = "treeView1";
            treeView1.SelectedImageIndex = 0;
            treeView1.ShowNodeToolTips = true;
            treeView1.Size = new Size(175, 362);
            treeView1.TabIndex = 1;
            treeView1.Visible = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Run.ico");
            imageList1.Images.SetKeyName(1, "TMC.ico");
            imageList1.Images.SetKeyName(2, "Library.ico");
            imageList1.Images.SetKeyName(3, "Folder.ico");
            imageList1.Images.SetKeyName(4, "Notes.ico");
            imageList1.Images.SetKeyName(5, "Pictures file.ico");
            imageList1.Images.SetKeyName(6, "Audio file.ico");
            imageList1.Images.SetKeyName(7, "Video file.ico");
            imageList1.Images.SetKeyName(8, "config.ico");
            imageList1.Images.SetKeyName(9, "exe.ico");
            imageList1.Images.SetKeyName(10, "Zip.ico");
            imageList1.Images.SetKeyName(11, "Warning.ico");
            // 
            // _3_FileView_Tab2
            // 
            _3_FileView_Tab2.BackColor = Color.DarkGray;
            _3_FileView_Tab2.Controls.Add(_3_FileView_2_ZoomInput);
            _3_FileView_Tab2.Controls.Add(_3_FileView_2_ZoomLable);
            _3_FileView_Tab2.Controls.Add(_3_FileView_2_SaveFile);
            _3_FileView_Tab2.Controls.Add(_3_FileView_2_AllowEditTick);
            _3_FileView_Tab2.Controls.Add(_3_FileView_2_AllowEditBtn);
            _3_FileView_Tab2.Controls.Add(_3_FileView_2_Deleat);
            _3_FileView_Tab2.Controls.Add(_3_FileView_2_MoveFile);
            _3_FileView_Tab2.Controls.Add(_3_FileView_2_Rename);
            _3_FileView_Tab2.Controls.Add(label1);
            _3_FileView_Tab2.Controls.Add(label2);
            _3_FileView_Tab2.Controls.Add(_3_FileView_2_FileName);
            _3_FileView_Tab2.Controls.Add(_3_FileView_2_FilePath);
            _3_FileView_Tab2.Controls.Add(_3_FileView_2_FileData);
            _3_FileView_Tab2.Location = new Point(4, 24);
            _3_FileView_Tab2.Name = "_3_FileView_Tab2";
            _3_FileView_Tab2.Padding = new Padding(3);
            _3_FileView_Tab2.Size = new Size(593, 398);
            _3_FileView_Tab2.TabIndex = 1;
            _3_FileView_Tab2.Text = "Read File Data";
            // 
            // _3_FileView_2_ZoomInput
            // 
            _3_FileView_2_ZoomInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _3_FileView_2_ZoomInput.DecimalPlaces = 1;
            _3_FileView_2_ZoomInput.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            _3_FileView_2_ZoomInput.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            _3_FileView_2_ZoomInput.Location = new Point(420, 367);
            _3_FileView_2_ZoomInput.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            _3_FileView_2_ZoomInput.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            _3_FileView_2_ZoomInput.Name = "_3_FileView_2_ZoomInput";
            _3_FileView_2_ZoomInput.Size = new Size(47, 25);
            _3_FileView_2_ZoomInput.TabIndex = 40;
            _3_FileView_2_ZoomInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            _3_FileView_2_ZoomInput.ValueChanged += _3_FileView_2_ZoomInput_ValueChanged;
            // 
            // _3_FileView_2_ZoomLable
            // 
            _3_FileView_2_ZoomLable.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _3_FileView_2_ZoomLable.AutoSize = true;
            _3_FileView_2_ZoomLable.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            _3_FileView_2_ZoomLable.Location = new Point(374, 368);
            _3_FileView_2_ZoomLable.Name = "_3_FileView_2_ZoomLable";
            _3_FileView_2_ZoomLable.Size = new Size(48, 19);
            _3_FileView_2_ZoomLable.TabIndex = 39;
            _3_FileView_2_ZoomLable.Text = "Zoom:";
            _3_FileView_2_ZoomLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _3_FileView_2_SaveFile
            // 
            _3_FileView_2_SaveFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _3_FileView_2_SaveFile.BackColor = Color.Silver;
            _3_FileView_2_SaveFile.Enabled = false;
            _3_FileView_2_SaveFile.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _3_FileView_2_SaveFile.Location = new Point(6, 364);
            _3_FileView_2_SaveFile.Name = "_3_FileView_2_SaveFile";
            _3_FileView_2_SaveFile.Size = new Size(85, 30);
            _3_FileView_2_SaveFile.TabIndex = 38;
            _3_FileView_2_SaveFile.Text = "Save File";
            _3_FileView_2_SaveFile.UseVisualStyleBackColor = false;
            _3_FileView_2_SaveFile.Click += _3_FileView_2_SaveFile_Click;
            // 
            // _3_FileView_2_AllowEditTick
            // 
            _3_FileView_2_AllowEditTick.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _3_FileView_2_AllowEditTick.AutoSize = true;
            _3_FileView_2_AllowEditTick.BackColor = Color.Silver;
            _3_FileView_2_AllowEditTick.Enabled = false;
            _3_FileView_2_AllowEditTick.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _3_FileView_2_AllowEditTick.Location = new Point(490, 372);
            _3_FileView_2_AllowEditTick.Name = "_3_FileView_2_AllowEditTick";
            _3_FileView_2_AllowEditTick.Size = new Size(15, 14);
            _3_FileView_2_AllowEditTick.TabIndex = 34;
            _3_FileView_2_AllowEditTick.UseVisualStyleBackColor = false;
            // 
            // _3_FileView_2_AllowEditBtn
            // 
            _3_FileView_2_AllowEditBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _3_FileView_2_AllowEditBtn.BackColor = Color.Silver;
            _3_FileView_2_AllowEditBtn.Enabled = false;
            _3_FileView_2_AllowEditBtn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _3_FileView_2_AllowEditBtn.Location = new Point(482, 364);
            _3_FileView_2_AllowEditBtn.Name = "_3_FileView_2_AllowEditBtn";
            _3_FileView_2_AllowEditBtn.Size = new Size(105, 30);
            _3_FileView_2_AllowEditBtn.TabIndex = 37;
            _3_FileView_2_AllowEditBtn.Text = "Allow File Edit";
            _3_FileView_2_AllowEditBtn.TextAlign = ContentAlignment.MiddleRight;
            _3_FileView_2_AllowEditBtn.UseVisualStyleBackColor = false;
            _3_FileView_2_AllowEditBtn.Click += _3_FileView_2_AllowEditBtn_Click;
            // 
            // _3_FileView_2_Deleat
            // 
            _3_FileView_2_Deleat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _3_FileView_2_Deleat.BackColor = Color.Silver;
            _3_FileView_2_Deleat.Enabled = false;
            _3_FileView_2_Deleat.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _3_FileView_2_Deleat.Location = new Point(267, 364);
            _3_FileView_2_Deleat.Name = "_3_FileView_2_Deleat";
            _3_FileView_2_Deleat.Size = new Size(85, 30);
            _3_FileView_2_Deleat.TabIndex = 36;
            _3_FileView_2_Deleat.Text = "Deleat File";
            _3_FileView_2_Deleat.UseVisualStyleBackColor = false;
            _3_FileView_2_Deleat.Click += _3_FileView_2_Deleat_Click;
            // 
            // _3_FileView_2_MoveFile
            // 
            _3_FileView_2_MoveFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _3_FileView_2_MoveFile.BackColor = Color.Silver;
            _3_FileView_2_MoveFile.Enabled = false;
            _3_FileView_2_MoveFile.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _3_FileView_2_MoveFile.Location = new Point(93, 365);
            _3_FileView_2_MoveFile.Name = "_3_FileView_2_MoveFile";
            _3_FileView_2_MoveFile.Size = new Size(85, 30);
            _3_FileView_2_MoveFile.TabIndex = 35;
            _3_FileView_2_MoveFile.Text = "Move File";
            _3_FileView_2_MoveFile.UseVisualStyleBackColor = false;
            _3_FileView_2_MoveFile.Click += _3_FileView_2_MoveFile_Click;
            // 
            // _3_FileView_2_Rename
            // 
            _3_FileView_2_Rename.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _3_FileView_2_Rename.BackColor = Color.Silver;
            _3_FileView_2_Rename.Enabled = false;
            _3_FileView_2_Rename.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _3_FileView_2_Rename.Location = new Point(180, 365);
            _3_FileView_2_Rename.Name = "_3_FileView_2_Rename";
            _3_FileView_2_Rename.Size = new Size(85, 30);
            _3_FileView_2_Rename.TabIndex = 33;
            _3_FileView_2_Rename.Text = "Rename File";
            _3_FileView_2_Rename.UseVisualStyleBackColor = false;
            _3_FileView_2_Rename.Click += _3_FileView_2_Rename_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 11;
            label1.Text = "Mod Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 7);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 10;
            label2.Text = "Mod Path:";
            // 
            // _3_FileView_2_FileName
            // 
            _3_FileView_2_FileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _3_FileView_2_FileName.BackColor = Color.LightGray;
            _3_FileView_2_FileName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _3_FileView_2_FileName.Location = new Point(76, 27);
            _3_FileView_2_FileName.Name = "_3_FileView_2_FileName";
            _3_FileView_2_FileName.ReadOnly = true;
            _3_FileView_2_FileName.Size = new Size(511, 23);
            _3_FileView_2_FileName.TabIndex = 9;
            // 
            // _3_FileView_2_FilePath
            // 
            _3_FileView_2_FilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _3_FileView_2_FilePath.BackColor = Color.LightGray;
            _3_FileView_2_FilePath.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _3_FileView_2_FilePath.Location = new Point(76, 4);
            _3_FileView_2_FilePath.Name = "_3_FileView_2_FilePath";
            _3_FileView_2_FilePath.ReadOnly = true;
            _3_FileView_2_FilePath.Size = new Size(511, 23);
            _3_FileView_2_FilePath.TabIndex = 8;
            // 
            // _3_FileView_2_FileData
            // 
            _3_FileView_2_FileData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _3_FileView_2_FileData.BackColor = Color.LightGray;
            _3_FileView_2_FileData.Location = new Point(6, 50);
            _3_FileView_2_FileData.Name = "_3_FileView_2_FileData";
            _3_FileView_2_FileData.ReadOnly = true;
            _3_FileView_2_FileData.Size = new Size(581, 308);
            _3_FileView_2_FileData.TabIndex = 0;
            _3_FileView_2_FileData.Text = "";
            // 
            // _3_TreeView_ButtonHoverLable
            // 
            _3_TreeView_ButtonHoverLable.AutoSize = true;
            _3_TreeView_ButtonHoverLable.Location = new Point(14, 586);
            _3_TreeView_ButtonHoverLable.Name = "_3_TreeView_ButtonHoverLable";
            _3_TreeView_ButtonHoverLable.RightToLeft = RightToLeft.Yes;
            _3_TreeView_ButtonHoverLable.Size = new Size(0, 13);
            _3_TreeView_ButtonHoverLable.TabIndex = 40;
            // 
            // _3_FileContent_Open
            // 
            _3_FileContent_Open.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _3_FileContent_Open.BackColor = Color.Silver;
            _3_FileContent_Open.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _3_FileContent_Open.Location = new Point(9, 402);
            _3_FileContent_Open.Name = "_3_FileContent_Open";
            _3_FileContent_Open.Size = new Size(118, 30);
            _3_FileContent_Open.TabIndex = 32;
            _3_FileContent_Open.Text = "Open Path";
            _3_FileContent_Open.UseVisualStyleBackColor = false;
            _3_FileContent_Open.Click += _3_FileContent_Open_Click;
            // 
            // _3_UpdateTree
            // 
            _3_UpdateTree.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _3_UpdateTree.BackColor = Color.Silver;
            _3_UpdateTree.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _3_UpdateTree.Location = new Point(9, 366);
            _3_UpdateTree.Name = "_3_UpdateTree";
            _3_UpdateTree.Size = new Size(118, 30);
            _3_UpdateTree.TabIndex = 21;
            _3_UpdateTree.Text = "Update Tree View";
            _3_UpdateTree.UseVisualStyleBackColor = false;
            _3_UpdateTree.Click += _3_UpdateTree_Click;
            // 
            // _3_TreeView
            // 
            _3_TreeView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            _3_TreeView.BackColor = Color.LightGray;
            _3_TreeView.ImageIndex = 0;
            _3_TreeView.ImageList = imageList1;
            _3_TreeView.Indent = 15;
            _3_TreeView.ItemHeight = 15;
            _3_TreeView.Location = new Point(9, 6);
            _3_TreeView.Name = "_3_TreeView";
            _3_TreeView.SelectedImageIndex = 0;
            _3_TreeView.ShowNodeToolTips = true;
            _3_TreeView.Size = new Size(366, 350);
            _3_TreeView.TabIndex = 0;
            _3_TreeView.AfterSelect += _3_TreeView_AfterSelect;
            // 
            // Tab4
            // 
            Tab4.BackColor = Color.DarkGray;
            Tab4.Controls.Add(_4_TransLable);
            Tab4.Controls.Add(_4_TransInput);
            Tab4.ForeColor = SystemColors.ActiveCaptionText;
            Tab4.Location = new Point(4, 24);
            Tab4.Name = "Tab4";
            Tab4.Padding = new Padding(3);
            Tab4.RightToLeft = RightToLeft.No;
            Tab4.Size = new Size(988, 440);
            Tab4.TabIndex = 3;
            Tab4.Text = "Settings";
            // 
            // _4_TransLable
            // 
            _4_TransLable.AutoSize = true;
            _4_TransLable.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            _4_TransLable.ForeColor = SystemColors.ActiveCaptionText;
            _4_TransLable.Location = new Point(13, 358);
            _4_TransLable.Name = "_4_TransLable";
            _4_TransLable.Size = new Size(226, 28);
            _4_TransLable.TabIndex = 1;
            _4_TransLable.Text = "Window Transparency:";
            _4_TransLable.Visible = false;
            // 
            // _4_TransInput
            // 
            _4_TransInput.Location = new Point(6, 389);
            _4_TransInput.Maximum = 100;
            _4_TransInput.Minimum = 20;
            _4_TransInput.Name = "_4_TransInput";
            _4_TransInput.RightToLeft = RightToLeft.No;
            _4_TransInput.Size = new Size(233, 45);
            _4_TransInput.TabIndex = 0;
            _4_TransInput.TickFrequency = 10;
            _4_TransInput.TickStyle = TickStyle.TopLeft;
            _4_TransInput.Value = 100;
            _4_TransInput.Visible = false;
            _4_TransInput.Scroll += trackBar1_Scroll;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(984, 461);
            Controls.Add(Tabs);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 500);
            Name = "Main";
            Text = "TMcreator";
            TransparencyKey = Color.Red;
            Load += Main_Load;
            Tabs.ResumeLayout(false);
            Tab1.ResumeLayout(false);
            Tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TitlePng).EndInit();
            Tab2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_2_More_IconView).EndInit();
            _2_ModDetails.ResumeLayout(false);
            _2_ModDetails.PerformLayout();
            Tab3.ResumeLayout(false);
            Tab3.PerformLayout();
            _3_FileView.ResumeLayout(false);
            _3_FileView_Tab1.ResumeLayout(false);
            _3_FileView_Tab2.ResumeLayout(false);
            _3_FileView_Tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_3_FileView_2_ZoomInput).EndInit();
            Tab4.ResumeLayout(false);
            Tab4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_4_TransInput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Tabs;
        private TabPage Tab1;
        private TabPage Tab2;
        private Button _1_OpenMod;
        private Button _1_NewMod;
        private PictureBox TitlePng;
        private Label Title2;
        private Label Title1;
        private GroupBox _2_ModDetails;
        private TextBox _2_ModDetails_InputName;
        private Label _2_ModDetails_LableName;
        private RichTextBox _2_ModDetails_InputDescription;
        private Label _2_ModDetails_LableDescription;
        private TextBox _2_ModDetails_InputVersion;
        private Label _2_ModDetails_LableVersion;
        private TextBox _2_ModDetails_InputAuthor;
        private Label _2_ModDetails_LableAuthor;
        private GroupBox groupBox1;
        private TextBox _2_More_InputModName;
        private Label _2_More_LableModName;
        private TextBox _2_More_InputPath;
        private Label _2_More_LablePath;
        private Label _2_More_LableModName2;
        private Button _2_More_UpleadIcon;
        private Label _2_More_LableIcon;
        private Button _2_More_OpenIcon;
        private Button _2_Save;
        private Button _2_OpenMod;
        private Button _2_NewMod;
        private TabPage Tab3;
        private TreeView _3_TreeView;
        private Button _3_UpdateTree;
        private ImageList imageList1;
        private Button _3_FileContent_Open;
        private TabPage Tab4;
        private TrackBar _4_TransInput;
        private Label _4_TransLable;
        private Label _3_TreeView_ButtonHoverLable;
        private TabControl _3_FileView;
        private TabPage _3_FileView_Tab1;
        private TabPage _3_FileView_Tab2;
        private CheckBox _3_FileView_2_AllowEditTick;
        private Button _3_FileView_2_Rename;
        private Label label1;
        private Label label2;
        private TextBox _3_FileView_2_FileName;
        private TextBox _3_FileView_2_FilePath;
        private RichTextBox _3_FileView_2_FileData;
        private Button _3_FileView_2_MoveFile;
        private Button _3_FileView_2_Deleat;
        private Button _3_FileView_2_AllowEditBtn;
        private Button _3_FileView_2_SaveFile;
        private NumericUpDown _3_FileView_2_ZoomInput;
        private Label _3_FileView_2_ZoomLable;
        private Button _3_FileContent_NewFolder;
        private Button _3_FileContent_NewFile;
        private PictureBox _2_More_IconView;
        private Button _1_About;
        private TreeView treeView1;
        private Button _3_NewModThing;
        private Label label3;
        private Button _1_Log;
    }
}