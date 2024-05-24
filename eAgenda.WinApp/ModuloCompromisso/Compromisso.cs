using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class Compromisso : EntidadeBase
    {
        public string Assunto { get; set; }
        public string Data { get; set; }
        public string Inicio { get; set; }
        public string Termino { get; set; }
        public string Contato { get; set; }
        public string Localizacao { get; set; }

        public Compromisso(string assunto, string data, string inicio, string termino, string contato, string localizacao)
        {
            Assunto = assunto;
            Data = data;
            Inicio = inicio;
            Termino = termino;
            Contato = contato;
            Localizacao = localizacao;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Assunto.Trim()))
                erros.Add("O campo \"Assunto\" é obrigatório");

            if (string.IsNullOrEmpty(Data.Trim()))
                erros.Add("O campo \"Data\" é obrigatório");

            if (string.IsNullOrEmpty(Inicio.Trim()))
                erros.Add("O campo \"Inicio\" é obrigatório");

            if (string.IsNullOrEmpty(Termino.Trim()))
                erros.Add("O campo \"Termino\" é obrigatório");

            if (string.IsNullOrEmpty(Contato.Trim()))
                erros.Add("O campo \"Contato\" é obrigatório");

            if (string.IsNullOrEmpty(Localizacao.Trim()))
                erros.Add("O campo \"Localizacao\" é obrigatório");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Compromisso atualizado = (Compromisso)novoRegistro;

            Assunto = atualizado.Assunto;
            Data = atualizado.Data;
            Inicio = atualizado.Inicio;
            Termino = atualizado.Termino;
            Contato = atualizado.Contato;
            Localizacao = atualizado.Localizacao;
        }

        public override string ToString()
        {
            return $"Id: 0, Assunto: {Assunto}, Data: {Data}, Inicio: {Inicio}, Termino: {Termino}, Contato: {Contato}, Localizacao: {Localizacao}\n";
        }
    }
}
