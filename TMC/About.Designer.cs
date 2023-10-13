namespace TMC
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TreeNode treeNode1 = new TreeNode("Crawdad105", 1, 1);
            TreeNode treeNode2 = new TreeNode("TMc file");
            TreeNode treeNode3 = new TreeNode("This Program");
            TreeNode treeNode4 = new TreeNode("TMc", new TreeNode[] { treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("Other", 3, 3);
            TreeNode treeNode6 = new TreeNode("About", 5, 5, new TreeNode[] { treeNode1, treeNode4, treeNode5 });
            TreeNode treeNode7 = new TreeNode("Author", 1, 1);
            TreeNode treeNode8 = new TreeNode("Insperation", 3, 3);
            TreeNode treeNode9 = new TreeNode("Creadit", 5, 5, new TreeNode[] { treeNode7, treeNode8 });
            TreeNode treeNode10 = new TreeNode("Itch.io", 2, 2);
            TreeNode treeNode11 = new TreeNode("Youtube", 4, 4);
            TreeNode treeNode12 = new TreeNode("LORE", 3, 3);
            TreeNode treeNode13 = new TreeNode("More", 5, 5, new TreeNode[] { treeNode10, treeNode11, treeNode12 });
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            treeView1 = new TreeView();
            imageList1 = new ImageList(components);
            richTextBox1 = new RichTextBox();
            Button1 = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            treeView1.BackColor = Color.Silver;
            treeView1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            treeView1.ImageIndex = 0;
            treeView1.ImageList = imageList1;
            treeView1.Indent = 20;
            treeView1.ItemHeight = 18;
            treeView1.Location = new Point(12, 12);
            treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "1.1";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Crawdad105";
            treeNode2.Name = "1.2.1";
            treeNode2.Text = "TMc file";
            treeNode3.Name = "1.2.2";
            treeNode3.Text = "This Program";
            treeNode4.Name = "1.2";
            treeNode4.Text = "TMc";
            treeNode5.ImageIndex = 3;
            treeNode5.Name = "1.3";
            treeNode5.SelectedImageIndex = 3;
            treeNode5.Text = "Other";
            treeNode6.ImageIndex = 5;
            treeNode6.Name = "1";
            treeNode6.SelectedImageIndex = 5;
            treeNode6.Text = "About";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "2.1";
            treeNode7.SelectedImageIndex = 1;
            treeNode7.Text = "Author";
            treeNode8.ImageIndex = 3;
            treeNode8.Name = "2.2";
            treeNode8.SelectedImageIndex = 3;
            treeNode8.Text = "Insperation";
            treeNode9.ImageIndex = 5;
            treeNode9.Name = "2";
            treeNode9.SelectedImageIndex = 5;
            treeNode9.Text = "Creadit";
            treeNode10.ImageIndex = 2;
            treeNode10.Name = "3.1";
            treeNode10.SelectedImageIndex = 2;
            treeNode10.Text = "Itch.io";
            treeNode11.ImageIndex = 4;
            treeNode11.Name = "3.2";
            treeNode11.SelectedImageIndex = 4;
            treeNode11.Text = "Youtube";
            treeNode12.ImageIndex = 3;
            treeNode12.Name = "3.3";
            treeNode12.SelectedImageIndex = 3;
            treeNode12.Text = "LORE";
            treeNode13.ImageIndex = 5;
            treeNode13.Name = "3";
            treeNode13.SelectedImageIndex = 5;
            treeNode13.Text = "More";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode6, treeNode9, treeNode13 });
            treeView1.SelectedImageIndex = 0;
            treeView1.Size = new Size(176, 245);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "TMC.ico");
            imageList1.Images.SetKeyName(1, "105.ico");
            imageList1.Images.SetKeyName(2, "ich.ico");
            imageList1.Images.SetKeyName(3, "Notes.ico");
            imageList1.Images.SetKeyName(4, "youtub.ico");
            imageList1.Images.SetKeyName(5, "Folder.ico");
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = Color.LightGray;
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.Location = new Point(194, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(348, 281);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // Button1
            // 
            Button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Button1.BackColor = Color.LightGray;
            Button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Button1.Location = new Point(12, 263);
            Button1.Name = "Button1";
            Button1.Size = new Size(176, 30);
            Button1.TabIndex = 10;
            Button1.Text = "Close";
            Button1.UseVisualStyleBackColor = false;
            Button1.Click += Button1_Click;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(554, 301);
            Controls.Add(Button1);
            Controls.Add(richTextBox1);
            Controls.Add(treeView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(570, 340);
            Name = "About";
            Text = "About";
            FormClosed += About_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private ImageList imageList1;
        private RichTextBox richTextBox1;
        private Button Button1;
    }
}