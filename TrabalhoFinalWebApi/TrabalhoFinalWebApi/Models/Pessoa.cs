using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoFinalWebApi.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public string EstadoCivil { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string NomeFantasia { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
    }
}