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
    public partial class TelaErro : Form
    {
        #region Inicializações
        private Point mouseDownLocation;
        private System.Windows.Forms.Timer TimerFormularioFechamento = new System.Windows.Forms.Timer();
        private bool cadastroCompleto = false;
        #endregion

        #region Construtor
        public TelaErro()
        {
            InitializeComponent();
            TimerFormularioFechamento.Interval = 5; // Define o intervalo do timer
            TimerFormularioFechamento.Tick += new EventHandler(TimerFormularioFechamento_Tick); // Adiciona o evento Tick
        }
        #endregion

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

        #region Botão OK

        private void btnOk_Click(object sender, EventArgs e)
        {
            TimerFormularioFechamento.Start();
        }

        #region Animações

        //Animação pra fechar
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
        //Animação na troca de botão
        private void btnOk_MouseDown(object sender, EventArgs e)
        {
            btnOk.BackgroundImage = Properties.Resources.OkApertado;
        }
        private void btnOk_MouseLeave(object sender, MouseEventArgs e)
        {
            btnOk.BackgroundImage = null;
        }
        #endregion

        #endregion
    }
}
