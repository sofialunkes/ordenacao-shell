using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    int cont = 0;
    

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
    }
    protected void btnSalvarJogador_Click(object sender, EventArgs e)
    {
        DateTime agora = DateTime.Now;


        Jogador gamer = new Jogador(Convert.ToString(txtNome.TextMode), Convert.ToInt32(txtIdade.TextMode), Convert.ToChar(ddlSexo.SelectedValue), agora);
        gamer.Nome = txtNome.Text;
        gamer.Idade = Convert.ToInt32(txtIdade.TextMode);
        gamer.Nick = txtNick.Text;
        gamer.NumConta = cont++;
        gamer.DataCadastro = agora;
        lblExibir.Text += "<tr><td>" + txtNome.Text + "</td><td>" + txtNick.Text +"</td></tr>";
        Jogador_DB.selectJogadores();

    }
    protected void btnLimparCadastro_Click(object sender, EventArgs e)
    {
        txtNome.Text = "";
        txtNick.Text = "";
        txtIdade.Text = null;
        ddlSexo.SelectedIndex = 0;
        
        }

    public static int[] ShellSort(int[] array)
    {
        int gap = array.Length / 2;
        while (gap > 0)
        {
            for (int i = 0; i < array.Length - gap; i++) //modified insertion sort
            {
                int j = i + gap;
                int tmp = array[j];
                while (j >= gap && tmp > array[j - gap])
                {
                    array[j] = array[j - gap];
                    j -= gap;
                }
                array[j] = tmp;
            }
            if (gap == 2) //change the gap size
            {
                gap = 1;
            }
            else
            {
                gap = (int)(gap / 2.2);
            }
        }
        return array;
    }

}