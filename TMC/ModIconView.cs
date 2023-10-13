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
    public partial class ModIconView : Form
    {
        public ModIconView()
        {
            InitializeComponent();
        }

        private void ModIconView_Load(object sender, EventArgs e)
        {
            if (File.Exists(Tag.ToString()))
                pictureBox1.BackgroundImage = Image.FromFile(Tag.ToString());
            else
            {
                MessageBox.Show("Invalid Image", "Invalid Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
