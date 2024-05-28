namespace eAgenda.WinApp.ModuloContato
{
    partial class TelaContatoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaContatoForm));
            lblID = new Label();
            txtID = new TextBox();
            lblNome = new Label();
            txtNome = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblTelefone = new Label();
            txtTelefone = new TextBox();
            lblCargo = new Label();
            txtCargo = new TextBox();
            lblEmpresa = new Label();
            txtEmpresa = new TextBox();
            panelArrastarCadastro = new Panel();
            btnMaximizarDesativado = new Button();
            btnMinimizar = new Button();
            btnSair = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            panelArrastarCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 11F);
            lblID.Location = new Point(50, 123);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 20);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 11F);
            txtID.Location = new Point(84, 120);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 27);
            txtID.TabIndex = 0;
            txtID.TabStop = false;
            txtID.Text = "0";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 11F);
            lblNome.Location = new Point(24, 156);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 11F);
            txtNome.ForeColor = SystemColors.ActiveCaptionText;
            txtNome.Location = new Point(84, 156);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = " Digite seu nome";
            txtNome.Size = new Size(610, 27);
            txtNome.TabIndex = 0;
            txtNome.TabStop = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11F);
            lblEmail.Location = new Point(28, 189);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.ForeColor = SystemColors.ActiveCaptionText;
            txtEmail.Location = new Point(84, 186);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " Ex: funcionario@instituicao.com";
            txtEmail.Size = new Size(610, 27);
            txtEmail.TabIndex = 0;
            txtEmail.TabStop = false;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 11F);
            lblTelefone.Location = new Point(8, 222);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(69, 20);
            lblTelefone.TabIndex = 0;
            lblTelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 11F);
            txtTelefone.ForeColor = SystemColors.ActiveCaptionText;
            txtTelefone.Location = new Point(84, 219);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = " (DDD) 9 xxxx-xxxx";
            txtTelefone.Size = new Size(610, 27);
            txtTelefone.TabIndex = 0;
            txtTelefone.TabStop = false;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Segoe UI", 11F);
            lblCargo.Location = new Point(24, 258);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(52, 20);
            lblCargo.TabIndex = 0;
            lblCargo.Text = "Cargo:";
            // 
            // txtCargo
            // 
            txtCargo.Font = new Font("Segoe UI", 11F);
            txtCargo.ForeColor = SystemColors.ActiveCaptionText;
            txtCargo.Location = new Point(84, 252);
            txtCargo.Name = "txtCargo";
            txtCargo.PlaceholderText = " Digite seu cargo";
            txtCargo.Size = new Size(232, 27);
            txtCargo.TabIndex = 0;
            txtCargo.TabStop = false;
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Font = new Font("Segoe UI", 11F);
            lblEmpresa.Location = new Point(344, 255);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(69, 20);
            lblEmpresa.TabIndex = 0;
            lblEmpresa.Text = "Empresa:";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Font = new Font("Segoe UI", 11F);
            txtEmpresa.ForeColor = SystemColors.ActiveCaptionText;
            txtEmpresa.Location = new Point(419, 252);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.PlaceholderText = " Digite o nome da empresa";
            txtEmpresa.Size = new Size(275, 27);
            txtEmpresa.TabIndex = 0;
            txtEmpresa.TabStop = false;
            // 
            // panelArrastarCadastro
            // 
            panelArrastarCadastro.BackgroundImage = Properties.Resources.CabecalhoCadastro;
            panelArrastarCadastro.BackgroundImageLayout = ImageLayout.Center;
            panelArrastarCadastro.Controls.Add(btnMaximizarDesativado);
            panelArrastarCadastro.Controls.Add(btnMinimizar);
            panelArrastarCadastro.Controls.Add(btnSair);
            panelArrastarCadastro.Location = new Point(-2, -2);
            panelArrastarCadastro.Name = "panelArrastarCadastro";
            panelArrastarCadastro.Size = new Size(717, 65);
            panelArrastarCadastro.TabIndex = 2;
            panelArrastarCadastro.MouseDown += panelArrastarCadastro_MouseDown;
            panelArrastarCadastro.MouseMove += panelArrastarCadastro_MouseMove;
            // 
            // btnMaximizarDesativado
            // 
            btnMaximizarDesativado.AutoSize = true;
            btnMaximizarDesativado.BackColor = Color.FromArgb(222, 222, 222);
            btnMaximizarDesativado.BackgroundImage = Properties.Resources.BotaoNuloRemaster;
            btnMaximizarDesativado.BackgroundImageLayout = ImageLayout.Zoom;
            btnMaximizarDesativado.FlatAppearance.BorderColor = Color.FromArgb(222, 222, 222);
            btnMaximizarDesativado.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 222, 222);
            btnMaximizarDesativado.FlatAppearance.MouseOverBackColor = Color.FromArgb(222, 222, 222);
            btnMaximizarDesativado.FlatStyle = FlatStyle.Flat;
            btnMaximizarDesativado.Location = new Point(63, 2);
            btnMaximizarDesativado.Name = "btnMaximizarDesativado";
            btnMaximizarDesativado.Size = new Size(23, 23);
            btnMaximizarDesativado.TabIndex = 4;
            btnMaximizarDesativado.UseVisualStyleBackColor = false;
            // 
            // btnMinimizar
            // 
            btnMinimizar.AutoSize = true;
            btnMinimizar.BackColor = Color.FromArgb(222, 222, 222);
            btnMinimizar.BackgroundImage = Properties.Resources.MinimizarRemaster;
            btnMinimizar.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinimizar.FlatAppearance.BorderColor = Color.FromArgb(222, 222, 222);
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(222, 222, 222);
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Location = new Point(33, 2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(23, 23);
            btnMinimizar.TabIndex = 6;
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            btnMinimizar.MouseEnter += btnMinimizar_MouseEnter;
            btnMinimizar.MouseLeave += btnMinimizar_MouseLeave;
            // 
            // btnSair
            // 
            btnSair.AutoSize = true;
            btnSair.BackColor = Color.FromArgb(222, 222, 222);
            btnSair.BackgroundImage = Properties.Resources.SairRemaster;
            btnSair.BackgroundImageLayout = ImageLayout.Zoom;
            btnSair.FlatAppearance.BorderColor = Color.FromArgb(222, 222, 222);
            btnSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(222, 222, 222);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Location = new Point(6, 2);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(23, 23);
            btnSair.TabIndex = 5;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            btnSair.MouseEnter += btnSair_MouseEnter;
            btnSair.MouseLeave += btnSair_MouseLeave;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(580, 389);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(114, 48);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(460, 389);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 48);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaContatoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 449);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(panelArrastarCadastro);
            Controls.Add(txtTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(txtEmpresa);
            Controls.Add(lblEmpresa);
            Controls.Add(txtCargo);
            Controls.Add(lblCargo);
            Controls.Add(txtID);
            Controls.Add(lblID);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaContatoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Contato";
            panelArrastarCadastro.ResumeLayout(false);
            panelArrastarCadastro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private TextBox txtID;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblTelefone;
        private TextBox txtTelefone;
        private Label lblCargo;
        private TextBox txtCargo;
        private Label lblEmpresa;
        private TextBox txtEmpresa;
        private Panel panelArrastarCadastro;
        private Button btnMaximizarDesativado;
        private Button btnMinimizar;
        private Button btnSair;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}