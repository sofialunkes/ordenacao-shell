using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Jogador : Pessoa
{
    public string Nick { get; set; }
    public List<Jogo> Jogos { get; set; }
    public int NumConta { get; set; }

    public Jogador(int numConta, string nome, int idade, char sexo, DateTime dataCadastro, string nick)
        : base(nome, idade, sexo, dataCadastro)
    {

        this.Nome = nome;
        this.NumConta = numConta;
        this.Idade = idade;
        this.Sexo = sexo;
        this.DataCadastro = dataCadastro;
        this.Nick = nick;
        this.Jogos = new List<Jogo>();
    }
}