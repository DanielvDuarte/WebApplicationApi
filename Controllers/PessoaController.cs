using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.Models;


namespace WebApplication.Controllers
{
    public class PessoaController : ApiController
    {
        static readonly IPessoaRepositorio repositorio = new PessoaRepositorio();
        public IEnumerable<Pessoa> GetAllPessoa()
        {
            return repositorio.GetAll();
        }
        public Pessoa GetPessoa(int id)
        {
            Pessoa item = repositorio.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }
        public IEnumerable<Pessoa> GetPessoaPorUf(string Uf)
        {
            return repositorio.GetAll().Where(
                p => string.Equals(p.Uf, Uf, StringComparison.OrdinalIgnoreCase));
        }
        public HttpResponseMessage PostPessoa(Pessoa item)
        {
            item = repositorio.Add(item);
            var response = Request.CreateResponse<Pessoa>(HttpStatusCode.Created, item);
            string uri = Url.Link("DefaultApi", new { id = item.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }
        public void PutPessoa(int id, Pessoa pessoa)
        {
            pessoa.Id = id;
            if (!repositorio.Update(pessoa))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }
        public void DeletePessoa(int id)
        {
            Pessoa item = repositorio.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            repositorio.Remove(id);
        }
    }
}
