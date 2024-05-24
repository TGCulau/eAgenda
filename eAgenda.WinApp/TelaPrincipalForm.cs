using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloCompromisso;
using eAgenda.WinApp.ModuloContato;

namespace eAgenda.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        #region Inicializações
        ControladorBase controlador;
        private bool estaDescendo = false;
        private Point mouseDownLocation;
        private System.Windows.Forms.Timer TimerFormulario = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer TimerFormularioFechamento = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer TimerCadastro = new System.Windows.Forms.Timer();
        #endregion

        #region Construtor
        public TelaPrincipalForm()
        {
            InitializeComponent();
            TimerFormulario.Interval = 5; // Define o intervalo do timer
            TimerFormulario.Tick += new EventHandler(TimerFormulario_Tick); // Adiciona o evento Tick
            TimerFormularioFechamento.Interval = 5; // Define o intervalo do timer
            TimerFormularioFechamento.Tick += new EventHandler(TimerFormularioFechamento_Tick); // Adiciona o evento Tick
            TimerCadastro.Interval = 5;
            TimerCadastro.Tick += TimerCadastro_Tick;
        }
        private void TelaPrincipalForm_Load(object sender, EventArgs e)
        {

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
            TimerFormulario.Start();
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
                TimerFormulario.Stop();
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
        private void btnMostrarMenuCadastro_Click(object sender, EventArgs e)
        {
            estaDescendo = !estaDescendo;
            TimerCadastro.Start();
        }

        //Contatos
        private void btnContatos_Click(object sender, EventArgs e)
        {
            tlsBarraDeEdicao.Show();
            controlador = new ControladorContato();

            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;

            ConfigurarToolTipsContato(controlador);
            ConfigurarListagemContato(controlador);
        }

        //Compromissos
        private void btnCompromissos_Click(object sender, EventArgs e)
        {
            tlsBarraDeEdicao.Show();
            controlador = new ControladorCompromisso();

            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;

            ConfigurarToolTipsCompromisso(controlador);
            ConfigurarListagemCompromisso(controlador);
        }

        /////////////
        //Consultas//
        /////////////
        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        //Compromissos
        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            
        }

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

        #endregion

        #endregion

        #region Adicionar, editar e excluir

        //Adicionar
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }


        #endregion

        #endregion


        #region Metodos

        #region Contato

        //Info ao passar mouse por cima
        private void ConfigurarToolTipsContato(ControladorBase controladorSelecionado)
        {
            btnExcluir.ToolTipText = controlador.ToolTipAdicionar;
            btnExcluir.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
        }
        private void ConfigurarListagemContato(ControladorBase controladorSelecionado)
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

        #endregion








        // private string localizacao = " ";

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // localizacao = rdRemoto.Text;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            // localizacao = radioButton12.Text;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Compromisso tarefa = new Compromisso(txtAssunto.Text, dateTimeData.Text, txtInicio.Text, txtTermino.Text, txtContato.Text, localizacao);
            //txtTeste.Text = tarefa.ToString();
        }


    }
}
