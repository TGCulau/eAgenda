using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloCompromisso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        #region Inicializações
        private Contato contato;
        public Contato Contato 
        { 
            set
            {
                txtID.Text = value.Id.ToString();
                txtNome.PlaceholderText = value.Nome;
                txtEmail.PlaceholderText = value.Email;
                txtTelefone.PlaceholderText = value.Telefone;
                txtCargo.PlaceholderText = value.Cargo;
                txtEmpresa.PlaceholderText = value.Empresa;
            }
            get 
            { 
                return contato; 
            } 
        }

        private Point mouseDownLocation;
        private System.Windows.Forms.Timer TimerFormularioMinimiza = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer TimerFormularioFechamento = new System.Windows.Forms.Timer();
        private bool cadastroCompleto;
        private string backupTextoOriginal;
        #endregion

        #region Construtor
        public TelaContatoForm()
        {
            TelaPrincipalForm telaIncial = new TelaPrincipalForm();
            InitializeComponent();
            TimerFormularioMinimiza.Interval = 5; // Define o intervalo do timer
            TimerFormularioMinimiza.Tick += new EventHandler(TimerFormulario_Tick); // Adiciona o evento Tick
            TimerFormularioFechamento.Interval = 5; // Define o intervalo do timer
            TimerFormularioFechamento.Tick += new EventHandler(TimerFormularioFechamento_Tick); // Adiciona o evento Tick            
            txtID.Text = telaIncial.ObterID();

        }
        #endregion

        #region Desing

        #region Arredondar bordas

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath forma = new GraphicsPath();
            int raio = 20; // Ajuste para o raio desejado
            forma.AddLine(raio, 0, this.Width - raio, 0);
            forma.AddArc(this.Width - raio, 0, raio, raio, 270, 90);
            forma.AddLine(this.Width, raio, this.Width, this.Height - raio);
            forma.AddArc(this.Width - raio, this.Height - raio, raio, raio, 0, 90);
            forma.AddLine(this.Width - raio, this.Height, raio, this.Height);
            forma.AddArc(0, this.Height - raio, raio, raio, 90, 90);
            forma.AddLine(0, this.Height - raio, 0, raio);
            forma.AddArc(0, 0, raio, raio, 180, 90);
            this.Region = new Region(forma);
            base.OnPaint(e);
        }
        #endregion

        #region Mover janela
        private void panelArrastarCadastro_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mouseDownLocation = e.Location;
        }
        private void panelArrastarCadastro_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mouseDownLocation.X;
                this.Top += e.Y - mouseDownLocation.Y;
            }
        }
        #endregion

        #endregion

        #region Botões

        #region Sair e Minimizar

        #region Sair

        private void btnSair_Click(object sender, EventArgs e)
        {
            TimerFormularioFechamento.Start();
        }
        void TimerFormularioFechamento_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                //Reduz a opacidade em 5%
                this.Opacity -= 0.1;
            }
            else
            {
                // Fecha o programa ao chegar a 0 a opacidade
                this.Close();
            }
        }

        #region Animação
        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            //Infla
            btnSair.BackgroundImage = Properties.Resources.SairComXRemaster;
            btnSair.Size = new Size(25, 25);
            btnSair.Location = new Point(5, 1);
        }
        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            //Restaura
            btnSair.BackgroundImage = Properties.Resources.SairRemaster;
            btnSair.Size = new Size(23, 23);
            btnSair.Location = new Point(6, 2);
        }
        #endregion

        #endregion

        #region minimizar

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            TimerFormularioMinimiza.Start();
        }
        void TimerFormulario_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                //Reduz a opacidade em 5%
                this.Opacity -= 0.1;
            }
            else
            {
                // Minimiza a janela quando a opacidade chega a 0
                this.WindowState = FormWindowState.Minimized;
                //Restaura a opacidade para 1
                this.Opacity = 1;
                //Para o timer
                TimerFormularioMinimiza.Stop();
            }
        }

        #region Animação

        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            //Infla
            btnMinimizar.BackgroundImage = Properties.Resources.MinimizarCom_cinzaM;
            btnMinimizar.Size = new Size(25, 25);
            btnMinimizar.Location = new Point(31, 1);
        }
        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            //Restaura
            btnMinimizar.BackgroundImage = Properties.Resources.MinimizarM;
            btnMinimizar.Size = new Size(23, 23);
            btnMinimizar.Location = new Point(33, 2);
        }
        #endregion

        #endregion

        #endregion

        #region Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            TelaSucesso telaSucesso = new TelaSucesso();

            ChecagemDeCadastro();
            if (cadastroCompleto)
            {
                contato = new Contato(txtNome.Text, txtEmail.Text, txtTelefone.Text, txtCargo.Text, txtEmpresa.Text);
                telaSucesso.ShowDialog();
            }
        }

        #endregion

        #endregion

        #region Funções

        public void ChecagemDeCadastro()
        {
            //TemId = false;
            bool TemId = false;
            bool TemNome = false;
            bool TemEmail = false;
            bool TemTelefone = false;
            bool TemCargo = false;
            bool TemEmpresa = false;

            if (txtID.Text != "0" || txtID.ForeColor == SystemColors.WindowText)
            {
                TemId = true;
            }

            if (txtNome.Text != " Digite seu nome" || txtNome.ForeColor == SystemColors.WindowText)
            {
                TemNome = true;
            }

            if (txtEmail.Text != " Ex: funcionario@instituicao.com" || txtEmail.ForeColor == SystemColors.WindowText)
            {
                TemEmail = true;
            }

            if (txtTelefone.Text != " (DDD) 9 xxxx-xxxx" || txtTelefone.ForeColor == SystemColors.WindowText)
            {
                TemTelefone = true;
            }

            if (txtCargo.Text != " Digite seu cargo" || txtCargo.ForeColor == SystemColors.WindowText)
            {
                TemCargo = true;
            }

            if (txtEmpresa.Text != " Digite o nome da empresa" || txtEmpresa.ForeColor == SystemColors.WindowText)
            {
                TemEmpresa = true;
            }

            if (TemId && TemNome && TemEmail && TemTelefone && TemCargo && TemEmpresa)
            {
                cadastroCompleto = true;
            }
            else if (!cadastroCompleto)
            {
                TelaErro telaErro = new TelaErro();
                telaErro.ShowDialog();
            }
        }

        #endregion

    }
}
