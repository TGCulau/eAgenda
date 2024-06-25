using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloCompromisso;
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
        }

        public void AtualizarRegistros(List<Contato> contatos)
        {
            listaContatos.Items.Clear();

            foreach (Contato contato in contatos)
                listaContatos.Items.Add(contato);
        }

        public Contato ObterRegistroSelecionado()
        {
            if(listaContatos.SelectedItem == null)
            {
                return null;
            }

            return (Contato)listaContatos.SelectedItem;
        }
    }
}
