namespace eAgenda.WinApp.ModuloContato
{
    partial class TelaErro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaErro));
            btnOk = new Button();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.Transparent;
            btnOk.BackgroundImageLayout = ImageLayout.None;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnOk.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Location = new Point(105, 269);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(130, 34);
            btnOk.TabIndex = 0;
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            btnOk.MouseDown += btnOk_MouseDown;
            btnOk.MouseUp += btnOk_MouseLeave;
            // 
            // TelaErro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 227, 228);
            BackgroundImage = Properties.Resources.TelaErro;
            ClientSize = new Size(341, 333);
            Controls.Add(btnOk);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaErro";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
        }

        private void BtnOk_MouseDown(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnOk;
    }
}