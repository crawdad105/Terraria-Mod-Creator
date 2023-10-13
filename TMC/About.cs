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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        /* Abt */
        string _1 = "== About ==\n- Crawdad105\n- TMc\n  - TMc File\n  - This Program\n- Other";
        /* 105 */
        string _11 = "Crawdad105 is the hit youtuber who was the author of this program.\nThey make youtube youtube videos, programs and games.";
        /* tmc */
        string _12 = "== TMc ==\n- TMc File\n- This Program";
        /* >fi */
        string _121 = "TMc files are files specialy deisined for this program, it was made to more easly read data from items.\nThey are not made to be edited by people, only this program, however it is not imposible to read them.\nThe reson for them not being redable as a .txt format is so people dont edit values that are not suposed to be edited.";
        /* >pr */
        string _122 = "This Program was made to help people make mod for terraria.\nCurrinly it help you make items and recipes, in the future it will be posible to do more like create NPCs.";
        /* oth */
        string _13 = "There is nothing here.";

        /* crd */
        string _2 = "== Credit ==\n- Author\n- Insperation";
        /* aut */
        string _21 = "The author of this progeam was the hit youtuber crawdad105\nCheck out About>Crawdad105 for more info.";
        /* ins */
        string _22 = "This program was inspired by https://mcreator.net/.\nHowever it was for mincraft and wasint mutch help for people who wanted to make terraria mods.\nSo i (author) went looking for a program to help makes mods, i could not find one, so i create this program to because it didint exist before";

        /* mor */
        string _3 = "== More ==\n- Itch.io\n- Youtube\n- LORE\n";
        /* ich */
        string _31 = "Downlead this program in itch.io or check out other games made by crawdad105";
        /* you */
        string _32 = "Check out some videos by https://www.youtube.com/@crawdad105";
        /* lor */
        string _33 = "This program has been archived in image form.\nIt was oringly started around june 15th of 2022, developemt stoped when i (the creator) got bored and forgot about it for a long time.\nIn april of 2023 developemt began again, it only took about 1 to 1.5 months to get to where it is today.\nFuture plants will hofully be acomplished so people can make mods more easly.";


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "1") richTextBox1.Text = _1;
            if (e.Node.Name == "1.1") richTextBox1.Text = _11;
            if (e.Node.Name == "1.2") richTextBox1.Text = _12;
            if (e.Node.Name == "1.2.1") richTextBox1.Text = _121;
            if (e.Node.Name == "1.2.2") richTextBox1.Text = _122;
            if (e.Node.Name == "1.3") richTextBox1.Text = _13;
            if (e.Node.Name == "2") richTextBox1.Text = _2;
            if (e.Node.Name == "2.1") richTextBox1.Text = _21;
            if (e.Node.Name == "2.2") richTextBox1.Text = _22;
            if (e.Node.Name == "3") richTextBox1.Text = _3;
            if (e.Node.Name == "3.1") richTextBox1.Text = _31;
            if (e.Node.Name == "3.2") richTextBox1.Text = _32;
            if (e.Node.Name == "3.3") richTextBox1.Text = _33;
        }

        private void Button1_Click(object sender, EventArgs e) => Close();

        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            Prompt.AmountAboutOpen--;
        }
    }
}
