<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="aspNet1ªAula.WebForm1" %>

<!DOCTYPE html>

<script runat="server" language="c#">

    void botaoCliquei(Object sender, EventArgs e)
    {
        lbTitulo.Text = "Você pegou chefe";
    }

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbTitulo" runat ="server" Font-Size="22px" ForeColor="blue" 
                BackColor="#98fb98" BorderWidth="6px" BorderColor="Black" BorderStyle="Double" Width ="300px" 
                style="text-align:center" Font-Names="Arial" ToolTip="Temos que pegar"
                Text="Pokemon by Pedro">


            </asp:Label>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="botaoClicado" Text="Tente  pega-los" ForeColor="Red" BackColor="#FFFF66" Font-Size="16px" />
        </p>
        <asp:DropDownList ID="DropDownListaPokemons" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListaPokemons_SelectedIndexChanged">
            <asp:ListItem Value="1">Pikachu</asp:ListItem>
            <asp:ListItem Value="4">Lucario</asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:Label ID="lbDDindex" runat="server"></asp:Label>
        </p>
        <asp:ListBox ID="ListBPokemons" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" SelectionMode="Multiple"></asp:ListBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Monstrar pokemons selecionados" />
        <asp:TextBox ID="tbPokemonsSelecionados" runat="server" Width="281px"></asp:TextBox>
        <asp:DropDownList ID="DropDownListItens" runat="server">
        </asp:DropDownList>
        <p>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        </p>
        <asp:LinkButton ID="LinkButton1" runat="server" BackColor="#FFFF66" BorderColor="#CC0066" BorderStyle="Solid" BorderWidth="2px" style="text-align:center" Font-Overline="False" Font-Strikeout="False" Height="50px" OnClick="LinkButton1_Click" PostBackUrl="http://google.com.br" Width="100px">BotaoLegal</asp:LinkButton>
        <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl="~/Resources/002.JPG" ImageWidth="100px" NavigateUrl="http://www.facebook.com" Target="_blank">Abre o meu facebook</asp:HyperLink>
        <asp:Label ID="Label1" runat="server" ForeColor="#0033CC" Text="&lt;-- Link para o facebook"></asp:Label>
        <asp:LinkButton ID="lbUdemy" runat="server" style="text-align:center" Width="150px" OnClientClick="acessoSiteUdemy()">Bora para Udemy</asp:LinkButton>
        <asp:LinkButton ID="lbUdemy0" runat="server" style="text-align:center" Width="85px" CommandArgument="45" CommandName="PokeGengar" OnCommand="LinkButtonCommand">Gengar</asp:LinkButton>
        <asp:LinkButton ID="lbUdemy1" runat="server" style="text-align:center" Width="100px" CommandArgument="9" CommandName="PokeBlastoise" OnCommand="LinkButtonCommand">Blastoise</asp:LinkButton>
        <asp:Label ID="lbBTClicado" runat="server" Text="Label" style="text-align:center" Width="300px" Font-Bold="True" Font-Size="15pt" ForeColor="#FF3300"></asp:Label>
        <asp:BulletedList ID="BulletedList1" runat="server" BulletStyle="UpperRoman">
        </asp:BulletedList>
        <asp:Label ID="lbBullet" runat="server" Text="Label"></asp:Label>
        <asp:BulletedList ID="BulletedList2" runat="server" DisplayMode="LinkButton" OnClick="BulletedList2_Click">
            <asp:ListItem Value="http://facebook.com">Facebook</asp:ListItem>
            <asp:ListItem Value="http://youtube.com">Youtube</asp:ListItem>
        </asp:BulletedList>
        <asp:HyperLink ID="HyperLinkManual" runat="server">HyperLink manual né</asp:HyperLink>
        <asp:Image ID="Image1" runat="server" Height="354px" ImageUrl="~/Imagens/10153644_632809526803285_6649939934284640613_n.jpg" Width="263px" />
    </form>
    <script type="text/javascript">
        function acessoSiteUdemy()
        {
            //script para trocar de pagina
            javascrip: window.open("https://www.udemy.com");
        }
    </script>
</body>
</html>
