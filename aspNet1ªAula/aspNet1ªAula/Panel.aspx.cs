using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspNet1ªAula
{
    public partial class Panel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label lb2 = new Label();
            lb2.Text = "Label do panel 2";
            TextBox tb2 = new TextBox();
            Button bt2 = new Button();
            bt2.Text = "Salvar";
            Panel2.Controls.Add(lb2);
            Panel2.Controls.Add(tb2);
            Panel2.Controls.Add(bt2);
        }

        protected void btPanel1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
        }

        protected void btPanel2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
        }
        protected void itensGnPessoa(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
                lbSexo.Text = "Macho é lixo";
            else if (RadioButton2.Checked)
                lbSexo.Text = "Mulher é deusa";
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MultiView.ActiveViewIndex = rblPessoa.SelectedIndex;
        }
    }
}