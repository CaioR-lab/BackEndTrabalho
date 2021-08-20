using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class ProdutoContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public ProdutoContext() : base ("Data Source=192.168.0.127;Initial Catalog=Produtos;Persist Security Info=True;User ID=produtos;Password=123321@")
        {

        }
    }
}
