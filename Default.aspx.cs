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

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DateTime agora = DateTime.Now;
        Jogador j = new Jogador(Convert.ToString(txtNome.TextMode), Convert.ToInt32(txtIdade.TextMode), Convert.ToChar(RadioButtonList1.SelectedValue), agora);
        j.Nome = txtNome.Text;
        j.Idade = Convert.ToInt32(txtIdade.Text);
        j.Nick = txtNick.Text;
        j.NumConta = Convert.ToInt32(txtNumeroConta.Text);
        j.DataCadastro = agora;

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