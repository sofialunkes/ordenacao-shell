using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Jogador_DB
/// </summary>
public class Jogador_DB
{
    private List<Jogador> jogadores = new List<Jogador>();

    public string SelectJogadores()
    {
        string text = "";
        foreach (Jogador gamer in jogadores)
        {
            text += "<tr><td>" + gamer.NumConta + "</td><td>" + gamer.Nome + "</td><td>" + gamer.Idade + "</td><td>" + gamer.Sexo + "</td><td>" + gamer.Nick + "</td><td>" + gamer.DataCadastro + "</td></tr>";
        }

        return text;
    }

    public void SelectJogadorPorId()
    {

    }

    public void SelectIdsJogadores()
    {

    }

    public void SalvarJogador(Jogador jogador)
    {
        jogadores.Add(jogador);
    }
}