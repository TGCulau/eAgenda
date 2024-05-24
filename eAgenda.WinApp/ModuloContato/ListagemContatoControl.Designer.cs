namespace eAgenda.WinApp.ModuloContato
{
    partial class ListagemContatoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listaContatos = new ListBox();
            SuspendLayout();
            // 
            // listaContatos
            // 
            listaContatos.Dock = DockStyle.Fill;
            listaContatos.FormattingEnabled = true;
            listaContatos.ItemHeight = 15;
            listaContatos.Location = new Point(0, 0);
            listaContatos.Name = "listaContatos";
            listaContatos.Size = new Size(535, 286);
            listaContatos.TabIndex = 0;
            listaContatos.SelectedIndexChanged += listContatos_SelectedIndexChanged;
            // 
            // ListagemContatoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listaContatos);
            Name = "ListagemContatoControl";
            Size = new Size(535, 286);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listaContatos;
    }
}
