using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityDemo.Models;
using UnityDemo.Models.Scorers;

namespace Assets.Tests
{
    class BasicScorerTest_이경수
    {

        [Test]
        public void 광땡으로_이기는_경우()
        {
            Scorer scorer = new BasicScorer();
            Player p1 = new Player("문슬기범");
            p1.AddCard(new Card(8, false));
            p1.AddCard(new Card(1, false));

            Player p2 = new Player("박혜강");
            p2.AddCard(new Card(3, true));
            p2.AddCard(new Card(1, true));

            Player winner = scorer.GetWinner(p1, p2);

            Assert.AreEqual(p2, winner);
        }

        [Test]
        public void 땡으로_이기는_경우()
        {
            Scorer scorer = new BasicScorer();
            Player p1 = new Player("문슬기범");
            p1.AddCard(new Card(8, false));
            p1.AddCard(new Card(8, false));

            Player p2 = new Player("박혜강");
            p2.AddCard(new Card(7, false));
            p2.AddCard(new Card(2, false));

            Player winner = scorer.GetWinner(p1, p2);

            Assert.AreEqual(p1, winner);
        }

        [Test]
        public void 끗으로_이기는_경우()
        {
            Scorer scorer = new BasicScorer();
            Player p1 = new Player("문슬기범");
            p1.AddCard(new Card(2, false));
            p1.AddCard(new Card(5, false));

            Player p2 = new Player("박혜강");
            p2.AddCard(new Card(4, false));
            p2.AddCard(new Card(6, false));

            Player winner = scorer.GetWinner(p1, p2);

            Assert.AreEqual(p1, winner);
        }
    }
}
