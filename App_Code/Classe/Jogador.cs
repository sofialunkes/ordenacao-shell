using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Jogador : Pessoa
{
    private string nick;
    private int numConta;
    private List<Jogo> jogos;
    private string p1;
    private int p2;
    private string p3;
    private int p4;
    private DateTime dateTime;
    private System.Web.UI.WebControls.TextBoxMode textBoxMode;
    private int p;
    private Type type;
    private float p5;
    private long p6;
    private sbyte p7;
    private System.Web.UI.WebControls.ListItem listItem;



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