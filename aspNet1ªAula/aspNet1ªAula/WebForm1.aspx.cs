using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspNet1ªAula
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListaPokemons.Items.Add(new ListItem("Gengar", "3"));
                DropDownListaPokemons.Items.Add(new ListItem("Blastoise", "2"));
            }

            foreach (ListItem aux in DropDownListaPokemons.Items)
                ListBPokemons.Items.Add(aux);

            foreach (ListItem prov in povoarPokemon())
            {
                ListBPokemons.Items.Add(prov);
                //BulletedList1.Items.Add(prov);
            }

            DropDownListItens.DataSource = listarItens();
            DropDownListItens.DataValueField = "codigo";
            DropDownListItens.DataTextField = "nome";
            DropDownListItens.DataBind();

            BulletedList1.DataSource = povoarPokemon();
            BulletedList1.DataBind();

            //hyperlink

            HyperLinkManual.NavigateUrl = "http://www.youtube.com";
            HyperLinkManual.Target = "_blank";

            //table

            Table tabela = new Table();

            for(int linha = 0; linha<=2;linha++)
            {
                TableRow linhas = new TableRow();

                for(int coluna = 0;coluna<=1;coluna++)
                {
                    TableCell colunas = new TableCell();
                    colunas.Text = pegaPokemons(linha, coluna);
                    linhas.Cells.Add(colunas);
                }
                tabela.Rows.Add(linhas);
            }
            PlaceHolder1.Controls.Add(tabela);
        }

        private List<ListItem> povoarPokemon()
        {
            List<ListItem> listaPokemons = new List<ListItem>();
            listaPokemons.Add(new ListItem("Charizard","4"));
            listaPokemons.Add(new ListItem("Arcanine", "5"));
            listaPokemons.Add(new ListItem("Charmander", "6"));
            listaPokemons.Add(new ListItem("Bulbasauro", "7"));
            listaPokemons.Add(new ListItem("Raichu", "8"));
            listaPokemons.Add(new ListItem("Tyranitar", "9"));

            return listaPokemons;
        }

        protected void botaoClicado(Object sender, EventArgs e)
        {
            lbTitulo.Text = "Você pegou para crl chefe";
        }

        protected void DropDownListaPokemons_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDDindex.Text = DropDownListaPokemons.SelectedValue;
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach(ListItem aux in ListBPokemons.Items)
            {
                if(aux.Selected)
                {
                    tbPokemonsSelecionados.Text += aux.Text + " - ";
                }
            }
        }

        private List<Itens> listarItens()
        {
            var itens = new List<Itens>();
            var iten1 = new Itens();
            var iten2 = new Itens();
            var iten3 = new Itens();
            var iten4 = new Itens();

            iten1.codigo = 1;
            iten1.nome = "Potion";
            iten2.codigo = 2;
            iten2.nome = "Revive";
            iten3.codigo = 3;
            iten3.nome = "Pokebola";
            iten4.codigo = 4;
            iten4.nome = "Escape Rope";

            itens.Add(iten1);
            itens.Add(iten2);
            itens.Add(iten3);
            itens.Add(iten4);

            return itens;
        }

        private string pegaPokemons(int linha, int coluna)
        {
            string[,] arrayPokemons = new string[3, 2];
            arrayPokemons[0, 0] = "Pokedex";
            arrayPokemons[0, 1] = "Pokemon";
            arrayPokemons[1, 0] = "25";
            arrayPokemons[1, 1] = "Pikachu";
            arrayPokemons[2, 0] = "45";
            arrayPokemons[2, 1] = "Gengar";

            return arrayPokemons[linha, coluna].ToString();

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButtonCommand(object sender, CommandEventArgs e)
        {
            lbBTClicado.Text = "Link clicado = " + e.CommandName + " e seu numero da pokedex " + e.CommandArgument;
        }

        protected void BulletedList2_Click(object sender, BulletedListEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    lbBullet.Text = "Cliquei no facebook";
                    break;
                default:
                    lbBullet.Text = "Cliquei no youtube";
                    break;
            }
        }
    }
}