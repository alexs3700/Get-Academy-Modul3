using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stigespill_v2;

namespace TestProject4
{
    [TestClass]
    public class UnitTest1
    {
    
        [TestMethod]
        public void startUpTest()
        {
            var model = new Model();


            Ladder ladder = new Ladder();


            int pos = 1;

            ladder.getLadderTypeAtPosition(pos);
            var actual = ladder.typeOfLadder;



            var expected = "startUp";

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void endUpTest()
        {
            var model = new Model();


            Ladder ladder = new Ladder();


            int pos = 40;

            ladder.getLadderTypeAtPosition(pos);
            var actual = ladder.typeOfLadder;



            var expected = "endUp";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void startDownTest()
        {
            var model = new Model();


            Ladder ladder = new Ladder();


            int pos = 24;

            ladder.getLadderTypeAtPosition(pos);
            var actual = ladder.typeOfLadder;



            var expected = "startDown";

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void endDownTest()
        {
            var model = new Model();


            Ladder ladder = new Ladder();


            int pos = 3;

            ladder.getLadderTypeAtPosition(pos);
            var actual = ladder.typeOfLadder;



            var expected = "endDown";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void finishTest()
        {
            var model = new Model();


            Ladder ladder = new Ladder();


            int pos = 90;

            ladder.getLadderTypeAtPosition(pos);
            var actual = ladder.typeOfLadder;



            var expected = "finish";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void regularPositionTest()
        {
            var model = new Model();


            Ladder ladder = new Ladder();


            int pos = 2;

            ladder.getLadderTypeAtPosition(pos);
            var actual = ladder.typeOfLadder;



            var expected = "";

            Assert.AreEqual(expected, actual);
        }


    }
}
