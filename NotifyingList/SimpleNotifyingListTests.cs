using System.Collections.Generic;
using NUnit.Framework;

namespace NotifyingList
{
    /// <summary>
    /// A class for generating lists of fruit
    /// </summary>
    public class FruitListManager
    {
        public FruitListManager(ISimpleList<string> list)
        {
            m_list = list;
        }

        /// <summary>
        /// Add citrus fruits to the list
        /// </summary>
        public void addCitrusFruits()
        {
            m_list.Add("Orange");
            m_list.Add("Lemon");
        }

        /// <summary>
        /// Add pome fruits to the list
        /// </summary>
        public void addPomeFruits()
        {
            m_list.Add("Apple");
            m_list.Add("Pear");
        }

        private readonly ISimpleList<string> m_list;
    }

     /*
      *  The following tests are used to test our notifying lists with the FruitListManager
      *   class
      *
      *  Does they pass?
      */
    [TestFixture]
    internal class SimpleNotifyingListTests
    {
        [Test]
        public void TestSimpleNotifyingList1()
        {
            var list = new SimpleNotifyingList1<string>();
            var events = new List<UpdatedEventArgs.ActionEnum>();

            // We define action to capture events fired...
            list.Updated += (sender, e) => events.Add(e.Action);

            // We add citrus fruits to our list...
            var fruitListManager = new FruitListManager(list);
            fruitListManager.addCitrusFruits();

            // We check that the citrus fruits have been added to our list..
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(true, list.Contains("Orange"));
            Assert.AreEqual(true, list.Contains("Lemon"));

            // We check that the Updated event has fired as expected...
            CollectionAssert.AreEqual(
                new List<UpdatedEventArgs.ActionEnum>
                {
                    UpdatedEventArgs.ActionEnum.Add,
                    UpdatedEventArgs.ActionEnum.Add

                },
                events);
        }

        [Test]
        public void TestSimpleNotifyingList2()
        {
            var list = new SimpleNotifyingList2<string>();
            var events = new List<UpdatedEventArgs.ActionEnum>();

            // We define action to capture events fired...
            list.Updated += (sender, e) => events.Add(e.Action);

            // We add citrus fruits to our list...
            var fruitListManager = new FruitListManager(list);
            fruitListManager.addCitrusFruits();

            // We check that the citrus fruits have been added to our list..
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(true, list.Contains("Orange"));
            Assert.AreEqual(true, list.Contains("Lemon"));

            // We check that the Updated event has fired as expected...
            CollectionAssert.AreEqual(
                new List<UpdatedEventArgs.ActionEnum>
                {
                    UpdatedEventArgs.ActionEnum.Add,
                    UpdatedEventArgs.ActionEnum.Add

                },
                events);
        }
    }
}
