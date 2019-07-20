using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTest1.Models
{
    public class Conhecimento
    {
        public string Nome { get; set; }
        public int Id { get; set; }

        public Conhecimento()
        {
        }

        public Conhecimento(string nome, int id)
        {
            Nome = nome;
            Id = id;
        }
    }
}
