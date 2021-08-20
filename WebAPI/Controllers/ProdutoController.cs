using Data.Models;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        ProdutoRepository repository = new ProdutoRepository();

        [HttpGet("{id}")]
        public Produto Get(int Id)
        {
            return repository.Read(Id);
        }

        [HttpGet]
        public List<Produto> Get()
        {
            return repository.Read();
        }

        [HttpPost]
        public void Post([FromBody] Produto model)
        {
            repository.Create(model);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Produto model)
        {
            repository.Update(model);
        }

        [HttpDelete("{id}")]
        public void Delete(int Id)
        {
            repository.Delete(Id);
        }
    }
}
