using Microsoft.VisualStudio.TestTools.UnitTesting;
using demo3;

namespace TestProject5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test()
        {
            var sverreMagnus = new Person { Id = 1, FirstName = "Sverre Magnus", BirthYear = 2005 };
            var ingridAlexandra = new Person { Id = 2, FirstName = "Ingrid Alexandra", BirthYear = 2004 };
            var haakon = new Person { Id = 3, FirstName = "Haakon Magnus", BirthYear = 1973 };
            var harald = new Person { Id = 6, FirstName = "Harald", BirthYear = 1937 };
            sverreMagnus.Father = haakon;
            ingridAlexandra.Father = haakon;
            haakon.Father = harald;

            var app = new FamilyApp(sverreMagnus, ingridAlexandra, haakon);
            var actualResponse = app.HandleCommand("show 3");
            var expectedResponse = "Haakon Magnus (Id=3) F�dt: 1973";
                   //+ "  Barn:\n"
                   //+ "    Sverre Magnus (Id=1) F�dt: 2005\n"
                   //+ "    Ingrid Alexandra (Id=2) F�dt: 2004\n";
            Assert.AreEqual(expectedResponse, actualResponse);
        }
    }
}
