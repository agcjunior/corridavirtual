using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CorridaVirtual.Domain.Test
{
    [TestClass]
    public class RegistroTests
    {
        [TestMethod]
        public void Posso_Criar_Um_Registro()
        {
            var registro = new Registro();
            Assert.IsNotNull(registro);
        }
    }
}
