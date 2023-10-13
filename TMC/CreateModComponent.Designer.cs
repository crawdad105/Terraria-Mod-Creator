namespace TMC
{
    partial class CreateComp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateComp));
            _Type = new ComboBox();
            _Lable = new Label();
            _TypeDecs = new Label();
            _ok = new Button();
            _Cancel = new Button();
            _SelPathInp = new TextBox();
            _SelPath = new Button();
            SuspendLayout();
            // 
            // _Type
            // 
            _Type.BackColor = Color.Silver;
            _Type.FormattingEnabled = true;
            _Type.Items.AddRange(new object[] { "Item", "Recipy" });
            _Type.Location = new Point(12, 33);
            _Type.Name = "_Type";
            _Type.Size = new Size(193, 23);
            _Type.TabIndex = 0;
            _Type.SelectedIndexChanged += _Type_SelectedIndexChanged;
            // 
            // _Lable
            // 
            _Lable.AutoSize = true;
            _Lable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            _Lable.Location = new Point(12, 15);
            _Lable.Name = "_Lable";
            _Lable.Size = new Size(145, 15);
            _Lable.TabIndex = 2;
            _Lable.Text = "Sellect Component Type:";
            // 
            // _TypeDecs
            // 
            _TypeDecs.AutoSize = true;
            _TypeDecs.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            _TypeDecs.Location = new Point(12, 59);
            _TypeDecs.Name = "_TypeDecs";
            _TypeDecs.Size = new Size(57, 15);
            _TypeDecs.TabIndex = 3;
            _TypeDecs.Text = "File Path:";
            // 
            // _ok
            // 
            _ok.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _ok.BackColor = Color.Silver;
            _ok.DialogResult = DialogResult.OK;
            _ok.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _ok.Location = new Point(328, 124);
            _ok.Name = "_ok";
            _ok.Size = new Size(105, 30);
            _ok.TabIndex = 24;
            _ok.Text = "Create";
            _ok.UseVisualStyleBackColor = false;
            _ok.Click += _ok_Click;
            // 
            // _Cancel
            // 
            _Cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _Cancel.BackColor = Color.Silver;
            _Cancel.DialogResult = DialogResult.Cancel;
            _Cancel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _Cancel.Location = new Point(12, 124);
            _Cancel.Name = "_Cancel";
            _Cancel.Size = new Size(105, 30);
            _Cancel.TabIndex = 25;
            _Cancel.Text = "Cancel";
            _Cancel.UseVisualStyleBackColor = false;
            // 
            // _SelPathInp
            // 
            _SelPathInp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _SelPathInp.BackColor = Color.LightGray;
            _SelPathInp.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _SelPathInp.Location = new Point(12, 77);
            _SelPathInp.Name = "_SelPathInp";
            _SelPathInp.ReadOnly = true;
            _SelPathInp.Size = new Size(337, 23);
            _SelPathInp.TabIndex = 27;
            _SelPathInp.TextChanged += _2_More_InputPath_TextChanged;
            // 
            // _SelPath
            // 
            _SelPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _SelPath.BackColor = Color.Silver;
            _SelPath.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            _SelPath.Location = new Point(355, 77);
            _SelPath.Name = "_SelPath";
            _SelPath.Size = new Size(78, 23);
            _SelPath.TabIndex = 28;
            _SelPath.Text = "Select Path";
            _SelPath.UseVisualStyleBackColor = false;
            _SelPath.Click += _SelPath_Click;
            // 
            // CreateComp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(445, 161);
            Controls.Add(_SelPath);
            Controls.Add(_SelPathInp);
            Controls.Add(_Cancel);
            Controls.Add(_ok);
            Controls.Add(_TypeDecs);
            Controls.Add(_Lable);
            Controls.Add(_Type);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(260, 200);
            Name = "CreateComp";
            Text = "Create Component";
            Load += CreateComp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox _Type;
        private Label _Lable;
        private Label _TypeDecs;
        private Button _ok;
        private Button _Cancel;
        private TextBox _SelPathInp;
        private Button _SelPath;
    }
}