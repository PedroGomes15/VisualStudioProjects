<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Panel.aspx.cs" Inherits="aspNet1ªAula.Panel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btPanel1" runat="server" OnClick="btPanel1_Click" Text="Button to Panel 1" />
        <asp:Button ID="btPanel2" runat="server" OnClick="btPanel2_Click" Text="Button to Panel 2" />
        <asp:Panel ID="Panel1" runat="server" BackColor="#99FF66" ForeColor="#FF3399" GroupingText="Pokemons Legais" Height="59px" Width="333px">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="#0066FF" Direction="RightToLeft" ForeColor="#FFFF99" GroupingText="Panel2" Height="69px" HorizontalAlign="Center" Width="455px">
        </asp:Panel>
        <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/Pokemons.xml" Height="100px" Width="100px" />
        <asp:Panel ID="Panel3" runat="server" GroupingText="Radio Button" Width="483px" BackColor="#66FF99" ForeColor="#9900FF">
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gnSexo" Text="Homeme" OnCheckedChanged="itensGnPessoa" AutoPostBack="True" />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gnSexo" Text="Mulherão da Porra" OnCheckedChanged="itensGnPessoa" AutoPostBack="True" />
            <asp:Label ID="lbSexo" runat="server" Text="sexo selecionado..." style="text-align:center" Width="200px"></asp:Label>
            <asp:RadioButtonList ID="rblPessoa" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem Value="0">Pessoa Juridica</asp:ListItem>
                <asp:ListItem Value="1">Pessoa Fisica</asp:ListItem>
            </asp:RadioButtonList>
        </asp:Panel>
        <asp:MultiView ID="MultiView" runat="server">
            <asp:View ID="View1PessoaFisica" runat="server">
                <asp:Panel ID="Panel4" runat="server" BackColor="#99FF66" ForeColor="#FF3399" GroupingText="Pessoa Juridica" Height="59px" Width="333px">
                <asp:Label ID="Label2" runat="server" Text="CNPJ"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" Text="Gravar" />
                </asp:Panel>
            </asp:View>
            <asp:View ID="View2PessoaJuridica" runat="server">
                <asp:Panel ID="Panel5" runat="server" BackColor="#CC0000" ForeColor="#00FF99" GroupingText="Pessoa Fisica" Height="59px" Width="333px">
                <asp:Label ID="Label3" runat="server" Text="CPF"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:Button ID="Button3" runat="server" Text="Gravar" />
                </asp:Panel>
            </asp:View>
        </asp:MultiView>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
