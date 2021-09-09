using Microsoft.VisualStudio.TestTools.UnitTesting;
using demo3;
using System;

namespace TestProject4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNoFields()
            {
                var p = new Person
                {
                    Id = 1,
                };

                var actualDescription = p.GetDescription();
                var expectedDescription = "(Id=1)";

                Assert.AreEqual(expectedDescription, actualDescription);
            }
        }
    }

