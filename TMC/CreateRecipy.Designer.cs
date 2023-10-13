namespace TMC
{
    partial class CreateRecipy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRecipy));
            _Close = new Button();
            _31 = new GroupBox();
            label2 = new Label();
            _RemoveIngredient = new Button();
            _AddIngredient = new Button();
            _RecipyView = new TreeView();
            _PathLable = new Label();
            _PathInput = new TextBox();
            _PathMove = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            _RemoveTile = new Button();
            _AddTile = new Button();
            _TileView = new TreeView();
            groupBox2 = new GroupBox();
            label5 = new Label();
            _SetRecult = new Button();
            _Result = new TreeView();
            groupBox3 = new GroupBox();
            label7 = new Label();
            label45 = new Label();
            _RecipeName = new TextBox();
            _AddRecipy = new Button();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            _RemoveRecipe = new Button();
            _EditRecipe = new Button();
            _MainTreeView = new TreeView();
            groupBox6 = new GroupBox();
            label1 = new Label();
            _FileName = new TextBox();
            label4 = new Label();
            _Compile = new Button();
            button2 = new Button();
            _31.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // _Close
            // 
            _Close.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _Close.BackColor = Color.Silver;
            _Close.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _Close.Location = new Point(6, 158);
            _Close.Name = "_Close";
            _Close.Size = new Size(151, 54);
            _Close.TabIndex = 72;
            _Close.Text = "Close\r\n(All progress will be lost)";
            _Close.UseVisualStyleBackColor = false;
            _Close.Click += _Close_Click;
            // 
            // _31
            // 
            _31.Controls.Add(label2);
            _31.Controls.Add(_RemoveIngredient);
            _31.Controls.Add(_AddIngredient);
            _31.Controls.Add(_RecipyView);
            _31.Location = new Point(12, 19);
            _31.Name = "_31";
            _31.Size = new Size(272, 393);
            _31.TabIndex = 73;
            _31.TabStop = false;
            _31.Text = "Ingredient(s)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 19);
            label2.Name = "label2";
            label2.Size = new Size(207, 15);
            label2.TabIndex = 77;
            label2.Text = "The ingredients that this item will cost";
            // 
            // _RemoveIngredient
            // 
            _RemoveIngredient.Anchor = AnchorStyles.Bottom;
            _RemoveIngredient.BackColor = Color.Silver;
            _RemoveIngredient.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _RemoveIngredient.Location = new Point(144, 362);
            _RemoveIngredient.Name = "_RemoveIngredient";
            _RemoveIngredient.Size = new Size(122, 25);
            _RemoveIngredient.TabIndex = 81;
            _RemoveIngredient.Text = "Remove Ingredient";
            _RemoveIngredient.UseVisualStyleBackColor = false;
            _RemoveIngredient.Click += _RemoveIngredient_Click;
            // 
            // _AddIngredient
            // 
            _AddIngredient.Anchor = AnchorStyles.Bottom;
            _AddIngredient.BackColor = Color.Silver;
            _AddIngredient.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _AddIngredient.Location = new Point(6, 362);
            _AddIngredient.Name = "_AddIngredient";
            _AddIngredient.Size = new Size(122, 25);
            _AddIngredient.TabIndex = 75;
            _AddIngredient.Text = "Add Ingredient";
            _AddIngredient.UseVisualStyleBackColor = false;
            _AddIngredient.Click += _AddIngredient_Click;
            // 
            // _RecipyView
            // 
            _RecipyView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _RecipyView.BackColor = Color.Silver;
            _RecipyView.Location = new Point(6, 40);
            _RecipyView.Name = "_RecipyView";
            _RecipyView.Size = new Size(260, 316);
            _RecipyView.TabIndex = 80;
            // 
            // _PathLable
            // 
            _PathLable.AutoSize = true;
            _PathLable.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _PathLable.Location = new Point(12, 9);
            _PathLable.Name = "_PathLable";
            _PathLable.Size = new Size(55, 15);
            _PathLable.TabIndex = 66;
            _PathLable.Text = "File Path:";
            // 
            // _PathInput
            // 
            _PathInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _PathInput.BackColor = Color.Silver;
            _PathInput.Location = new Point(73, 6);
            _PathInput.Name = "_PathInput";
            _PathInput.ReadOnly = true;
            _PathInput.Size = new Size(963, 23);
            _PathInput.TabIndex = 65;
            _PathInput.Text = "\\\\\\\\";
            // 
            // _PathMove
            // 
            _PathMove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _PathMove.BackColor = Color.Silver;
            _PathMove.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _PathMove.Location = new Point(1042, 6);
            _PathMove.Name = "_PathMove";
            _PathMove.Size = new Size(102, 25);
            _PathMove.TabIndex = 74;
            _PathMove.Text = "Change Path";
            _PathMove.UseVisualStyleBackColor = false;
            _PathMove.Click += _PathMove_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(_RemoveTile);
            groupBox1.Controls.Add(_AddTile);
            groupBox1.Controls.Add(_TileView);
            groupBox1.Location = new Point(290, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 393);
            groupBox1.TabIndex = 76;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tile(s)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 19);
            label3.Name = "label3";
            label3.Size = new Size(217, 15);
            label3.TabIndex = 82;
            label3.Text = "The tiles where this item will be made at\r\n";
            // 
            // _RemoveTile
            // 
            _RemoveTile.Anchor = AnchorStyles.Bottom;
            _RemoveTile.BackColor = Color.Silver;
            _RemoveTile.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _RemoveTile.Location = new Point(144, 362);
            _RemoveTile.Name = "_RemoveTile";
            _RemoveTile.Size = new Size(122, 25);
            _RemoveTile.TabIndex = 81;
            _RemoveTile.Text = "Remove Tile";
            _RemoveTile.UseVisualStyleBackColor = false;
            _RemoveTile.Click += _RemoveTile_Click;
            // 
            // _AddTile
            // 
            _AddTile.Anchor = AnchorStyles.Bottom;
            _AddTile.BackColor = Color.Silver;
            _AddTile.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _AddTile.Location = new Point(6, 362);
            _AddTile.Name = "_AddTile";
            _AddTile.Size = new Size(122, 25);
            _AddTile.TabIndex = 75;
            _AddTile.Text = "Add Tile";
            _AddTile.UseVisualStyleBackColor = false;
            _AddTile.Click += _AddTile_Click;
            // 
            // _TileView
            // 
            _TileView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _TileView.BackColor = Color.Silver;
            _TileView.Location = new Point(6, 40);
            _TileView.Name = "_TileView";
            _TileView.Size = new Size(260, 316);
            _TileView.TabIndex = 80;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(_SetRecult);
            groupBox2.Controls.Add(_Result);
            groupBox2.Location = new Point(568, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(272, 137);
            groupBox2.TabIndex = 78;
            groupBox2.TabStop = false;
            groupBox2.Text = "Result";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(54, 19);
            label5.Name = "label5";
            label5.Size = new Size(154, 15);
            label5.TabIndex = 82;
            label5.Text = "The item that will be crafted";
            // 
            // _SetRecult
            // 
            _SetRecult.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _SetRecult.BackColor = Color.Silver;
            _SetRecult.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _SetRecult.Location = new Point(6, 102);
            _SetRecult.Name = "_SetRecult";
            _SetRecult.Size = new Size(122, 25);
            _SetRecult.TabIndex = 75;
            _SetRecult.Text = "Set Result";
            _SetRecult.UseVisualStyleBackColor = false;
            _SetRecult.Click += _SetRecult_Click;
            // 
            // _Result
            // 
            _Result.BackColor = Color.Silver;
            _Result.Location = new Point(6, 40);
            _Result.Name = "_Result";
            _Result.Size = new Size(260, 56);
            _Result.TabIndex = 80;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label45);
            groupBox3.Controls.Add(_RecipeName);
            groupBox3.Controls.Add(_AddRecipy);
            groupBox3.Location = new Point(568, 162);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(272, 250);
            groupBox3.TabIndex = 83;
            groupBox3.TabStop = false;
            groupBox3.Text = "Add Recipe";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(30, 106);
            label7.Name = "label7";
            label7.Size = new Size(211, 24);
            label7.TabIndex = 77;
            label7.Text = "^ This will add a recipy node to the recipe view\r\nyou will be abel to edit it later";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label45.Location = new Point(6, 21);
            label45.Name = "label45";
            label45.Size = new Size(80, 15);
            label45.TabIndex = 76;
            label45.Text = "Recipe Name:";
            // 
            // _RecipeName
            // 
            _RecipeName.BackColor = Color.LightGray;
            _RecipeName.Location = new Point(6, 39);
            _RecipeName.Name = "_RecipeName";
            _RecipeName.Size = new Size(260, 23);
            _RecipeName.TabIndex = 75;
            // 
            // _AddRecipy
            // 
            _AddRecipy.BackColor = Color.Silver;
            _AddRecipy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _AddRecipy.Location = new Point(6, 68);
            _AddRecipy.Name = "_AddRecipy";
            _AddRecipy.Size = new Size(260, 35);
            _AddRecipy.TabIndex = 74;
            _AddRecipy.Text = "Add Recipe";
            _AddRecipy.UseVisualStyleBackColor = false;
            _AddRecipy.Click += _AddRecipy_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(_31);
            groupBox4.Controls.Add(groupBox3);
            groupBox4.Controls.Add(groupBox1);
            groupBox4.Controls.Add(groupBox2);
            groupBox4.Location = new Point(291, 35);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(853, 419);
            groupBox4.TabIndex = 82;
            groupBox4.TabStop = false;
            groupBox4.Text = "Create Recipe";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(_RemoveRecipe);
            groupBox5.Controls.Add(_EditRecipe);
            groupBox5.Controls.Add(_MainTreeView);
            groupBox5.Location = new Point(12, 35);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(272, 198);
            groupBox5.TabIndex = 82;
            groupBox5.TabStop = false;
            groupBox5.Text = "Recipes";
            // 
            // _RemoveRecipe
            // 
            _RemoveRecipe.Anchor = AnchorStyles.Bottom;
            _RemoveRecipe.BackColor = Color.Silver;
            _RemoveRecipe.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _RemoveRecipe.Location = new Point(153, 167);
            _RemoveRecipe.Name = "_RemoveRecipe";
            _RemoveRecipe.Size = new Size(113, 25);
            _RemoveRecipe.TabIndex = 83;
            _RemoveRecipe.Text = "Deleat Recipe";
            _RemoveRecipe.UseVisualStyleBackColor = false;
            _RemoveRecipe.Click += _RemoveRecipe_Click;
            // 
            // _EditRecipe
            // 
            _EditRecipe.Anchor = AnchorStyles.Bottom;
            _EditRecipe.BackColor = Color.Silver;
            _EditRecipe.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _EditRecipe.Location = new Point(6, 167);
            _EditRecipe.Name = "_EditRecipe";
            _EditRecipe.Size = new Size(112, 25);
            _EditRecipe.TabIndex = 82;
            _EditRecipe.Text = "Edit Recipe";
            _EditRecipe.UseVisualStyleBackColor = false;
            _EditRecipe.Click += _EditRecipe_Click;
            // 
            // _MainTreeView
            // 
            _MainTreeView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _MainTreeView.BackColor = Color.Silver;
            _MainTreeView.Location = new Point(6, 22);
            _MainTreeView.Name = "_MainTreeView";
            _MainTreeView.Size = new Size(260, 139);
            _MainTreeView.TabIndex = 80;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label1);
            groupBox6.Controls.Add(_FileName);
            groupBox6.Controls.Add(label4);
            groupBox6.Controls.Add(_Compile);
            groupBox6.Controls.Add(_Close);
            groupBox6.Controls.Add(button2);
            groupBox6.Location = new Point(12, 236);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(272, 218);
            groupBox6.TabIndex = 84;
            groupBox6.TabStop = false;
            groupBox6.Text = "Compleat Recipe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 21);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 76;
            label1.Text = "File Name:";
            // 
            // _FileName
            // 
            _FileName.BackColor = Color.LightGray;
            _FileName.Location = new Point(6, 39);
            _FileName.Name = "_FileName";
            _FileName.Size = new Size(260, 23);
            _FileName.TabIndex = 75;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 106);
            label4.Name = "label4";
            label4.Size = new Size(165, 24);
            label4.TabIndex = 73;
            label4.Text = "^ Compiling this item will also create\r\n a '.TMc' file in the same file location";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _Compile
            // 
            _Compile.BackColor = Color.Silver;
            _Compile.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _Compile.Location = new Point(6, 68);
            _Compile.Name = "_Compile";
            _Compile.Size = new Size(260, 35);
            _Compile.TabIndex = 74;
            _Compile.Text = "Compile to Recipy Script";
            _Compile.UseVisualStyleBackColor = false;
            _Compile.Click += _Compile_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Silver;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(187, 300);
            button2.Name = "button2";
            button2.Size = new Size(151, 54);
            button2.TabIndex = 72;
            button2.Text = "Close\r\n(All progress will be lost)";
            button2.UseVisualStyleBackColor = false;
            // 
            // CreateRecipy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1156, 461);
            Controls.Add(groupBox6);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(_PathMove);
            Controls.Add(_PathLable);
            Controls.Add(_PathInput);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(865, 500);
            Name = "CreateRecipy";
            Text = "Create Recipe";
            Load += CreateRecipy_Load;
            _31.ResumeLayout(false);
            _31.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button _Close;
        private GroupBox _31;
        private Label _PathLable;
        private TextBox _PathInput;
        private Button _PathMove;
        private Label label2;
        private Button _RemoveIngredient;
        private Button _AddIngredient;
        private TreeView _RecipyView;
        private GroupBox groupBox1;
        private Label label3;
        private Button _RemoveTile;
        private Button _AddTile;
        private TreeView _TileView;
        private GroupBox groupBox2;
        private Label label5;
        private Button _SetRecult;
        private TreeView _Result;
        private GroupBox groupBox3;
        private Label label45;
        private TextBox _RecipeName;
        private Button _AddRecipy;
        private GroupBox groupBox4;
        private GroupBox groupBox6;
        private Label label1;
        private TextBox _FileName;
        private Label label4;
        private Button _Compile;
        private Button button2;
        private GroupBox groupBox5;
        private TreeView _MainTreeView;
        private Label label7;
        private Button _RemoveRecipe;
        private Button _EditRecipe;
    }
}