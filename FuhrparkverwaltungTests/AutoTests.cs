using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fuhrparkverwaltung;

namespace FuhrparkverwaltungTests
{
    [TestClass]
    public class AutoTests
    {
        [TestMethod]
        public void Fahren_SteigertKilometerstand()
        {
            //Arrange
            int kilometerstand = 0;
            Auto a = new Auto(kilometerstand);
            int streckeInKilometern = 50;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(50, a.Kilometerstand);
        }

        [TestMethod]
        public void Fahren_NichtVeraendernKilometerstandWennNegativ()
        {
            //Arrage
            int kilometerstand = 25;
            Auto a = new Auto(kilometerstand);
            int negativeStreckeInKilometern = -5;

            //Act
            a.Fahren(negativeStreckeInKilometern);

            //Assert

            Assert.AreEqual(25, a.Kilometerstand);
        }
    }
}
