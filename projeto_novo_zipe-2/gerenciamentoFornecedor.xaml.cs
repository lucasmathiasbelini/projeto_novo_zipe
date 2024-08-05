using System;
using Microsoft.Maui.Controls;
namespace projeto_novo_zipe_2;


public partial class gerenciamentofornecedor
{

    String criterioselecao;
    int id;
    String avaliacaodesempenho;
    string analisar;

    ///*****************************************************************************************///
    /// </summary>classe Set Email <summary>///  
    public void Setemail(string criterioselecao)
    {
        this.criterioselecao = criterioselecao;
    }

    ///*****************************************************************************************///
    /// </summary> classe ID <summary>///             
    public void Setid()
    {
        this.id = 1000;
    }

    ///*****************************************************************************************///
    /// </summary>classe Get Email <summary>///  
    public string Getemail(string email)
    {
        return email;
    }

    ///*****************************************************************************************///

    public void Setavaliacaodesempenho(string avaliacaodesempenho)
    {

        this.avaliacaodesempenho = avaliacaodesempenho;

    }
    ///******************************************************************************************///

    public void Getavaliacaodesempenho(string avaliacaodesempenho)
    {

    }
    public string Getanalisar(string analisar)
    {
        return analisar;
    }
    public void Setanalisar(string analisar)
    {
        this.analisar = analisar;
    }
}