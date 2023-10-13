using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace TMC
{
    public partial class CreateComp : Form
    {
        public CreateComp()
        {
            InitializeComponent();
        }

        private void fetrToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void _ok_Click(object sender, EventArgs e)
        {
            if (_Type.SelectedItem == null)
            {
                MessageBox.Show("Select a component type to create component", "Select a type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tag = null;
                return;
            }
            if (!Directory.Exists(_SelPathInp.Text))
            {
                MessageBox.Show("Select an existing path", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tag = null;
                return;
            }
            Tag = _Type.SelectedItem.ToString() + "?" + "false" + "|" + _SelPathInp.Text;
        }

        private void _Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Selected = _Type.SelectedItem.ToString();
            if (Selected == "Item") _TypeDecs.Text = "Create an Item, ex. Axe, Accessory, Potion";
            if (Selected == "Recipy") _TypeDecs.Text = "Create a Recipy";
        }

        private void _Preset_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void _2_More_InputPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void _SelPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog();
            string FolderPath = folderBrowserDialog1.SelectedPath;
            bool Empty = false;
            bool Valid = Directory.Exists(FolderPath);
            if (FolderPath == "" || FolderPath == null || FolderPath == string.Empty)
                Empty = true;
            if ((Empty == false) && Valid && new string(FolderPath + "\\").StartsWith(Variables.ModPath + "\\"))
                _SelPathInp.Text = FolderPath;
            else if (!new string(FolderPath + "\\").StartsWith(Variables.ModPath + "\\"))
                MessageBox.Show($"Folder path needs to be inside the mod folder\n\n{FolderPath}", "Invalid Folder Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show($"Invalid Path\n\n{FolderPath}", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CreateComp_Load(object sender, EventArgs e)
        {

        }
    }
}
