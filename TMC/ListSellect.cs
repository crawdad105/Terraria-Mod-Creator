using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMC
{
    public partial class ListSellect : Form
    {
        public string[] Opetions;
        public string[] OpetionsSorted;
        public string Type;
        public bool Modded;

        public int ItemAmount;
        public string ItemName;
        public string IfModName;
        public ListSellect()
        {
            InitializeComponent();
        }
        private void ListSellect_Load(object sender, EventArgs e)
        {
            _Type_1.Items.AddRange(Opetions);

            if (Type == "item")
            {
                _Lable1_1.Text = "Select Item";
                label1.Text = "Item Name:  (Use real name not desplay name)";
            }
            if (Type == "tile")
            {
                Amout1.Visible = false;
                amount1_.Visible = false;
                amount2.Visible = false;
                amount2_.Visible = false;
                _Lable1_1.Text = "Select Tile";
                label1.Text = "Tile Name:  (Use real name not desplay name)";
            }
        }
        private void _ok_Click(object sender, EventArgs e)
        {

            if (tabs.SelectedIndex == 0)
            {
                if (_Type_1.SelectedIndex == -1)
                {
                    MessageBox.Show("Make sure you actuly select a value", "Select a value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ItemName = _Type_1.Text;
                IfModName = "Vanilla";
                ItemAmount = (int)amount1_.Value;
                Modded = false;
            }
            if (tabs.SelectedIndex == 1)
            {
                string Valid = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_";

                string str = _ModName_2.Text;
                for (int i = 0; i < str.Length; i++)
                {
                    if (!Valid.Contains(str[i]))
                    {
                        MessageBox.Show($"{_Lable1_2.Text.Substring(0, _Lable1_2.Text.IndexOf(":"))} can only contain letters and/or numbers and underscore", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                string str1 = _ItemName_2.Text;
                for (int i = 0; i < str1.Length; i++)
                {
                    if (!Valid.Contains(str1[i]))
                    {
                        MessageBox.Show($"{label1.Text.Substring(0, label1.Text.IndexOf(":"))} can only contain letters and/or numbers and underscore", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (_ModName_2.Text.Trim().Length < 1 || _ItemName_2.Text.Trim().Length < 1)
                {
                    MessageBox.Show("Make sure you actuly select a value", "Select a value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ItemName = _ItemName_2.Text;
                IfModName = _ModName_2.Text;
                ItemAmount = (int)amount2_.Value;
                Modded = true;
            }
            DialogResult = DialogResult.OK;
        }

        private void Sort1_Click(object sender, EventArgs e)
        {
            _Type_1.Items.Clear();
            _Type_1.Items.AddRange(OpetionsSorted);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Type_1.Items.Clear();
            _Type_1.Items.AddRange(Opetions);
        }
    }
}
