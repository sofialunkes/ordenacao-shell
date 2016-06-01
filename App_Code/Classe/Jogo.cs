using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Jogo
/// </summary>
public class Jogo
{
    private string nome;
    private string genero;
    private int idJogo;

    public Jogo()
    {
        
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
}