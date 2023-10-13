namespace TMC
{
    partial class RenameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenameForm));
            Rename_Inoput = new TextBox();
            Rename_Cancel = new Button();
            Rename_ok = new Button();
            Rename_Lable = new Label();
            SuspendLayout();
            // 
            // Rename_Inoput
            // 
            Rename_Inoput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Rename_Inoput.BackColor = Color.Silver;
            Rename_Inoput.Location = new Point(12, 44);
            Rename_Inoput.Name = "Rename_Inoput";
            Rename_Inoput.Size = new Size(260, 23);
            Rename_Inoput.TabIndex = 0;
            Rename_Inoput.TextChanged += Rename_Inoput_TextChanged;
            // 
            // Rename_Cancel
            // 
            Rename_Cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Rename_Cancel.BackColor = Color.Silver;
            Rename_Cancel.DialogResult = DialogResult.Cancel;
            Rename_Cancel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Rename_Cancel.Location = new Point(12, 73);
            Rename_Cancel.Name = "Rename_Cancel";
            Rename_Cancel.Size = new Size(102, 30);
            Rename_Cancel.TabIndex = 34;
            Rename_Cancel.Text = "Cancel";
            Rename_Cancel.UseVisualStyleBackColor = false;
            // 
            // Rename_ok
            // 
            Rename_ok.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Rename_ok.BackColor = Color.Silver;
            Rename_ok.DialogResult = DialogResult.OK;
            Rename_ok.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Rename_ok.Location = new Point(170, 73);
            Rename_ok.Name = "Rename_ok";
            Rename_ok.Size = new Size(102, 30);
            Rename_ok.TabIndex = 35;
            Rename_ok.Text = "Confirm";
            Rename_ok.UseVisualStyleBackColor = false;
            // 
            // Rename_Lable
            // 
            Rename_Lable.Anchor = AnchorStyles.Left;
            Rename_Lable.AutoSize = true;
            Rename_Lable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Rename_Lable.Location = new Point(12, 20);
            Rename_Lable.Name = "Rename_Lable";
            Rename_Lable.Size = new Size(55, 21);
            Rename_Lable.TabIndex = 36;
            Rename_Lable.Text = "Name:";
            // 
            // RenameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(284, 111);
            Controls.Add(Rename_Lable);
            Controls.Add(Rename_ok);
            Controls.Add(Rename_Cancel);
            Controls.Add(Rename_Inoput);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(300, 150);
            Name = "RenameForm";
            Text = "Rename";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Rename_Inoput;
        private Button Rename_Cancel;
        private Button Rename_ok;
        private Label Rename_Lable;
    }
}