using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            lblJogosCadastrados.Text = JogosCadastrados;
        }


        if (Session["JOGADORES"] != null)
        {
            Jogador_DB jogadores = (Jogador_DB)Session["JOGADORES"];
            lblInformacoesJogador.Text = jogadores.SelectJogadores();
        }


    }

    protected void btnSalvarJogador_Click(object sender, EventArgs e)
    {
        Jogador gamer = new Jogador(Convert.ToInt32(txtNumConta.Text), Convert.ToString(txtNome.Text), Convert.ToInt32(txtIdade.Text), Convert.ToChar(ddlSexo.SelectedValue), DateTime.Now, txtNick.Text);

        if (Session["JOGADORES"] != null)
        {
            Jogador_DB jogadores = (Jogador_DB)Session["JOGADORES"];
            jogadores.SalvarJogador(gamer);
            Session["JOGADORES"] = jogadores;
        }
        else
        {
            Jogador_DB jogadores = new Jogador_DB();
            jogadores.SalvarJogador(gamer);
            Session["JOGADORES"] = jogadores;
        }
    }

    protected void btnLimparCadastro_Click(object sender, EventArgs e)
    {
        txtNome.Text = "";
        txtNick.Text = "";
        txtIdade.Text = null;
        ddlSexo.SelectedIndex = 0;
        txtNumConta.Text = "";
    }

    public List<Jogo> ShellSort(Jogador jogador)
    {
        int tamanhoArray=  jogador.Jogos.Count;
        int gap = tamanhoArray/2;
        List<Jogo> vetTemp = jogador.Jogos;
        while (gap > 0)
        {
            for (int i = 0; i < tamanhoArray - gap; i++) //modified insertion sort
            {
                int j = i + gap;
                Jogo tmp = vetTemp[j];
                while (j >= gap && tmp.IdJogo > vetTemp[j - gap].IdJogo)
                {
                    vetTemp[j] = vetTemp[j - gap];
                    j -= gap;
                }
                vetTemp[j] = tmp;
            }
            if (gap == 2)
            {
                gap = 1;
            }
            else
            {
                gap = (int)(gap / 2.2);
            }
        }
        return vetTemp;
    }
    
}