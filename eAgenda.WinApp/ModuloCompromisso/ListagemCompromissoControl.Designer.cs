﻿namespace eAgenda.WinApp.ModuloCompromisso
{
    partial class ListagemCompromissoControl
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
            listaCompromissos = new ListBox();
            SuspendLayout();
            // 
            // listaCompromissos
            // 
            listaCompromissos.Dock = DockStyle.Fill;
            listaCompromissos.FormattingEnabled = true;
            listaCompromissos.ItemHeight = 15;
            listaCompromissos.Location = new Point(0, 0);
            listaCompromissos.Name = "listaCompromissos";
            listaCompromissos.Size = new Size(580, 389);
            listaCompromissos.TabIndex = 0;
            // 
            // ListagemCompromissoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listaCompromissos);
            Name = "ListagemCompromissoControl";
            Size = new Size(580, 389);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listaCompromissos;
    }
}
