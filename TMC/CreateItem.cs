using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TMC
{
    public partial class CreateItem : Form
    {
        List<List<Box>> Boxes = new List<List<Box>>();
        public class Box
        {
            public Box(GroupBox x, CheckBox y, CheckBox? z)
            {
                box = x;
                check = y;
                enable = z;
                MaxSize = box.Size;
            }
            public Box(GroupBox x, CheckBox y)
            {
                box = x;
                check = y;
                enable = null;
                MaxSize = box.Size;
            }
            public GroupBox box;
            public CheckBox check;
            public CheckBox? enable;
            public Size MaxSize;
            public Size MinSize = new Size(239, 23);
            public void Max() => box.Size = MaxSize;
            public void Min() => box.Size = MinSize;
            public bool Opened
            {
                get { return check.Checked; }
            }
        }
        public Bitmap? image;

        //public List<RecipyBuilder> Recipies = new List<RecipyBuilder>();

        public CreateItem()
        {
            InitializeComponent();
            List<Box> _1 = new List<Box>();
            List<Box> _2 = new List<Box>();
            List<Box> _3 = new List<Box>();
            List<Box> _4 = new List<Box>();
            List<Box> _5 = new List<Box>();
            List<Box> _6 = new List<Box>();

            _1.Add(new Box(_11, _11B));
            _1.Add(new Box(_12, _12B));
            _1.Add(new Box(_13, _13B));

            _2.Add(new Box(_21, _21B, _21C));
            _2.Add(new Box(_22, _22B_, _22C));
            _2.Add(new Box(_23, _23B, _23C));
            _2.Add(new Box(_24, _24B, _24C));

            _3.Add(new Box(_31, _31B, _31C));
            _3.Add(new Box(_32, _32B, _32C));

            _4.Add(new Box(_41, _41B, _41C));
            _4.Add(new Box(_42, _42B, _42C));
            _4.Add(new Box(_43, _43B, _43C));
            _4.Add(new Box(_44, _44B, _44C));

            _5.Add(new Box(_51, _51B, _51C));

            _6.Add(new Box(_61, _61B, _61C));
            _6.Add(new Box(_62, _62B));
            _6.Add(new Box(_63, _63B));

            Boxes.Add(_1);
            Boxes.Add(_2);
            Boxes.Add(_3);
            Boxes.Add(_4);
            Boxes.Add(_5);
            Boxes.Add(_6);

            UpdateEnables();
        }

        void SetSize(int X, int Y)
        {
            Boxes[X][Y].Min();
            Boxes[X][Y].check.Text = "Show";
            if (Boxes[X][Y].check.Checked)
            {
                Boxes[X][Y].Max();
                Boxes[X][Y].check.Text = "Hide";
            }
            UpdateBoxs(X);
        }
        void UpdateBoxs(int X)
        {
            int Num1 = 0;
            for (int j = 1; j < Boxes[X].Count; j++)
            {
                int Y = 77 + Num1 + (Boxes[X][j - 1].box.Size.Height + 10);
                Num1 += (Boxes[X][j - 1].box.Size.Height + 10);
                Boxes[X][j].box.Location = new Point(Boxes[X][j].box.Location.X, Y);
            }
        }
        void Compile()
        {
            string TestValues(out List<string> Missings)
            {
                bool CheckFileName()
                {
                    string str = _FileName.Text;
                    string NewStr = "";
                    string Valid = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_";
                    string Valid1 = "1234567890";
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (!Valid.Contains(str[i]))
                            return true;
                        if (i == 0)
                            if (Valid1.Contains(str[i]))
                                return true;
                    }
                    return false;
                }

                Missings = new List<string>();
                if (!Directory.Exists(_PathInput.Text))
                {
                    Missings.Add("Stop messing with the files!");
                    Missings.Add("why dose the file path not exists!");
                    Missings.Add("it was fine untill you did somthing");
                    Missings.Add("i could easly deleat all the fiels on your computer");
                    Missings.Add("are you realy sure you want to mess with those files?");
                    return "Realy?...";
                }
                if (CheckFileName())
                {
                    Missings.Add("Custom File Name can only contain: ");
                    Missings.Add("numbers: '1234567890' !-(can not start with number though)-!");
                    Missings.Add("Letters: 'abcdefghijklmnopqrstuvwxyz'");
                    Missings.Add("or 'ABCDEFGHIJKLMNOPQRSTUVWXYZ'");
                    Missings.Add("And '_'");
                    return "Invalid Custom File Name";
                }
                if (_Name.Text == "" || _Name.Text == null || _Name.Text == string.Empty)
                    Missings.Add("Item Reqires a Name");

                if (_Rarity.SelectedIndex == -1)
                    Missings.Add("Item Reqires a Rarity");

                if (image == null)
                    Missings.Add("Item Reqires a Texture");

                if (_UseStyle.SelectedIndex == -1)
                    Missings.Add("Item Reqires a Use Style");

                if (_HoldType.SelectedIndex == -1)
                    Missings.Add("Item Reqires a Hold Type");

                if (_UseSound.SelectedIndex == -1)
                    Missings.Add("Item Reqires a Use Sound");

                if (_22C.Checked && (_DamageTypes.SelectedIndex == -1))
                    Missings.Add("Item Reqires a Damage Type");

                if (_41C.Checked && (_ProjType.SelectedIndex == -1))
                    Missings.Add("Item Reqires a Projectile Type");

                if (_41C.Checked && (_AmmoType.SelectedIndex == -1))
                    Missings.Add("Item Reqires a Ammo Type");

                if (_51C.Checked && (_TileType.SelectedIndex == -1))
                    Missings.Add("Item Reqires a Tile Type");

                return "Missing Values";
            }

            List<string> Missings = new List<string>();
            string Msg = TestValues(out Missings);
            if (Missings.Count > 0)
            {
                MessageBox.Show($"{_Rarity.SelectedText}" + "\n" + string.Join("\n", Missings), Msg, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SetValues();
            void SetValues()
            {
                string
                name = _FileName.Text.Length > 0 ? _FileName.Text : _Name.Text;

                List<string> Lines = new List<string>();
                {
                    Lines.Add($"//This Scrip Was Made Using TMc");
                    Lines.Add($"using Terraria;");
                    Lines.Add($"using Terraria.ID;");
                    Lines.Add($"using Terraria.ModLoader;");
                    Lines.Add($"namespace {_PathInput.Text.Replace(Variables.SubModPath + "\\", "").Replace("\\", ".").Replace(" ", "_")}");
                    Lines.Add(@"{");
                    Lines.Add($"    public class {name} : ModItem");
                    Lines.Add(@"    {");
                    Lines.Add(@"        public override void SetStaticDefaults()");
                    Lines.Add(@"        {");
                    Lines.Add($"            DisplayName.SetDefault(\"{_Name.Text}\");");
                    Lines.Add($"            Tooltip.SetDefault(\"{_Desc.Text.Replace("\n", ", ")}\");");
                    if (_Creative.Value > 0) Lines.Add($"            Terraria.GameContent.Creative.CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = {_Creative.Value};");
                    if (_AntyGravity.Checked) Lines.Add($"            ItemID.Sets.ItemNoGravity[Item.type] = {_AntyGravity.Checked.ToString().ToLower()};");
                    Lines.Add(@"        }");
                    Lines.Add($"        public override void SetDefaults()");
                    Lines.Add(@"        {");
                    Lines.Add($"            Item.rare = ItemRarityID.{_Rarity.Text}; ");
                    Lines.Add($"            Item.maxStack = {_MaxStack.Value}; ");
                    Lines.Add($"");
                    Lines.Add($"            Item.scale = {_Scale.Value}f; ");
                    Lines.Add($"            Item.width = {_Width.Value}; ");
                    Lines.Add($"            Item.height = {_Hight.Value}; ");
                    Lines.Add($"");
                    Lines.Add($"            Item.useTime = {_UseTime.Value}; ");
                    Lines.Add($"            Item.useAnimation = {_AnimTime.Value}; ");
                    Lines.Add($"            Item.useStyle = ItemUseStyleID.{_UseStyle.Text}; ");
                    Lines.Add($"            Item.holdStyle = ItemHoldStyleID.{_HoldType.Text}; ");
                    Lines.Add($"            Item.UseSound = SoundID.{_UseSound.Text}; ");
                    Lines.Add($"            Item.autoReuse = {_Auto.Checked.ToString().ToLower()}; ");
                    Lines.Add($"            Item.useTurn = {_UseTurn.Checked.ToString().ToLower()}; ");
                    Lines.Add($"");
                    if (_21C.Checked) Lines.Add($"            Item.pick = {_PickPower.Value}; ");
                    if (_21C.Checked) Lines.Add($"            Item.axe = {(_AxePower.Value / 100)}; ");
                    if (_21C.Checked) Lines.Add($"            Item.hammer = {_HamPower.Value}; ");
                    if (_21C.Checked) Lines.Add($"");
                    if (_22C.Checked) Lines.Add($"            Item.damage = {_Damage.Value}; ");
                    if (_22C.Checked) Lines.Add($"            Item.crit = {_Crit.Value}; ");
                    if (_22C.Checked) Lines.Add($"            Item.knockBack = {_KnockBack.Value}f; ");
                    if (_22C.Checked) Lines.Add($"            Item.DamageType = DamageClass.{_DamageTypes.Text}; ");
                    if (_22C.Checked) Lines.Add($"");
                    if (_23C.Checked) Lines.Add($"            Item.fishingPole = {_Fisher.Value}; //(foshing power) ");
                    if (_23C.Checked) Lines.Add($"");
                    if (_24C.Checked) Lines.Add($"            Item.value = Item.sellPrice({_Sell4.Value}, {_Sell3.Value}, {_Sell2.Value}, {_Sell1.Value});");
                    if (_24C.Checked) Lines.Add($"");
                    if (_41C.Checked) Lines.Add($"            Item.shoot = ProjectileID.{_ProjType.Text}; //This might be offcet but i dont know why");
                    if (_41C.Checked) Lines.Add($"            Item.shootSpeed = {_ProjSpeed.Value}f; ");
                    if (_41C.Checked) Lines.Add($"            Item.useAmmo = AmmoID.{_AmmoType.Text}; ");
                    if (_41C.Checked) Lines.Add($"");
                    if (_51C.Checked) Lines.Add($"            Item.createTile = TileID.{_TileType.Text}; ");
                    if (_51C.Checked) Lines.Add($"");
                    Lines.Add($"            Item.noMelee = {(!_IsMelee.Checked).ToString().ToLower()}; ");
                    Lines.Add($"            Item.masterOnly = {_IsMaster.Checked.ToString().ToLower()}; ");
                    Lines.Add($"            Item.questItem = {_IsQuest.Checked.ToString().ToLower()}; ");
                    Lines.Add($"            Item.consumable = {_Usable.Checked.ToString().ToLower()}; ");
                    Lines.Add($"            Item.tileBoost = {_Range.Value}; ");
                    Lines.Add(@"        }");
                    if (_41C.Checked) Lines.Add($"        public override bool CanConsumeAmmo(Item ammo, Player player)");
                    if (_41C.Checked) Lines.Add(@"        {");
                    if (_41C.Checked) Lines.Add($"            Random random = new Random();");
                    if (_41C.Checked) Lines.Add($"            return random.Next(100) + 1 > {_AntiAmmoUse.Value};");
                    if (_41C.Checked) Lines.Add(@"        {");
                    Lines.Add(@"    }");
                    Lines.Add(@"}");
                }//Add Lines

                List<string> TMcLines = new List<string>()
                {
                    $"You are not suposed to edit this file. However if you are going to:",
                    $"Do what you want, but you are worned that i cant desifer what you do unless its formated properly.",
                    $"",
                    $"Path={_PathInput.Text}",
                    $"ItemName={_Name.Text}",
                    $"Desc={_Desc.Text}",
                    $"Rare={_Rarity.SelectedIndex}",
                    $"Max={_MaxStack.Value}",
                    $"Creative={_Creative.Value}",
                    $"",
                    $"Scale={_Scale.Value}",
                    $"Override={_Override.Checked.ToString().ToLower()}",
                    $"Width={_Width.Value}",
                    $"Hight={_Hight.Value}",
                    $"",
                    $"UseStyle={_UseStyle.SelectedIndex}",
                    $"HoldStyle={_HoldType.SelectedIndex}",
                    $"UseSound={_UseSound.SelectedIndex}",
                    $"Audo={_Auto.Checked.ToString().ToLower()}",
                    $"Turn={_UseTurn.Checked.ToString().ToLower()}",
                    $"",
                    $"_21C={_21C.Checked.ToString().ToLower()}",
                    $"Axe={_AxePower.Value}",
                    $"Pick={_PickPower.Value}",
                    $"Ham={_HamPower.Value}",
                    $"",
                    $"_22C={_22C.Checked.ToString().ToLower()}",
                    $"Damage={_Damage.Value}",
                    $"Crit={_Crit.Value}",
                    $"nok={_KnockBack.Value}",
                    $"DamageType={_DamageTypes.SelectedIndex}",
                    $"",
                    $"_23C={_23C.Checked.ToString().ToLower()}",
                    $"Fish_With_No_Is_>_A_fsh={_Fisher.Value}",
                    $"",
                    $"_24C={_24C.Checked.ToString().ToLower()}",
                    $"Pt={_Sell4.Value}",
                    $"Au={_Sell3.Value}",
                    $"Ag={_Sell2.Value}",
                    $"Cu={_Sell1.Value}",
                    $"",
                    $"_31C={_31C.Checked.ToString().ToLower()}",
                    $"",
                    $"_32C={_32C.Checked.ToString().ToLower()}",
                    $"",
                    $"_41C={_41C.Checked.ToString().ToLower()}",
                    $"ProjType={_ProjType.SelectedIndex}",
                    $"ProjSpeed={_ProjSpeed.Value}",
                    $"AmmoType={_AmmoType.SelectedIndex}",
                    $"AnyiAmmo={_AntiAmmoUse.Value}",
                    $"",
                    $"_42C={_42C.Checked.ToString().ToLower()}",
                    $"",
                    $"_43C={_43C.Checked.ToString().ToLower()}",
                    $"",
                    $"_44C={_44C.Checked.ToString().ToLower()}",
                    $"",
                    $"_51C={_51C.Checked.ToString().ToLower()}",
                    $"Tile={_TileType.SelectedIndex}",
                    $"",
                    $"_61C={_61C.Checked.ToString().ToLower()}",
                    $"",
                    $"IsMelee={_IsMelee.Checked.ToString().ToLower()}",
                    $"IsMaster={_IsMaster.Checked.ToString().ToLower()}",
                    $"IsQuest={_IsQuest.Checked.ToString().ToLower()}",
                    $"Uses={_Usable.Checked.ToString().ToLower()}",
                    $"SpaceMode={_AntyGravity.Checked.ToString().ToLower()}",
                    $"Morely={_Range.Value}",
                    $"",
                    $"Name2={_FileName.Text}",
                    $"",
                    $"VERSION={VERSION.NUMBER}"
                };

                bool Er = false;
                string Stage = "";
                DialogResult dialogResult1 = DialogResult.Yes;
                DialogResult dialogResult2 = DialogResult.Yes;
                DialogResult dialogResult3 = DialogResult.Yes;
                bool Aask() => (dialogResult1 == DialogResult.Yes && dialogResult2 == DialogResult.Yes && dialogResult3 == DialogResult.Yes);
                if (Aask() && File.Exists(_PathInput.Text + "\\" + name + ".cs"))
                    dialogResult1 = MessageBox.Show($"A file with the name \"{(name + ".cs")}\"\nDo you want to override it?", "Do you or not?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (Aask() && File.Exists(_PathInput.Text + "\\" + name + ".png"))
                    dialogResult2 = MessageBox.Show($"A file with the name \"{(name + ".png")}\"\nDo you want to override it?", "Do you or not?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (Aask() && File.Exists(_PathInput.Text + "\\" + name + ".tmc"))
                    dialogResult3 = MessageBox.Show($"A file with the name \"{(name + ".tmc")}\"\nDo you want to override it?", "Do you or not?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialogResult1 == DialogResult.Yes && dialogResult2 == DialogResult.Yes && dialogResult3 == DialogResult.Yes && Er == false)
                {
                    try
                    {
                        File.WriteAllLines(_PathInput.Text + "\\" + name + ".cs", Lines.ToArray());
                    }
                    catch (Exception)
                    {
                        File.Delete(_PathInput.Text + "\\" + name + ".cs");
                        Er = true;
                        Stage = "creating .cs file";
                    }
                }
                if (dialogResult1 == DialogResult.Yes && dialogResult2 == DialogResult.Yes && dialogResult3 == DialogResult.Yes && Er == false)
                {
                    try
                    {
                        image.Save(_PathInput.Text + "\\" + name + ".png");
                    }
                    catch (Exception)
                    {
                        File.Delete(_PathInput.Text + "\\" + name + ".cs");
                        File.Delete(_PathInput.Text + "\\" + name + ".png");
                        Er = true;
                        Stage = "creating .png file";
                    }
                }
                if (dialogResult1 == DialogResult.Yes && dialogResult2 == DialogResult.Yes && dialogResult3 == DialogResult.Yes && Er == false)
                {
                    try
                    {
                        string Name = _PathInput.Text + "\\" + "TEMP";
                        DirectoryInfo directory = Directory.CreateDirectory(Name);
                        File.WriteAllLines(Name + "\\" + "item", TMcLines.ToArray());
                        File.WriteAllText(Name + "\\" + "type", "item");
                        File.WriteAllText(Name + "\\" + "version", $"VERSION={VERSION.NUMBER}");
                        image.Save(Name + "\\" + "image");
                        ZipFile.CreateFromDirectory(Name, _PathInput.Text + "\\" + name + ".tmc");

                    }
                    catch (Exception)
                    {
                        File.Delete(_PathInput.Text + "\\" + name + ".cs");
                        File.Delete(_PathInput.Text + "\\" + name + ".png");
                        if (Directory.Exists(_PathInput.Text + "\\" + "TEMP")) Directory.Delete(_PathInput.Text + "\\" + "TEMP", true);
                        Er = true;
                        Stage = "creating .tmc file";
                    }
                }
                if (dialogResult1 != DialogResult.Yes || dialogResult2 != DialogResult.Yes)
                    MessageBox.Show($"Did not create files because you said not to.", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (!Er)
                    {
                        MessageBox.Show($"Seccsefully Created Files", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Directory.Delete(_PathInput.Text + "\\" + "TEMP", true);
                    }
                    else
                    {
                        MessageBox.Show($"An error has ecured while {Stage}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
        void UpdateEnables()
        {
            _AxePower.Enabled = _21C.Checked;
            _PickPower.Enabled = _21C.Checked;
            _HamPower.Enabled = _21C.Checked;

            _Damage.Enabled = _22C.Checked;
            _Crit.Enabled = _22C.Checked;
            _KnockBack.Enabled = _22C.Checked;
            _DamageTypes.Enabled = _22C.Checked;

            _Fisher.Enabled = _23C.Checked;

            _Sell1.Enabled = _24C.Checked;
            _Sell2.Enabled = _24C.Checked;
            _Sell3.Enabled = _24C.Checked;
            _Sell4.Enabled = _24C.Checked;

            _ProjType.Enabled = _41C.Checked;
            _ProjSpeed.Enabled = _41C.Checked;
            _AmmoType.Enabled = _41C.Checked;
            _AntiAmmoUse.Enabled = _41C.Checked;

            _TileType.Enabled = _51C.Checked;
        }

        public void PressedShow(object sender, EventArgs e) => SetSize(int.Parse(((CheckBox)sender).Name.Substring(1, 1)) - 1, int.Parse(((CheckBox)sender).Name.Substring(2, 1)) - 1);
        public void PressedCheck(object sender, EventArgs e)
        {
            bool Check(string Dis, string En)
            {
                DialogResult dialogResult = MessageBox.Show($"Item can not have {En} and {Dis} enabled.\nDo you wish to enable '{En}'\nand disable '{Dis}'?\nValues will not be reset.", "Incompatable values", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return dialogResult == DialogResult.Yes;
            }
            CheckBox _Get = (CheckBox)sender;
            CheckBox _Com = null;

            if (_Get == _21C && _Get.Checked)
            {
                if (_41C.Checked)
                    _Com = _41C;
                else if (_51C.Checked)
                    _Com = _51C;
            }
            else if (_Get == _41C && _Get.Checked)
            {
                if (_21C.Checked)
                    _Com = _21C;
                else if (_51C.Checked)
                    _Com = _51C;
            }
            else if (_Get == _51C && _Get.Checked)
            {
                if (_21C.Checked)
                    _Com = _21C;
                else if (_41C.Checked)
                    _Com = _41C;
            }

            if (_Com != null)
            {
                bool check = Check(_Com.Text, _Get.Text);
                _Get.Checked = check == true ? true : _Get.Checked;
                _Com.Checked = check == true ? false : _Com.Checked;

                _Get.Checked = check == false ? false : _Get.Checked;
                _Com.Checked = check == false ? true : _Com.Checked;
            }

            UpdateEnables();
        }
        private void _Compile_Click(object sender, EventArgs e) => Compile();
        private void _PathMove_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog();
            string FolderPath = folderBrowserDialog1.SelectedPath;
            bool Valid = Directory.Exists(FolderPath);
            if (FolderPath == "" || FolderPath == null || FolderPath == string.Empty)
                return;
            if (!Valid)
                MessageBox.Show($"Invalid Folder Path\n\n{FolderPath}", "Invalid Folder Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!new string(FolderPath + "\\").StartsWith(Variables.ModPath + "\\"))
                MessageBox.Show($"Folder path needs to be inside the mod folder\n\n{FolderPath}", "Invalid Folder Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                _PathInput.Text = FolderPath;
        }
        private void CreateItem_Load(object sender, EventArgs e) => _PathInput.Text = Tag.ToString();
        private void _TextureUplead_Click(object sender, EventArgs e)
        {
            string GetFileDir()
            {
                bool Empty;
                bool Valid;
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Sellect a png file or else (*.png)|*.png";
                dialog.ShowDialog();
                string Path = dialog.FileName;
                Empty = false;
                Valid = File.Exists(Path);
                if (Path == "" || Path == null || Path == string.Empty)
                    Empty = true;
                if (Empty) Path = "NULL";
                if (!Empty && !Valid) { MessageBox.Show("Invalid Path", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error); Path = "NULL"; }
                return Path;
            }

            string img = GetFileDir();
            if (File.Exists(img) == true)
                image = (Bitmap)Image.FromFile(img);
            _Texture.Image = image;

        }
        private void _TextureOpen_Click(object sender, EventArgs e) => Prompt.ShowIcon(image);
        private void _FileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void _Range__ValueChanged(object sender, EventArgs e)
        {

        }

        private void _Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _NewRecipy_Click(object sender, EventArgs e)
        {
            
        }
    }
}
