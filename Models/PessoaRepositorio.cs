using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class PessoaRepositorio : IPessoaRepositorio
    {
        private List<Pessoa> pessoa = new List<Pessoa>();
        private int _nextId = 1;

        public PessoaRepositorio()
        {
            Add(new Pessoa { Nome = "Luan Eduardo Iago Carvalho",Cpf = 51034904043, Uf = "GO", DataNasc = "01/03/1990"});
            Add(new Pessoa { Nome = "Nelson Fábio Souza", Cpf = 83933603072, Uf = "DF", DataNasc = "05/02/1995" });
            Add(new Pessoa { Nome = "Fábio Elias Ferreira", Cpf = 63471776095, Uf = "MS", DataNasc = "20/10/1989"});
            Add(new Pessoa { Nome = "Cristiane Elaine Rezende", Cpf = 57116330070, Uf = "PR", DataNasc = "08/09/2000" });
        }

        public Pessoa Add(Pessoa item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            pessoa.Add(item);
            return item;
        }

        public Pessoa Get(int id)
        {
            return pessoa.Find(p => p.Id == id);
        }

        public IEnumerable<Pessoa> GetAll()
        {
            return pessoa;
        }

        public void Remove(int id)
        {
            pessoa.RemoveAll(p => p.Id == id);
        }

        public bool Update(Pessoa item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = pessoa.FindIndex(p => p.Id == item.Id);

            if (index == -1)
            {
                return false;
            }
            pessoa.RemoveAt(index);
            pessoa.Add(item);
            return true;
        }
    }
}