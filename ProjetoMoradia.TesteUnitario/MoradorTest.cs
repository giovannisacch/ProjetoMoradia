using Xunit;
using ProjetoMoradia.Models;
using System;

namespace ProjetoMoradia.TesteUnitario;

public class MoradorTest
{
    [Fact]
    public void MoradorDeveTerDataNascimentoEsperada()
    {
        //Preparando - Arrange
        var dataNascimentoEsperada = "04/04/2004";
        var morador = new Morador("Giovanni", "44455566678", dataNascimentoEsperada);
        //DataNascimento - Act
        var dataNascimento = morador.GetDataDeNascimento();

        Assert.Equal(dataNascimentoEsperada, dataNascimento.ToString("dd/MM/yyyy"));
    }
     [Fact]
    public void MoradorNaoDeveTerDataNascimentoMaiorQueADataAtual()
    {
        //Preparando - Arrange
        var dataNascimento = "04/04/2023";
        var morador = new Morador("Giovanni", "44455566678", dataNascimento);
        //DataNascimento - Act
        var dataNascimentoAtual = morador.GetDataDeNascimento();

        Assert.Equal(DateTime.MinValue, dataNascimentoAtual);
    }
}