using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloContato
{
    public partial class ListagemContatoControl : UserControl
    {
        public ListagemContatoControl()
        {
            InitializeComponent();

            listaContatos.Items.Add(new Contato("Culau", "49 99147-3740", "tgculau@gmail.com", "Academia do Arogramador", "Aluno"));

        }

        private void listContatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
