using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace eAgenda.WinApp.ModuloContato
{
    public class Contato : EntidadeBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cargo { get; set; }
        public string Empresa { get; set; }
     

        public Contato(string nome, string email, string telefone, string cargo, string empresa)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Cargo = cargo;
            Empresa = empresa;            
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"Nome\" é obrigatório");

            if (string.IsNullOrEmpty(Telefone.Trim()))
                erros.Add("O campo \"Telefone\" é obrigatório");

            if (string.IsNullOrEmpty(Email.Trim()))
                erros.Add("O campo \"Email\" é obrigatório");

            if (string.IsNullOrEmpty(Cargo.Trim()))
                erros.Add("O campo \"cargo\" é obrigatório");

            if (string.IsNullOrEmpty(Empresa.Trim()))
                erros.Add("O campo \"empresa\" é obrigatório");

            return erros;
        }
              
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Contato atualizado = (Contato)novoRegistro;

            Nome = atualizado.Nome;
            Email = atualizado.Email;
            Telefone = atualizado.Telefone;
            Cargo = atualizado.Cargo;
            Empresa = atualizado.Empresa;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Email: {Email}, Telefone: {Telefone}, Empresa: {Empresa}, Cargo: {Cargo}\n";
        }
    }
}
