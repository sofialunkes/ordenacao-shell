using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Pessoa
{
    private string nome;
    private int idade;
    private char sexo;
    private DateTime dataCadastro;

    public Pessoa(string nome, int idade, char sexo, DateTime dataCadastro)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
        DataCadastro = dataCadastro;
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    public int Idade
    {
        get { return idade; }
        set { idade = value; }
    }
    public char Sexo
    {
        get { return sexo; }
        set { sexo = value; }
    }
    public DateTime DataCadastro
    {
        get { return dataCadastro; }
        set { dataCadastro = value; }
    }
}