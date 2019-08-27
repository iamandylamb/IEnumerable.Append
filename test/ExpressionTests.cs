using System;
using System.Collections.Generic;
using System.Linq;
using IEnumerable.Append;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{
    [TestClass]
    public class ExpressionTests
    {
        [TestMethod]
        public void OneItemAppended()
        {
            IEnumerable<string> input = new [] { "Lorem", "ipsum", "dolor", "sit" };

            IEnumerable<string> output = input.Append("amet");

            Assert.AreEqual(4, input.Count());
            Assert.AreEqual(5, output.Count());
        }

        [TestMethod]
        public void ItemAppendedToEnd()
        {
            IEnumerable<string> input = new [] { "Lorem", "ipsum", "dolor", "sit" };

            string item = "amet";
            IEnumerable<string> output = input.Append(item);

            Assert.AreEqual(item, output.Last());
        }

        [TestMethod]
        public void AppendedToEmptyCollection()
        {
            IEnumerable<string> input = Enumerable.Empty<string>();

            string item = "amet";
            IEnumerable<string> output = input.Append(item);

            Assert.AreEqual(item, output.Single());
        }

        [TestMethod]
        public void AppendedToNullCollection()
        {
            IEnumerable<string> input = null;

            try
            {
                string item = "amet";
                IEnumerable<string> output = input.Append(item);

                Assert.Fail("Exception expected");
            }
            catch (ArgumentNullException) 
            {
                // This is the correct outcome.
            }
            catch (Exception ex)
            {
                Assert.Fail($"Exception of type {ex.GetType().Name} not expected");
            }
        }
    }
}
