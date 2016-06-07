using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for JogosCadastrados
/// </summary>
public static class JogosCadastrados
{

    private static  string[] vetor = {"World Of Warcraft","Fifa 2016","Starcraft 2","Mafia 3","God of War","Mortal Kombat","League Of Legends","Top Gear","Dota 2","The Sims 4"};


    public static string Select()
    {
        return "<tr><td>"+vetor[0]+"</td></tr><tr><td>"+vetor[1]+"</td></tr><tr><td>"+vetor[2]+"</td></tr><tr><td>"+vetor[3]+"</td></tr><tr><td>"+vetor[4]+"</td></tr><tr><td>"+vetor[5]+"</td></tr>"+
            "<tr><td>"+vetor[6]+"</td></tr><tr><td>"+vetor[7]+"</td></tr><tr><td>"+vetor[8]+"</td></tr><tr><td>"+vetor[9]+"</td></tr>";
      
    }
}