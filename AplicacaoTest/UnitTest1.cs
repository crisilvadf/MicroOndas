using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using neMicroOndas;

namespace AplicacaoTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Primeiro método a ser executado
        /// </summary>
        [TestInitialize]
        public void ValidaTempoTeste()
        {
            ValidaTempo validaTempo = new ValidaTempo();
            validaTempo.tempoCozimento("5");
        }

        [TestMethod]
        public void TesteCriarPrograma()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        [TestCleanup]
        public void FinalizarTeste()
        {

        }
    }
}
