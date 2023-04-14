using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Tests
{
    internal class LinkedListTest
    {
        public ILinkedListADT users;

        [SetUp]
        public void Setup()
        {
            this.users = new SLL();

        }

        [TearDown]
        public void TearDown()
        {
            this.users.Clear();
        }

        [Test]
       
        public void IsEmptyTest()
        {
            Assert.IsTrue(this.users.IsEmpty());
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            Assert.IsFalse(this.users.IsEmpty());
        }

        [Test]
        public void AddFirstTest()
        {
            User user1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            User user2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            User user3 = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");
            User user4 = new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999");

            users.AddFirst(user1);
            Assert.IsTrue(users.GetValue(0).Equals(user1));
            users.AddFirst(user2);
            Assert.IsTrue(users.GetValue(0).Equals(user2));
            users.AddFirst(user3);
            Assert.IsTrue(users.GetValue(0).Equals(user3));
        }

        [Test]
        public void AddLastTest()
        {
            User user1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            User user2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            User user3 = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");
            User user4 = new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999");

            users.AddLast(user1);
            Assert.IsTrue(users.GetValue(0).Equals(user1));
            users.AddLast(user2);
            Assert.IsTrue(users.GetValue(1).Equals(user2));
            users.AddLast(user3);
            Assert.IsTrue(users.GetValue(2).Equals(user3));
        }

        [Test]
        public void AddByIndexTest()
        {
            User user1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            User user2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            User user3 = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");
            User user4 = new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999");

            users.Add(user1, 0);
            Assert.IsTrue(users.GetValue(0).Equals(user1));

            users.Add(user2, 1);
            Assert.IsTrue(users.GetValue(1).Equals(user2));

            users.Add(user3, 1);
            Assert.IsTrue(users.GetValue(1).Equals(user3));
            Assert.IsTrue(users.GetValue(2).Equals(user2));

            users.Add(user4, 1);
            Assert.IsTrue(users.GetValue(1).Equals(user4));
            Assert.IsTrue(users.GetValue(2).Equals(user3));
        }

        [Test]
        public void ReplaceByIndexTest()
        {
            User user1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            User user2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            User user3 = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");
            User user4 = new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999");

            users.AddLast(user1);
            users.AddLast(user2);
            users.AddLast(user3);

            Assert.IsTrue(users.GetValue(0).Equals(user1));
            users.Replace(user4, 0);
            Assert.IsTrue(users.GetValue(0).Equals(user4));

            Assert.IsTrue(users.GetValue(1).Equals(user2));
            users.Replace(user4, 1);
            Assert.IsTrue(users.GetValue(1).Equals(user4));

            Assert.IsTrue(users.GetValue(2).Equals(user3));
            users.Replace(user4, 2);
            Assert.IsTrue(users.GetValue(2).Equals(user4));
        }

        [Test]
        public void RemoveFirstTest()
        {
            User user1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            User user2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            User user3 = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");
            User user4 = new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999");

            users.AddLast(user1);
            users.AddLast(user2);
            users.AddLast(user3);

            users.RemoveFirst();
            Assert.IsTrue(users.GetValue(0).Equals(user2));

            users.RemoveFirst();
            Assert.IsTrue(users.GetValue(0).Equals(user3));

            users.RemoveFirst();
            Assert.IsNull(users.GetValue(0));
        }

        [Test]
        public void RemoveLastTest()
        {
            User user1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            User user2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            User user3 = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");
            User user4 = new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999");

            users.AddLast(user1);
            users.AddLast(user2);
            users.AddLast(user3);

            users.RemoveLast();
            Assert.IsTrue(users.GetValue(1).Equals(user2));
            Assert.Throws<IndexOutOfRangeException>(() => users.GetValue(2));

            users.RemoveLast();
            Assert.IsTrue(users.GetValue(0).Equals(user1));
            Assert.Throws<IndexOutOfRangeException>(() => users.GetValue(1));

            users.RemoveLast();
            Assert.IsNull(users.GetValue(0));
        }

        [Test]
        public void RemoveByIndexTest()
        {
            User user1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            User user2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            User user3 = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");
            User user4 = new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999");

            users.AddLast(user1);
            users.AddLast(user2);
            users.AddLast(user3);
            users.AddLast(user4);

            Assert.IsTrue(users.GetValue(2).Equals(user3));
            users.Remove(2);
            Assert.IsTrue(users.GetValue(2).Equals(user4));
            Assert.Throws<IndexOutOfRangeException>(() => users.GetValue(3));

            Assert.IsTrue(users.GetValue(0).Equals(user1));
            users.Remove(0);
            Assert.IsTrue(users.GetValue(0).Equals(user2));
            Assert.Throws<IndexOutOfRangeException>(() => users.GetValue(2));

            Assert.IsTrue(users.GetValue(1).Equals(user4));
            users.Remove(1);
            Assert.Throws<IndexOutOfRangeException>(() => users.GetValue(1));
        }

        [Test]
        public void IndexOfValueAndGetValueTest()
        {
            User user1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            User user2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            User user3 = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");
            User user4 = new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999");

            users.AddLast(user1);
            users.AddLast(user2);
            users.AddLast(user3);
            users.AddLast(user4);


            Assert.IsTrue(users.GetValue(0).Equals(user1));
            Assert.IsTrue(users.GetValue(1).Equals(user2));
            Assert.IsTrue(users.GetValue(2).Equals(user3));
            Assert.IsTrue(users.GetValue(3).Equals(user4));
            Assert.Throws<IndexOutOfRangeException>(() => users.GetValue(-1));
            Assert.Throws<IndexOutOfRangeException>(() => users.GetValue(4));


            Assert.IsTrue(users.IndexOf(user1).Equals(0));
            Assert.IsTrue(users.IndexOf(user1).Equals(0));
            Assert.IsTrue(users.IndexOf(user2).Equals(1));
            Assert.IsTrue(users.IndexOf(user3).Equals(2));
            Assert.IsTrue(users.IndexOf(user4).Equals(3));
            Assert.IsTrue(users.IndexOf(new User(5, "Joe", "j@gmail.com", "password")).Equals(-1));

        }

        [Test]
        public void ReverseOrderTest()
        {
            User user1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            User user2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            User user3 = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");
            User user4 = new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999");

            users.AddLast(user1);
            users.AddLast(user2);
            users.AddLast(user3);
            users.AddLast(user4);

            Assert.IsTrue(users.GetValue(0).Equals(user1));
            Assert.IsTrue(users.GetValue(1).Equals(user2));
            Assert.IsTrue(users.GetValue(2).Equals(user3));
            Assert.IsTrue(users.GetValue(3).Equals(user4));

           
        }
    }
}


    

