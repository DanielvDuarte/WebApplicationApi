using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Cpf { get; set; }
        public string Uf { get; set; }
        public string DataNasc { get; set; }
    }
}