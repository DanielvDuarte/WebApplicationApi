using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Models
{

    public interface IPessoaRepositorio
    {
        IEnumerable<Pessoa> GetAll();
        Pessoa Get(int id);
        Pessoa Add(Pessoa item);
        void Remove(int id);
        bool Update(Pessoa item);
    }
}
