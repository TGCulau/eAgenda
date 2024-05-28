namespace eAgenda.WinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            statusStrip1 = new StatusStrip();
            statusLabelPrincipal = new ToolStripStatusLabel();
            tlsBarraDeEdicao = new ToolStrip();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            btnAdicionar = new ToolStripButton();
            pnlRegistros = new Panel();
            panel1 = new Panel();
            pnlConsultas = new Panel();
            lblCompromisso = new Label();
            lblCadastros = new Label();
            pictureBox2 = new PictureBox();
            btnCompromissos = new Button();
            pictureBox1 = new PictureBox();
            btnContatos = new Button();
            btnMostrarMenuCadastro = new Button();
            btnMaximizarDesativado = new Button();
            btnMinimizar = new Button();
            btnSair = new Button();
            panelArrastar = new Panel();
            lblTipoCadastro = new Label();
            btnMostrarMenuCompromisso = new Button();
            statusStrip1.SuspendLayout();
            tlsBarraDeEdicao.SuspendLayout();
            panel1.SuspendLayout();
            pnlConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelArrastar.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(243, 243, 243);
            statusStrip1.Font = new Font("Segoe UI", 11F);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabelPrincipal });
            statusStrip1.Location = new Point(0, 741);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(320, 25);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelPrincipal
            // 
            statusLabelPrincipal.Name = "statusLabelPrincipal";
            statusLabelPrincipal.Size = new Size(166, 20);
            statusLabelPrincipal.Text = "Visualizando 0 registros";
            // 
            // tlsBarraDeEdicao
            // 
            tlsBarraDeEdicao.BackColor = Color.Transparent;
            tlsBarraDeEdicao.Dock = DockStyle.None;
            tlsBarraDeEdicao.GripStyle = ToolStripGripStyle.Hidden;
            tlsBarraDeEdicao.Items.AddRange(new ToolStripItem[] { btnEditar, btnExcluir, btnAdicionar });
            tlsBarraDeEdicao.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            tlsBarraDeEdicao.Location = new Point(1169, 18);
            tlsBarraDeEdicao.Name = "tlsBarraDeEdicao";
            tlsBarraDeEdicao.Padding = new Padding(0);
            tlsBarraDeEdicao.RenderMode = ToolStripRenderMode.System;
            tlsBarraDeEdicao.Size = new Size(78, 39);
            tlsBarraDeEdicao.TabIndex = 2;
            tlsBarraDeEdicao.Visible = false;
            // 
            // btnEditar
            // 
            btnEditar.BackgroundImage = Properties.Resources.Edicao2;
            btnEditar.BackgroundImageLayout = ImageLayout.Center;
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Margin = new Padding(0, 1, 0, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(0, 3, 5, 5);
            btnEditar.Size = new Size(23, 33);
            btnEditar.Text = "toolStripButton2";
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = Properties.Resources.LixeiraPequena;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(5);
            btnExcluir.Size = new Size(30, 36);
            btnExcluir.Text = "toolStripButton3";
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackgroundImageLayout = ImageLayout.Center;
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Image = Properties.Resources._;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(23, 36);
            btnAdicionar.Text = "toolStripButton1";
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // pnlRegistros
            // 
            pnlRegistros.BackColor = Color.WhiteSmoke;
            pnlRegistros.Location = new Point(324, 79);
            pnlRegistros.Name = "pnlRegistros";
            pnlRegistros.Size = new Size(934, 744);
            pnlRegistros.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(226, 227, 227);
            panel1.Controls.Add(pnlConsultas);
            panel1.Controls.Add(lblCadastros);
            panel1.Controls.Add(statusStrip1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnCompromissos);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnContatos);
            panel1.Controls.Add(btnMostrarMenuCadastro);
            panel1.Location = new Point(-2, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 766);
            panel1.TabIndex = 4;
            // 
            // pnlConsultas
            // 
            pnlConsultas.Controls.Add(lblCompromisso);
            pnlConsultas.Controls.Add(btnMostrarMenuCompromisso);
            pnlConsultas.Location = new Point(0, 78);
            pnlConsultas.Name = "pnlConsultas";
            pnlConsultas.Size = new Size(320, 253);
            pnlConsultas.TabIndex = 10;
            // 
            // lblCompromisso
            // 
            lblCompromisso.AutoSize = true;
            lblCompromisso.Font = new Font("Myanmar Text", 15F, FontStyle.Bold);
            lblCompromisso.ForeColor = Color.FromArgb(91, 91, 93);
            lblCompromisso.Location = new Point(23, 10);
            lblCompromisso.Name = "lblCompromisso";
            lblCompromisso.Size = new Size(106, 36);
            lblCompromisso.TabIndex = 8;
            lblCompromisso.Text = "Consultas";
            // 
            // lblCadastros
            // 
            lblCadastros.AutoSize = true;
            lblCadastros.Font = new Font("Myanmar Text", 15F, FontStyle.Bold);
            lblCadastros.ForeColor = Color.FromArgb(91, 91, 93);
            lblCadastros.Location = new Point(23, 49);
            lblCadastros.Name = "lblCadastros";
            lblCadastros.Size = new Size(107, 36);
            lblCadastros.TabIndex = 8;
            lblCadastros.Text = "Cadastros";
            lblCadastros.Click += btnMostrarMenuCadastro_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.ListaM;
            pictureBox2.ImageLocation = "";
            pictureBox2.Location = new Point(18, 133);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(17, 17);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // btnCompromissos
            // 
            btnCompromissos.BackColor = Color.FromArgb(226, 227, 227);
            btnCompromissos.FlatAppearance.BorderColor = Color.Red;
            btnCompromissos.FlatAppearance.BorderSize = 0;
            btnCompromissos.FlatAppearance.MouseOverBackColor = Color.FromArgb(202, 202, 202);
            btnCompromissos.FlatStyle = FlatStyle.Flat;
            btnCompromissos.Font = new Font("Myanmar Text", 10F);
            btnCompromissos.Location = new Point(0, 127);
            btnCompromissos.Name = "btnCompromissos";
            btnCompromissos.Size = new Size(320, 29);
            btnCompromissos.TabIndex = 11;
            btnCompromissos.Text = "        Compromissos";
            btnCompromissos.TextAlign = ContentAlignment.MiddleLeft;
            btnCompromissos.UseVisualStyleBackColor = false;
            btnCompromissos.Click += btnCompromissos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Contatos;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(18, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(17, 17);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnContatos
            // 
            btnContatos.BackColor = Color.FromArgb(226, 227, 227);
            btnContatos.FlatAppearance.BorderColor = Color.Red;
            btnContatos.FlatAppearance.BorderSize = 0;
            btnContatos.FlatAppearance.MouseOverBackColor = Color.FromArgb(202, 202, 202);
            btnContatos.FlatStyle = FlatStyle.Flat;
            btnContatos.Font = new Font("Myanmar Text", 10F);
            btnContatos.Location = new Point(0, 92);
            btnContatos.Name = "btnContatos";
            btnContatos.Size = new Size(320, 29);
            btnContatos.TabIndex = 11;
            btnContatos.Text = "        Contatos";
            btnContatos.TextAlign = ContentAlignment.MiddleLeft;
            btnContatos.UseVisualStyleBackColor = false;
            btnContatos.Click += btnContatos_Click;
            // 
            // btnMostrarMenuCadastro
            // 
            btnMostrarMenuCadastro.BackColor = Color.Transparent;
            btnMostrarMenuCadastro.BackgroundImageLayout = ImageLayout.None;
            btnMostrarMenuCadastro.FlatAppearance.BorderColor = Color.FromArgb(226, 227, 227);
            btnMostrarMenuCadastro.FlatAppearance.BorderSize = 0;
            btnMostrarMenuCadastro.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 227, 227);
            btnMostrarMenuCadastro.FlatAppearance.MouseOverBackColor = Color.FromArgb(226, 227, 227);
            btnMostrarMenuCadastro.FlatStyle = FlatStyle.Flat;
            btnMostrarMenuCadastro.Image = Properties.Resources.MenuParaBaixoCinza2;
            btnMostrarMenuCadastro.ImageAlign = ContentAlignment.MiddleRight;
            btnMostrarMenuCadastro.Location = new Point(23, 49);
            btnMostrarMenuCadastro.Name = "btnMostrarMenuCadastro";
            btnMostrarMenuCadastro.Size = new Size(276, 23);
            btnMostrarMenuCadastro.TabIndex = 9;
            btnMostrarMenuCadastro.UseVisualStyleBackColor = false;
            btnMostrarMenuCadastro.Click += btnMostrarMenuCadastro_Click;
            // 
            // btnMaximizarDesativado
            // 
            btnMaximizarDesativado.AutoSize = true;
            btnMaximizarDesativado.BackColor = Color.FromArgb(226, 227, 227);
            btnMaximizarDesativado.BackgroundImage = Properties.Resources.BotaoNuloRemaster;
            btnMaximizarDesativado.BackgroundImageLayout = ImageLayout.Zoom;
            btnMaximizarDesativado.FlatAppearance.BorderColor = Color.FromArgb(226, 227, 227);
            btnMaximizarDesativado.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 227, 227);
            btnMaximizarDesativado.FlatAppearance.MouseOverBackColor = Color.FromArgb(226, 227, 227);
            btnMaximizarDesativado.FlatStyle = FlatStyle.Flat;
            btnMaximizarDesativado.Location = new Point(63, 2);
            btnMaximizarDesativado.Name = "btnMaximizarDesativado";
            btnMaximizarDesativado.Size = new Size(23, 23);
            btnMaximizarDesativado.TabIndex = 3;
            btnMaximizarDesativado.UseVisualStyleBackColor = false;
            // 
            // btnMinimizar
            // 
            btnMinimizar.AutoSize = true;
            btnMinimizar.BackColor = Color.FromArgb(226, 227, 227);
            btnMinimizar.BackgroundImage = Properties.Resources.MinimizarRemaster;
            btnMinimizar.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinimizar.FlatAppearance.BorderColor = Color.FromArgb(226, 227, 227);
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(226, 227, 227);
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Location = new Point(33, 2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(23, 23);
            btnMinimizar.TabIndex = 3;
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            btnMinimizar.MouseEnter += btnMinimizar_MouseEnter;
            btnMinimizar.MouseLeave += btnMinimizar_MouseLeave;
            // 
            // btnSair
            // 
            btnSair.AutoSize = true;
            btnSair.BackColor = Color.FromArgb(226, 227, 227);
            btnSair.BackgroundImage = Properties.Resources.SairRemaster;
            btnSair.BackgroundImageLayout = ImageLayout.Zoom;
            btnSair.FlatAppearance.BorderColor = Color.FromArgb(226, 227, 227);
            btnSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(226, 227, 227);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Location = new Point(6, 2);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(23, 23);
            btnSair.TabIndex = 3;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            btnSair.MouseEnter += btnSair_MouseEnter;
            btnSair.MouseLeave += btnSair_MouseLeave;
            // 
            // panelArrastar
            // 
            panelArrastar.BackColor = Color.FromArgb(226, 227, 227);
            panelArrastar.BackgroundImage = Properties.Resources.CabeçalhoApplePronto;
            panelArrastar.BackgroundImageLayout = ImageLayout.Center;
            panelArrastar.Controls.Add(tlsBarraDeEdicao);
            panelArrastar.Controls.Add(lblTipoCadastro);
            panelArrastar.Controls.Add(btnMaximizarDesativado);
            panelArrastar.Controls.Add(btnSair);
            panelArrastar.Controls.Add(btnMinimizar);
            panelArrastar.Location = new Point(-2, 0);
            panelArrastar.Name = "panelArrastar";
            panelArrastar.Size = new Size(1272, 79);
            panelArrastar.TabIndex = 5;
            panelArrastar.MouseDown += panelArrastar_MouseDown;
            panelArrastar.MouseMove += panelArrastar_MouseMove;
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTipoCadastro.BackColor = Color.Transparent;
            lblTipoCadastro.Font = new Font("Myanmar Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoCadastro.ForeColor = Color.FromArgb(91, 91, 93);
            lblTipoCadastro.Location = new Point(0, 45);
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(1272, 44);
            lblTipoCadastro.TabIndex = 4;
            lblTipoCadastro.Text = "Bem-Vindo(a)";
            lblTipoCadastro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMostrarMenuCompromisso
            // 
            btnMostrarMenuCompromisso.BackColor = Color.Transparent;
            btnMostrarMenuCompromisso.BackgroundImageLayout = ImageLayout.None;
            btnMostrarMenuCompromisso.FlatAppearance.BorderColor = Color.FromArgb(226, 227, 227);
            btnMostrarMenuCompromisso.FlatAppearance.BorderSize = 0;
            btnMostrarMenuCompromisso.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 227, 227);
            btnMostrarMenuCompromisso.FlatAppearance.MouseOverBackColor = Color.FromArgb(226, 227, 227);
            btnMostrarMenuCompromisso.FlatStyle = FlatStyle.Flat;
            btnMostrarMenuCompromisso.Image = Properties.Resources.MenuParaBaixoCinza2;
            btnMostrarMenuCompromisso.ImageAlign = ContentAlignment.MiddleRight;
            btnMostrarMenuCompromisso.Location = new Point(23, 13);
            btnMostrarMenuCompromisso.Name = "btnMostrarMenuCompromisso";
            btnMostrarMenuCompromisso.Size = new Size(276, 23);
            btnMostrarMenuCompromisso.TabIndex = 9;
            btnMostrarMenuCompromisso.UseVisualStyleBackColor = false;
            btnMostrarMenuCompromisso.Click += btnMostrarMenuCadastro_Click;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1270, 844);
            Controls.Add(panelArrastar);
            Controls.Add(panel1);
            Controls.Add(pnlRegistros);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "eAgenda";
            Load += TelaPrincipalForm_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tlsBarraDeEdicao.ResumeLayout(false);
            tlsBarraDeEdicao.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlConsultas.ResumeLayout(false);
            pnlConsultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelArrastar.ResumeLayout(false);
            panelArrastar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabelPrincipal;
        private ToolStrip tlsBarraDeEdicao;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private Panel pnlRegistros;
        private Panel panel1;
        private Button btnSair;
        private Button btnMaximizarDesativado;
        private Button btnMinimizar;
        private Panel panelArrastar;
        private ToolStripButton btnAdicionar;
        private Label lblTipoCadastro;
        private Label lblCadastros;
        private Button btnMostrarMenuCadastro;
        private Panel pnlConsultas;
        private Label lblCompromisso;
        private Button btnContatos;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnCompromissos;
        private Button btnMostrarMenuCompromisso;
    }
}
