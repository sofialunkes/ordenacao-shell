using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Jogador
/// </summary>
public class Jogador : Pessoa
{
    private string nick;
    private int numConta;
    private ArrayList jogos;

    public Jogador(string nome, int idade)
        : base(nome, idade)
    {
        NumConta = 0;
        Nick = "";
    }

    public int NumConta
    {
        get { return numConta; }
        set { numConta = value; }
    }
    public string Nick
    {
        get { return nick; }
        set { nick = value; }
    }

}