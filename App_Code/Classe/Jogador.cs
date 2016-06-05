using System;
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
    private List<Jogo> jogos;



    public Jogador(string nome, int idade, char sexo, DateTime dataCadastro)
        : base(nome, idade, sexo, dataCadastro)
    {

        this.Nome = nome;
        this.Idade = idade;
        this.Sexo = sexo;
        this.DataCadastro = dataCadastro;
        this.NumConta = 0;
        this.Nick = "";
        this.Jogos = null;
    }

    public int NumConta { get; set; }
    public string Nick { get; set; }
    public List<Jogo> Jogos { get; set; }
}