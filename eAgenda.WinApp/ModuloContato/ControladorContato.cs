﻿using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloContato
{
    internal class ControladorContato : ControladorBase
    {
        private RepositorioContato repositorioContato;

        private ListagemContatoControl listagemContato;

        public ControladorContato(RepositorioContato repositorio)
        {
            repositorioContato = repositorio;
        }
               
        public override string TipoCadastro { get { return "Contatos"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo contato"; } }

        public override string ToolTipEditar { get { return "Editar um contato existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um contato existente"; } }

        public override void Adicionar()
        {
            TelaContatoForm telaContato = new TelaContatoForm();

            DialogResult resultado = telaContato.ShowDialog();

            if(resultado != DialogResult.OK)
            {
                return;
            }
            Contato novoContato = telaContato.Contato;

            repositorioContato.Cadastrar(novoContato);

            CarregarContatos();
        }

        public override void Editar()
        {
            TelaContatoForm telaContato = new TelaContatoForm();

            Contato contatoSelecionado = listagemContato.ObterRegistroSelecionado();

            telaContato.Contato = contatoSelecionado;

            DialogResult resultado = telaContato.ShowDialog();

            if(resultado != DialogResult.OK)
            {
                return;
            }

            Contato contatoEditado = telaContato.Contato;
            
            repositorioContato.Editar(contatoEditado.Id, contatoEditado);

            CarregarContatos();
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            listagemContato.AtualizarRegistros(contatos);
        }

        public override UserControl ObterListagem()
        {
            if(listagemContato == null)
            {
                listagemContato = new ListagemContatoControl();
            }

            CarregarContatos();

            return listagemContato;
        }

        
    }
}
