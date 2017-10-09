using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD3camadasFormsSQLServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshDBGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshDBGrid();
        }

        private void refreshDBGrid()
        {
            try
            {
                pokemonBLL pkBLL = new pokemonBLL();
                grade_pokemons.DataSource = pkBLL.listaPokemonsDAL();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro na listagem de pokemons: " + error);
            }
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            pokemonModel obj_pokemon = new pokemonModel();
            obj_pokemon.Codigo = Convert.ToInt32(tbCodigo.Text);
            obj_pokemon.Pokedex = Convert.ToInt32(tbPokedex.Text);
            obj_pokemon.Nome = tbNome.Text;

            try
            {
                pokemonBLL pkBLL = new pokemonBLL();
                pkBLL.gravaPokemonDal(obj_pokemon);
                MessageBox.Show("Gravado com sucesso");
                refreshDBGrid();
            }
            catch (Exception error)
            { 

                MessageBox.Show("Erro ao gravar: " + error);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            pokemonModel obj_pokemon = new pokemonModel();
            obj_pokemon.Codigo = Convert.ToInt32(tbCodigo.Text);

            try
            {
                pokemonBLL pkBLL = new pokemonBLL();
                pkBLL.excluiPokemonDal(obj_pokemon);
                MessageBox.Show("Excluido com sucesso");
                refreshDBGrid();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao excluir: " + error);
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            pokemonModel obj_pokemon = new pokemonModel();
            obj_pokemon.Codigo = Convert.ToInt32(tbCodigo.Text);
            obj_pokemon.Pokedex = Convert.ToInt32(tbPokedex.Text);
            obj_pokemon.Nome = tbNome.Text;

            try
            {
                pokemonBLL pkBLL = new pokemonBLL();
                pkBLL.alterarPokemonDal(obj_pokemon);
                MessageBox.Show("Atualizado com sucesso");
                refreshDBGrid();
            }
            catch (Exception error)
            {

                MessageBox.Show("Erro ao atualizar: " + error);
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = tbPesquisa.Text;

            pokemonModel obj_pokemon = new pokemonModel();

            try
            {
                pokemonBLL pkBLL = new pokemonBLL();
                obj_pokemon = pkBLL.procuraPokemonsDAL(pesquisa);
                tbCodigo.Text = obj_pokemon.Codigo.ToString();
                tbNome.Text = obj_pokemon.Nome.ToString();
                tbPokedex.Text = obj_pokemon.Pokedex.ToString();
                refreshDBGrid();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro na procura: " + error);
            }
        }

        private void grade_pokemons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
