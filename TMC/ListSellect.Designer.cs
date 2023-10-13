namespace TMC
{
    partial class ListSellect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListSellect));
            _Cancel = new Button();
            _ok = new Button();
            _Lable1_1 = new Label();
            _Type_1 = new ComboBox();
            tabs = new TabControl();
            Tab1 = new TabPage();
            button1 = new Button();
            Sort1 = new Button();
            amount1_ = new NumericUpDown();
            Amout1 = new Label();
            tab2 = new TabPage();
            amount2_ = new NumericUpDown();
            amount2 = new Label();
            label2 = new Label();
            _ItemName_2 = new TextBox();
            label1 = new Label();
            _ModName_2 = new TextBox();
            _Lable1_2 = new Label();
            tabs.SuspendLayout();
            Tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amount1_).BeginInit();
            tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amount2_).BeginInit();
            SuspendLayout();
            // 
            // _Cancel
            // 
            _Cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _Cancel.BackColor = Color.Silver;
            _Cancel.DialogResult = DialogResult.Cancel;
            _Cancel.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            _Cancel.Location = new Point(12, 277);
            _Cancel.Name = "_Cancel";
            _Cancel.Size = new Size(107, 35);
            _Cancel.TabIndex = 33;
            _Cancel.Text = "Cancel";
            _Cancel.UseVisualStyleBackColor = false;
            // 
            // _ok
            // 
            _ok.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _ok.BackColor = Color.Silver;
            _ok.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            _ok.Location = new Point(449, 277);
            _ok.Name = "_ok";
            _ok.Size = new Size(107, 35);
            _ok.TabIndex = 32;
            _ok.Text = "Add";
            _ok.UseVisualStyleBackColor = false;
            _ok.Click += _ok_Click;
            // 
            // _Lable1_1
            // 
            _Lable1_1.AutoSize = true;
            _Lable1_1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            _Lable1_1.Location = new Point(6, 6);
            _Lable1_1.Name = "_Lable1_1";
            _Lable1_1.Size = new Size(48, 15);
            _Lable1_1.TabIndex = 30;
            _Lable1_1.Text = "Sellect:";
            // 
            // _Type_1
            // 
            _Type_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _Type_1.BackColor = Color.Silver;
            _Type_1.FormattingEnabled = true;
            _Type_1.Location = new Point(6, 24);
            _Type_1.Name = "_Type_1";
            _Type_1.Size = new Size(524, 23);
            _Type_1.TabIndex = 29;
            // 
            // tabs
            // 
            tabs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabs.Controls.Add(Tab1);
            tabs.Controls.Add(tab2);
            tabs.Location = new Point(12, 12);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(544, 259);
            tabs.TabIndex = 35;
            // 
            // Tab1
            // 
            Tab1.BackColor = Color.DarkGray;
            Tab1.Controls.Add(button1);
            Tab1.Controls.Add(Sort1);
            Tab1.Controls.Add(amount1_);
            Tab1.Controls.Add(_Lable1_1);
            Tab1.Controls.Add(Amout1);
            Tab1.Controls.Add(_Type_1);
            Tab1.Location = new Point(4, 24);
            Tab1.Name = "Tab1";
            Tab1.Padding = new Padding(3);
            Tab1.Size = new Size(536, 231);
            Tab1.TabIndex = 0;
            Tab1.Text = "Vanilla";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(397, 82);
            button1.Name = "button1";
            button1.Size = new Size(133, 23);
            button1.TabIndex = 58;
            button1.Text = "Sort By ID";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Sort1
            // 
            Sort1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Sort1.BackColor = Color.Silver;
            Sort1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            Sort1.Location = new Point(397, 53);
            Sort1.Name = "Sort1";
            Sort1.Size = new Size(133, 23);
            Sort1.TabIndex = 36;
            Sort1.Text = "Sort Alphabeticly";
            Sort1.UseVisualStyleBackColor = false;
            Sort1.Click += Sort1_Click;
            // 
            // amount1_
            // 
            amount1_.BackColor = Color.LightGray;
            amount1_.ForeColor = SystemColors.MenuText;
            amount1_.ImeMode = ImeMode.NoControl;
            amount1_.Location = new Point(6, 68);
            amount1_.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            amount1_.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            amount1_.Name = "amount1_";
            amount1_.Size = new Size(115, 23);
            amount1_.TabIndex = 57;
            amount1_.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Amout1
            // 
            Amout1.AutoSize = true;
            Amout1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Amout1.Location = new Point(6, 50);
            Amout1.Name = "Amout1";
            Amout1.Size = new Size(55, 15);
            Amout1.TabIndex = 56;
            Amout1.Text = "Amount:";
            // 
            // tab2
            // 
            tab2.BackColor = Color.DarkGray;
            tab2.Controls.Add(amount2_);
            tab2.Controls.Add(amount2);
            tab2.Controls.Add(label2);
            tab2.Controls.Add(_ItemName_2);
            tab2.Controls.Add(label1);
            tab2.Controls.Add(_ModName_2);
            tab2.Controls.Add(_Lable1_2);
            tab2.Location = new Point(4, 24);
            tab2.Name = "tab2";
            tab2.Padding = new Padding(3);
            tab2.Size = new Size(536, 231);
            tab2.TabIndex = 1;
            tab2.Text = "Modded";
            // 
            // amount2_
            // 
            amount2_.BackColor = Color.LightGray;
            amount2_.ForeColor = SystemColors.MenuText;
            amount2_.ImeMode = ImeMode.NoControl;
            amount2_.Location = new Point(6, 200);
            amount2_.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            amount2_.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            amount2_.Name = "amount2_";
            amount2_.Size = new Size(115, 23);
            amount2_.TabIndex = 55;
            amount2_.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // amount2
            // 
            amount2.AutoSize = true;
            amount2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            amount2.Location = new Point(6, 182);
            amount2.Name = "amount2";
            amount2.Size = new Size(55, 15);
            amount2.TabIndex = 42;
            amount2.Text = "Amount:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 8);
            label2.Name = "label2";
            label2.Size = new Size(485, 75);
            label2.TabIndex = 41;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // _ItemName_2
            // 
            _ItemName_2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _ItemName_2.BackColor = Color.Silver;
            _ItemName_2.Location = new Point(6, 156);
            _ItemName_2.Name = "_ItemName_2";
            _ItemName_2.Size = new Size(524, 23);
            _ItemName_2.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 138);
            label1.Name = "label1";
            label1.Size = new Size(236, 15);
            label1.TabIndex = 39;
            label1.Text = "Name:  (Use real name not desplay name)";
            // 
            // _ModName_2
            // 
            _ModName_2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _ModName_2.BackColor = Color.Silver;
            _ModName_2.Location = new Point(6, 112);
            _ModName_2.Name = "_ModName_2";
            _ModName_2.Size = new Size(524, 23);
            _ModName_2.TabIndex = 38;
            // 
            // _Lable1_2
            // 
            _Lable1_2.AutoSize = true;
            _Lable1_2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            _Lable1_2.Location = new Point(6, 94);
            _Lable1_2.Name = "_Lable1_2";
            _Lable1_2.Size = new Size(405, 15);
            _Lable1_2.TabIndex = 36;
            _Lable1_2.Text = "Mod Name: (Use real name not desplay name) (Keep blank for this mod)";
            // 
            // ListSellect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(564, 324);
            Controls.Add(tabs);
            Controls.Add(_Cancel);
            Controls.Add(_ok);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(580, 320);
            Name = "ListSellect";
            Text = "ListSellect";
            Load += ListSellect_Load;
            tabs.ResumeLayout(false);
            Tab1.ResumeLayout(false);
            Tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amount1_).EndInit();
            tab2.ResumeLayout(false);
            tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amount2_).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox _SelPathInp;
        private Button _Cancel;
        private Button _ok;
        private Label _TypeDecs;
        private Label _Lable1_1;
        private ComboBox _Type_1;
        private TabControl tabs;
        private TabPage Tab1;
        private TabPage tab2;
        private Label _Lable1_2;
        private TextBox _ItemName_2;
        private Label label1;
        private TextBox _ModName_2;
        private Label label2;
        private Label amount2;
        private NumericUpDown amount2_;
        private NumericUpDown amount1_;
        private Label Amout1;
        private Button button1;
        private Button Sort1;
    }
}