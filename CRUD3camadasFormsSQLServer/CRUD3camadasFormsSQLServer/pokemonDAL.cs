using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CRUD3camadasFormsSQLServer
{
    class pokemonDAL
    {
        string conexaoSqlServer = @"Data Source=.\SQLEXPRESS;Initial Catalog=Pokemon;User id=sa;pwd=sa@adm1";
        SqlConnection conexao = null;

        public DataTable lista_pokemon()
        {
            try
            {
                conexao = new SqlConnection(conexaoSqlServer);
                SqlCommand sql = new SqlCommand("select * from pokemons", conexao);
                SqlDataAdapter daPokemon = new SqlDataAdapter();
                daPokemon.SelectCommand = sql;
                DataTable dtPokemon = new DataTable();
                daPokemon.Fill(dtPokemon);
                return dtPokemon;
            }
            catch(Exception error)
            {
                throw error;
            }
            finally
            {
                conexao.Close();
            }
        }

        public void gravaPokemon(pokemonModel pokemon)
        {
            try
            { 
                conexao = new SqlConnection(conexaoSqlServer);
                SqlCommand sql = new SqlCommand("insert into pokemons values(@codigo,@nome,@pokedex)", conexao);
                sql.Parameters.AddWithValue("@codigo",pokemon.Codigo);
                sql.Parameters.AddWithValue("@nome", pokemon.Nome);
                sql.Parameters.AddWithValue("@pokedex", pokemon.Pokedex);
                conexao.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                conexao.Close();
            }

        }

        public void excluiPokemon(pokemonModel pokemon)
        {
            try
            {
                conexao = new SqlConnection(conexaoSqlServer);
                SqlCommand sql = new SqlCommand("delete from pokemons where pok_codigo = @codigo", conexao);
                sql.Parameters.AddWithValue("@codigo", pokemon.Codigo);
                conexao.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                conexao.Close();
            }

        }

        public void alteraPokemon(pokemonModel pokemon)
        {
            try
            {
                conexao = new SqlConnection(conexaoSqlServer);
                SqlCommand sql = new SqlCommand("update pokemons set pok_nome = @nome,pok_numPokedex = @pokedex where pok_codigo = @codigo", conexao);
                sql.Parameters.AddWithValue("@codigo", pokemon.Codigo);
                sql.Parameters.AddWithValue("@nome", pokemon.Nome);
                sql.Parameters.AddWithValue("@pokedex", pokemon.Pokedex);
                conexao.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                conexao.Close();
            }

        }

        public pokemonModel procuraPokemon(string pesquisa)
        {
            try
            {
                conexao = new SqlConnection(conexaoSqlServer);
                SqlCommand sql = new SqlCommand("select * from pokemons where pok_nome like '" + @pesquisa+"%'", conexao);
                //sql.Parameters.AddWithValue("@pesquisa", pesquisa);
                conexao.Open();
                SqlDataReader datareader;
                pokemonModel objPokemon = new pokemonModel();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);
                while(datareader.Read())
                {
                    objPokemon.Codigo = Convert.ToInt32(datareader["pok_codigo"]);
                    objPokemon.Pokedex = Convert.ToInt32(datareader["pok_numPokedex"]);
                    objPokemon.Nome = datareader["pok_nome"].ToString();
                }
                return objPokemon;
            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
