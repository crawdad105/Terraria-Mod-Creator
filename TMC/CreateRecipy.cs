using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TMC
{
    public partial class CreateRecipy : Form
    {
        public CreateRecipy()
        {
            InitializeComponent();
        }

        public bool GlobalRecipy;

        public string path;

        List<TMC.FileBuilders.RecipeBuilder> Recipes =
            new List<TMC.FileBuilders.RecipeBuilder>();

        private void CreateRecipy_Load(object sender, EventArgs e)
        {
            _PathInput.Text = path;
        }

        private void _Close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close this menue\nAll unsaved (uncompiled) progress will be lost", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
                Close();
        }
        private void _AddIngredient_Click(object sender, EventArgs e)
        {
            bool Mod;
            string str = Prompt.OpenListSellect(Lists.ByIDs.Items.ToArray(), Lists.ByNames.Items.ToArray(), "item", out Mod);
            if (!Mod) str = str.Substring(0, str.IndexOf("|"));
            if (!str.StartsWith(",")) _RecipyView.Nodes.Add(str);
        }
        private void _RemoveIngredient_Click(object sender, EventArgs e)
        {
            if (_RecipyView.SelectedNode == null)
            {
                MessageBox.Show("Select an ingredient to deleat an ingridient", "No Ingredient Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                _RecipyView.SelectedNode.Remove();
            }
        }
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
                _FileName.Text = FolderPath;
        }

        private void _AddTile_Click(object sender, EventArgs e)
        {
            bool Mod;
            string str = Prompt.OpenListSellect(Lists.ByIDs.Tiles.ToArray(), Lists.ByNames.Tiles.ToArray(), "tile", out Mod);
            if (!Mod) str = str.Substring(0, str.IndexOf("|"));
            if (!str.StartsWith(",")) _TileView.Nodes.Add(str.Replace(", 1", ""));
        }

        private void _RemoveTile_Click(object sender, EventArgs e)
        {
            if (_TileView.SelectedNode == null)
            {
                MessageBox.Show("Select an ingredient to deleat an ingridient", "No Ingredient Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                _TileView.SelectedNode.Remove();
            }
        }

        private void _SetRecult_Click(object sender, EventArgs e)
        {
            bool Mod;
            _Result.Nodes.Clear();
            string str = Prompt.OpenListSellect(Lists.ByIDs.Items.ToArray(), Lists.ByNames.Items.ToArray(), "item", out Mod);
            if (!Mod) str = str.Substring(0, str.IndexOf("|"));
            if (!str.StartsWith(",")) _Result.Nodes.Add(str);
        }

        private void _Compile_Click(object sender, EventArgs e)
        {
            string TestValues(out List<string> Missings)
            {
                Missings = new List<string>();
                if (!Other.IsValidFileName(_FileName.Text))
                {
                    Missings.Add("File name can only contain: ");
                    Missings.Add("Numbers, Letters (incudes uppercase) and Underscores");
                    Missings.Add("It can not however start with a number");
                    return "Invalid File Name";
                }
                for (int i = 0; i < Recipes.Count; i++)
                {
                    if (Recipes[i].ResipeName == _FileName.Text)
                    {
                        Missings.Add("File not can not be the same as any recipy");
                        return "Invalid File Name";
                    }
                }
                if (_FileName.Text.Length < 1)
                    Missings.Add("File name reqires a result");
                if (_MainTreeView.Nodes.Count < 1)
                    Missings.Add("To compile recipy you need at least 1 recipy");
                return "Missing Values";
            }

            List<string> Missings = new List<string>();
            string Msg = TestValues(out Missings);
            if (Missings.Count > 0)
            {
                MessageBox.Show($"" + string.Join("\n", Missings), Msg, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (GlobalRecipy)
            {
                string name = _FileName.Text;

                List<string> CSlines = new List<string>();

                List<string>? Lines = TMC.FileCompilers.CompileRecipe.CompileToScript(Recipes);
                if (Lines == null)
                {
                    MessageBox.Show($"Error while compiling script", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                CSlines.Add($"//This Scrip Was Made Using TMc");
                CSlines.Add($"using Terraria;");
                CSlines.Add($"using Terraria.ID");
                CSlines.Add($"using Terraria.ModLoader;");
                CSlines.Add($"namespace {_PathInput.Text.Replace(Variables.SubModPath + "\\", "").Replace("\\", ".").Replace(" ", "_")} ");
                CSlines.Add(@"{");
                CSlines.Add($"    public class {name} : ModSystem");
                CSlines.Add(@"    {");
                for (int i = 0; i < Lines.Count; i++)
                {
                    CSlines.Add(@"        " + Lines[i]);
                }
                CSlines.Add(@"    }");
                CSlines.Add(@"}");
                /*This Scrip Was Made Using TMc
                namespace TMc.Recipies
                {
                    public class carf : ModSystem
                    {
                
                    }
                }
                */

                bool Er = false;
                string Stage = "";
                DialogResult dialogResult1 = DialogResult.Yes;
                DialogResult dialogResult2 = DialogResult.Yes;
                bool Aask() => (dialogResult1 == DialogResult.Yes && dialogResult2 == DialogResult.Yes);
                if (Aask() && File.Exists(_PathInput.Text + "\\" + name + ".cs"))
                    dialogResult1 = MessageBox.Show($"A file with the name \"{(name + ".cs")}\"\nDo you want to override it?", "Do you or not?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (Aask() && File.Exists(_PathInput.Text + "\\" + name + ".tmc"))
                    dialogResult2 = MessageBox.Show($"A file with the name \"{(name + ".tmc")}\"\nDo you want to override it?", "Do you or not?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dialogResult1 == DialogResult.Yes && dialogResult2 == DialogResult.Yes && Er == false)
                {
                    try
                    {
                        File.WriteAllLines(_PathInput.Text + "\\" + name + ".cs", CSlines.ToArray());
                    }
                    catch (Exception)
                    {
                        File.Delete(_PathInput.Text + "\\" + name + ".cs");
                        Er = true;
                        Stage = "creating .cs file";
                    }
                }

                if (dialogResult1 == DialogResult.Yes && dialogResult2 == DialogResult.Yes && Er == false)
                {
                    try
                    {
                        List<List<string>> TMcLines = TMC.FileCompilers.CompileRecipe.CompileToTMc(Recipes);

                        string Name = _PathInput.Text + "\\" + "TEMP";
                        DirectoryInfo directory = Directory.CreateDirectory(Name);

                        for (int i = 0; i < TMcLines.Count; i++)
                        {
                            File.WriteAllLines(Name + "\\" + $"recipy{i}", TMcLines[i].ToArray());
                        }

                        File.WriteAllText(Name + "\\" + "type", "recipy");
                        File.WriteAllText(Name + "\\" + "version", $"VERSION={VERSION.NUMBER}");
                        if (File.Exists(_PathInput.Text + "\\" + name + ".tmc")) File.Delete(_PathInput.Text + "\\" + name + ".tmc");
                        ZipFile.CreateFromDirectory(Name, _PathInput.Text + "\\" + name + ".tmc");

                    }
                    catch (Exception)
                    {
                        File.Delete(_PathInput.Text + "\\" + name + ".cs");
                        File.Delete(_PathInput.Text + "\\" + name + ".tmc");
                        if (Directory.Exists(_PathInput.Text + "\\" + "TEMP")) Directory.Delete(_PathInput.Text + "\\" + "TEMP", true);
                        Er = true;
                        Stage = "creating .tmc file";
                    }
                }

                if (dialogResult1 != DialogResult.Yes || dialogResult2 != DialogResult.Yes)
                {
                    MessageBox.Show($"Did not create files because you said not to.", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
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
            if (!GlobalRecipy)
            {

            }
        }

        private void _AddRecipy_Click(object sender, EventArgs e)
        {
            TMC.FileBuilders.RecipeBuilder Recipe = new TMC.FileBuilders.RecipeBuilder();

            for (int i = 0; i < _MainTreeView.Nodes.Count; i++)
            {
                if (_MainTreeView.Nodes[i].Text == _RecipeName.Text)
                {
                    string str = "A recipe with this name alredy exists";
                    MessageBox.Show(str, "Invalid Resipy Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!Other.IsValidCodeName(_RecipeName.Text))
            {
                string str = "Recipe name can only contain: \nNumbers, Letters (incudes uppercase) and Underscores\nIt can not however start with a number";
                MessageBox.Show(str, "Invalid Recipe Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_RecipeName.Text.Length < 1)
            {
                string str = "Recipe name has to exist";
                MessageBox.Show(str, "Invalid Properties", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_Result.Nodes.Count < 1)
            {
                string str = "Recipe reqires a result";
                MessageBox.Show(str, "Invalid Properties", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_RecipyView.Nodes.Count < 1)
            {
                string str = "Recipe reqires at least 1 ingreadient";
                MessageBox.Show(str, "Invalid Properties", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < _RecipyView.Nodes.Count; i++)
            {
                Recipe.Ingredients.Add(new TMC.FileBuilders.RecipeBuilder.Item(_RecipyView.Nodes[i].Text));
            }
            for (int i = 0; i < _TileView.Nodes.Count; i++)
            {
                Recipe.Tiles.Add(new TMC.FileBuilders.RecipeBuilder.Tile(_TileView.Nodes[i].Text));
            }
            Recipe.Result = new TMC.FileBuilders.RecipeBuilder.Item(_Result.Nodes[0].Text);
            Recipe.ResipeName = _RecipeName.Text;
            Recipes.Add(Recipe);

            _MainTreeView.Nodes.Add(_RecipeName.Text);
        }

        private void _EditRecipe_Click(object sender, EventArgs e)
        {

            TMC.FileBuilders.RecipeBuilder? Recipe = null;
            for (int i = 0; i < Recipes.Count; i++)
            {
                if (_MainTreeView.SelectedNode.Text == Recipes[i].ResipeName)
                    Recipe = Recipes[i];
            }
            if (_MainTreeView.SelectedNode == null)
            {
                MessageBox.Show("No recipe selected", "select a recipe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Recipe == null)
            {
                MessageBox.Show("Recipy could not be red", "You shouldint beable to see this", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Current unsaved recipy will be lost\nAre you sure you want to open a new recipy", "Are you sure", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dialogResult != DialogResult.Yes)
                return;
            _RecipyView.Nodes.Clear();
            _TileView.Nodes.Clear();
            _Result.Nodes.Clear();

            List<TreeNode> TNA1 = new List<TreeNode>();
            List<TreeNode> TNA2 = new List<TreeNode>();
            List<TreeNode> TNA3 = new List<TreeNode>();
            for (int i = 0; i < Recipe.Ingredients.Count; i++)
            {
                TNA1.Add(new TreeNode(Recipe.Ingredients[i].GetString));
            }
            for (int i = 0; i < Recipe.Tiles.Count; i++)
            {
                TNA2.Add(new TreeNode(Recipe.Tiles[i].GetString));
            }
            TNA3.Add(new TreeNode(Recipe.Result.GetString));

            _RecipyView.Nodes.AddRange(TNA1.ToArray());
            _TileView.Nodes.AddRange(TNA2.ToArray());
            _Result.Nodes.AddRange(TNA3.ToArray());

            _RecipeName.Text = Recipe.ResipeName;
        }

        private void _RemoveRecipe_Click(object sender, EventArgs e)
        {

            TMC.FileBuilders.RecipeBuilder? Recipe = null;
            for (int i = 0; i < Recipes.Count; i++)
            {
                if (_MainTreeView.SelectedNode.Text == Recipes[i].ResipeName)
                    Recipe = Recipes[i];
            }
            if (_MainTreeView.SelectedNode == null)
            {
                MessageBox.Show("No recipe selected", "select a recipe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Recipe == null)
            {
                MessageBox.Show("Recipy could not be red", "You shouldint beable to see this", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to deleat this recipy\nyou are not able to get it back ever", "Are you sure", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dialogResult != DialogResult.Yes)
                return;
            Recipes.Remove(Recipe);
            for (int i = 0; i < _MainTreeView.Nodes.Count; i++)
            {
                if (_MainTreeView.Nodes[i].Text == Recipe.ResipeName)
                {
                    _MainTreeView.Nodes[i].Remove();
                }
            }
            if (Recipe.ResipeName == _FileName.Text)
            {
                _RecipyView.Nodes.Clear();
                _TileView.Nodes.Clear();
                _Result.Nodes.Clear();
            }
        }
    }
}