using Xunit;
using ProjetoMoradia.Models;

namespace ProjetoMoradia.TesteUnitario
{
    public class ApartamentoTest
    {
        [Fact]
        public void ApartamentoDeveriaSerDoSegundoAndar(){
            //Arrange - Preparação
            var andarEsperado = 2;
            var apto = new Apartamento("teste", 2222, 43, 2, 1, andarEsperado, 510);

            //Act - Agir
            var andarApto = apto.GetAndar();

            //Assert - Verficiar
            Assert.Equal(andarEsperado, andarApto);
        }
    }
}
