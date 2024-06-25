using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloCompromisso;
using eAgenda.WinApp.ModuloContato;
using System.Drawing.Drawing2D;

namespace eAgenda.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        #region Inicializações
        private int contIDTexto;
        ControladorBase controlador;
        RepositorioContato repositorioContato;
        RepositorioCompromisso repositorioCompromisso;
        private bool estaDescendo = false;
        private Point mouseDownLocation;
        private System.Windows.Forms.Timer TimerFormularioMinimiza = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer TimerFormularioFechamento = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer TimerCadastro = new System.Windows.Forms.Timer();
        #endregion

        #region Construtor
        public TelaPrincipalForm()
        {
            InitializeComponent();
            repositorioContato = new RepositorioContato();
            repositorioCompromisso = new RepositorioCompromisso();
            TimerFormularioMinimiza.Interval = 5; // Define o intervalo do timer
            TimerFormularioMinimiza.Tick += new EventHandler(TimerFormulario_Tick); // Adiciona o evento Tick
            TimerFormularioFechamento.Interval = 5; // Define o intervalo do timer
            TimerFormularioFechamento.Tick += new EventHandler(TimerFormularioFechamento_Tick); // Adiciona o evento Tick
            TimerCadastro.Interval = 5;
            TimerCadastro.Tick += TimerCadastro_Tick;
        }
        private void TelaPrincipalForm_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Design

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
        private void panelArrastar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mouseDownLocation = e.Location;
        }
        private void panelArrastar_MouseMove(object sender, MouseEventArgs e)
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

        #region Menu Cadastros
        ////////////
        //Cadastro//
        ////////////

        //Contatos
        private void btnContatos_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato(repositorioContato);

            tlsBarraDeEdicao.Show();

            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;

            ConfigurarToolTips(controlador);
            ConfigurarListagem(controlador);
        }

        //Compromissos
        private void btnCompromissos_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCompromisso(repositorioCompromisso);
            tlsBarraDeEdicao.Show();

            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;

            ConfigurarToolTipsCompromisso(controlador);
            ConfigurarListagemCompromisso(controlador);
        }

        /////////////
        //Consultas//
        /////////////

        //Compromissos


        #region Animações
        //Cadastro
        private void TimerCadastro_Tick(object sender, EventArgs e)
        {
            if (estaDescendo)
            {

                pnlConsultas.Top += 10;
                if (pnlConsultas.Top >= 162)
                {
                    TimerCadastro.Stop();
                }
            }
            else
            {
                pnlConsultas.Top -= 10;
                if (pnlConsultas.Top <= 78)
                {
                    tlsBarraDeEdicao.Hide();
                    TimerCadastro.Stop();
                }
            }
        }
        private void btnMostrarMenuCadastro_Click(object sender, EventArgs e)
        {
            estaDescendo = !estaDescendo;
            TimerCadastro.Start();
        }

        #endregion

        #endregion

        #region Adicionar, editar e excluir

        //Adicionar
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }

        //Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        #endregion

        #endregion

        #region Funções

        #region Contato

        //Info ao passar mouse por cima
        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controlador.ToolTipAdicionar;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
        }
        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemContato = controlador.ObterListagem();
            listagemContato.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemContato);

        }
        #endregion

        #region Compromisso

        //Info ao passar mouse por cima
        private void ConfigurarToolTipsCompromisso(ControladorBase controladorSelecionado)
        {
            btnExcluir.ToolTipText = controlador.ToolTipAdicionar;
            btnExcluir.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
        }
        private void ConfigurarListagemCompromisso(ControladorBase controladorSelecionado)
        {
            UserControl listagemCompromisso = controlador.ObterListagem();
            listagemCompromisso.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemCompromisso);
        }

        #endregion

        #region ObterID

        public string ObterID()
        {
            contIDTexto++;
            string idtexto = Convert.ToString(contIDTexto);
            return idtexto;
        }

#endregion

        #endregion
    }
}
