using CodingGame.Cards;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void Should_Use_Struct()
        {
            Struct struc1;
            struc1.foo = "5";

            Struct struct2 = struc1;
            struct2.foo = "10";

            var res = struc1.foo;
        }

        [Test]
        public void Should_Use_DateTime()
        {
            var date = new DateTime(0);
            var ddd = date.AddHours(2);

            var res = ddd.Hour;
            var res1 = date.Hour;
        }

        [Test]
        public void Should_Use_LinqExpression()
        {
            string[] fruits = { "kiwi", "patates", "bananes" };
            var list = new List<string>(fruits);
            var query = list.Where(x => x.Length == 4);
            var res1 = query.Count();
            list.Remove("kiwi");
            var res2 = query.Count();
        }

        [Test]
        public void DoubleDecimal()
        {
            string[] valeurString = { "-1,001", "1,01" };
            decimal total1 = 0;
            double total2 = 0;
            foreach(var str in valeurString)
            {
                total1 = total1 + decimal.Parse(str);
                total2 = total2 + double.Parse(str);
            }
        }

        [Test]
        public void Max()
        {
            int[] testData = { 5, 15, 3, 3, 56, 100, 2 };
            int[] testData1 = { 5 };
            var res = Algo.FindLargest(testData);
            var res1 = Algo.FindLargest(testData1);
        }

        [Test]
        public void PlusPlus()
        {
            int i = 0;
            Console.WriteLine($"Valeur de i: {i++}");
            int j = i;
        }

        [Test]
        public void Prime()
        {
            var res = new List<int>();
            for(int i=0; i<100; i++ )
            {
                if(Algo.IsPrime(i))
                {
                    res.Add(i);
                }
            }
        }


        [Test]
        public void Cards()
        {
            var game = new Game(4, 32);
            game.DistributeCardsEvenlyToPlayers();
        }
    }
}
