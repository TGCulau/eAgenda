using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloCompromisso
{
    internal class ControladorCompromisso : ControladorBase
    {
        public override string TipoCadastro { get { return "Compromissos"; } }


        public override string ToolTipAdicionar { get { return "Cadastrar um novo Compromisso"; } }

        public override string ToolTipEditar { get { return "Editar um Compromisso existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um Compromisso existente"; } }

        public override void Adicionar()
        {
            TelaContatoForm telaContato = new TelaContatoForm();
            telaContato.ShowDialog();
        }

        public override UserControl ObterListagem()
        {
            return new ListagemContatoControl();
        }
    }
}
