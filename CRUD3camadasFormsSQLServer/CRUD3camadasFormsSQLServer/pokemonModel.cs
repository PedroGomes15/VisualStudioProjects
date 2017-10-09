using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD3camadasFormsSQLServer
{
    class pokemonModel
    {
        int codigo;
        string nome;
        int pokedex;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Pokedex
        {
            get { return pokedex; }
            set { pokedex = value; }
        }
    }
}
