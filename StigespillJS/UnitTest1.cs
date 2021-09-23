using NUnit.Framework;
using StigespilletJS;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StartUp()
        {
            var model = new Model();
            model.initModel();

            int pos = 1;

            var actual = model.getPositionType(pos);
            var expected = "ladderStartUp";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void EndUp()
        {
            var model = new Model();
            model.initModel();

            int pos = 40;
            var actual = model.getPositionType(pos);
            var expected = "ladderEndUp";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void StartDown()
        {
            var model = new Model();
            model.initModel();

            int pos = 24;
            var actual = model.getPositionType(pos);
            var expected = "ladderStartDown";


            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void EndDown()
        {
            var model = new Model();
            model.initModel();

            int pos = 3;
            var actual = model.getPositionType(pos);
            var expected = "ladderEndDown";

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Regular()
        {
            var model = new Model();
            model.initModel();

            int pos = 2;
            var actual = model.getPositionType(pos);
            var expected = "";

            Assert.AreEqual(expected, actual);
        }

    }
}