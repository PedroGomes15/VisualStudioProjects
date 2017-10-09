using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CRUD3camadasFormsSQLServer
{
    class pokemonBLL
    {
        pokemonDAL pkDal = null;

        public DataTable listaPokemonsDAL()
        {
            DataTable dtListaPokemons = new DataTable();
            try
            {
                pkDal = new pokemonDAL();
                dtListaPokemons = pkDal.lista_pokemon();
            }
            catch (Exception error)
            {
                throw error;
            }
            return dtListaPokemons;
        }

        public void gravaPokemonDal(pokemonModel pokemon)
        {
            try
            {
                pkDal = new pokemonDAL();
                pkDal.gravaPokemon(pokemon);
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public void excluiPokemonDal(pokemonModel pokemon)
        {
            try
            {
                pkDal = new pokemonDAL();
                pkDal.excluiPokemon(pokemon);
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public void alterarPokemonDal(pokemonModel pokemon)
        {
            try
            {
                pkDal = new pokemonDAL();
                pkDal.alteraPokemon(pokemon);
            }
            catch (Exception error)
            {
                throw error;
            }
            
        }

        public pokemonModel procuraPokemonsDAL(string pesquisa)
        {
            DataTable dtListaPokemons = new DataTable();
            try
            {
                pkDal = new pokemonDAL();
                return pkDal.procuraPokemon(pesquisa);
            }
            catch (Exception error)
            {
                throw error;
            }
        }
    }
}
