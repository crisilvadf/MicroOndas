using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio;

namespace ProjetoMicroOndas.Test
{
    [TestClass]
    public class TesteClasses
    {
        [TestMethod]
        public void TestMethod1()
        {
            CriaNovoPrograma criaNovoPrograma = new CriaNovoPrograma();
            criaNovoPrograma.Create("Teste", "kkkkkkkkk", "121", "12", "instruções de uso kkakakakakakaka");
        }
    }
}
