using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Jogo
{
    private string nome;
    private string genero;
    private int idJogo;

    public Jogo()
    {
        Nome = "";
        Genero = "";
        IdJogo = 0;
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Genero
    {
        get { return genero; }
        set { genero = value; }
    }

    public int IdJogo
    {
        get { return idJogo; }
        set { idJogo = value; }
    }
    public override string ToString()
    {
        return "Nome:" + Nome + "<br/> Genero:" + Genero;
    }
}