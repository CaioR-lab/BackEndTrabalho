using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class ProdutoRepository
    {
        public void Create(Produto model)
        {
            using (var context = new ProdutoContext())
            {
                context.Set<Produto>().Add(model);
                context.SaveChanges();
            }
        }

        public Produto Read(int Id)
        {
            Produto model = new Produto();
            using (var context = new ProdutoContext())
            {
                model = context.Set<Produto>().Find(Id);            
            }
            return model;
        }

        public List<Produto> Read()
        {
            List<Produto> lista = new List<Produto>();
            using (var context = new ProdutoContext())
            {
                lista = context.Set<Produto>().ToList();
            }
            return lista;
        }

        public void Update(Produto model)
        {
            using (var context = new ProdutoContext())
            {
                context.Entry(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (var context = new ProdutoContext())
            {
                context.Entry(Read(Id)).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
