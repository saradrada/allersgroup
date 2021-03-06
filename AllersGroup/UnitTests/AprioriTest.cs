﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;
using System.Collections.Generic;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class AprioriTest
    {
        private List<String[]> solution;
        private List<String[]> input;
        private List<String> input2;
        private String[] candidates;

        private void SetUp1()
        {
            input = new List<String[]>();
            input.Add(new[] { "Bread", "Milk" });
            input.Add(new[] { "Beer", "Diapers" });
            input.Add(new[] { "Cola", "Diapers" });
            input.Add(new[] { "Beer", "Cola" });

        }

        private void SetUp2()
        {
            input = new List<String[]>();
            input.Add(new[] { "Bread", "Diapers" });
            input.Add(new[] { "Bread", "Milk" });
            input.Add(new[] { "Beer", "Cola" });
            input.Add(new[] { "Beer", "Diapers" });
            input.Add(new[] { "Bread", "Eggs" });
        }

        private void SetUp3()
        {
            input = new List<String[]>();
            input.Add(new[] { "Beer", "Bread", "Milk" });
            input.Add(new[] { "Beer", "Bread", "Diapers" });
            input.Add(new[] { "Beer", "Cola", "Diapers" });
            input.Add(new[] { "Beer", "Cola", "Eggs" });
            input.Add(new[] { "Bread", "Diapers", "Eggs" });
            input.Add(new[] { "Bread", "Diapers", "Milk" });
        }

        private void SetUp4()
        {
            input = new List<String[]> { new[] { "Beer" }, new[] { "Bread" }, new[] { "Eggs" }, new[] { "Diapers" }, new[] { "Milk" } };
            solution = new List<String[]>
                        { new[] {"Beer",   "Bread" },
                        new[] {"Beer",   "Eggs" },
                        new[] {"Beer"   ,"Diapers" },
                        new[] {"Beer"   ,"Milk" },
                        new[] {"Bread"   ,"Eggs" },
                        new[] {"Bread"   ,"Diapers" },
                        new[] {"Bread"   ,"Milk" },
                        new[] {"Eggs"   ,"Diapers" },
                        new[] {"Eggs"   ,"Milk" },
                        new[] {"Diapers"   ,"Milk" },
                        };
        }

        private void SetUp5()
        {
            input = new List<String[]>
                        {
                        new[] {"Beer",   "Cola" },
                        new[] {"Beer"   ,"Diapers" },
                        new[] {"Bread"   ,"Eggs" },
                        new[] {"Bread"   ,"Milk" },
                        new[] {"Eggs"   ,"Milk" },
                        new[] {"Diapers"   ,"Milk" },
                        };

            solution = new List<String[]>
                        {
                        new[] {"Beer",   "Cola" ,  "Diapers"},
                        new[] { "Bread",   "Eggs", "Milk" }
                         };
        }

        private void SetUp6()
        {
        }

        [TestMethod]
        public void TestCandidateNull()
        {
            SetUp1();
            candidates = Apriori.GenerateCandidate(input.ElementAt(0), input.ElementAt(1));
            Assert.IsTrue(candidates == null);
            candidates = Apriori.GenerateCandidate(input.ElementAt(0), input.ElementAt(2));
            Assert.IsTrue(candidates == null);
            candidates = Apriori.GenerateCandidate(input.ElementAt(0), input.ElementAt(3));
            Assert.IsTrue(candidates == null);
        }

        [TestMethod]
        public void TestCandidate2x2()
        {
            SetUp2();
            candidates = Apriori.GenerateCandidate(input.ElementAt(0), input.ElementAt(1));
            Assert.IsTrue(candidates != null);
            Assert.IsTrue(candidates.Length == 3);
            Assert.IsTrue(candidates[2] == "Milk");
            candidates = Apriori.GenerateCandidate(input.ElementAt(2), input.ElementAt(3));
            Assert.IsTrue(candidates != null);
            Assert.IsTrue(candidates[1] == "Cola");
            candidates = Apriori.GenerateCandidate(input.ElementAt(0), input.ElementAt(4));
            Assert.IsTrue(candidates != null);
            Assert.IsTrue(candidates[2] == "Eggs");
        }

        [TestMethod]
        public void TestCandidate3x3()
        {
            SetUp3();
            candidates = Apriori.GenerateCandidate(input.ElementAt(0), input.ElementAt(4));
            Assert.IsTrue(candidates == null);
            candidates = Apriori.GenerateCandidate(input.ElementAt(2), input.ElementAt(3));
            Assert.IsTrue(candidates != null);
            Assert.IsTrue(candidates[2] == "Diapers");
            Assert.IsTrue(candidates[3] == "Eggs");
            candidates = Apriori.GenerateCandidate(input.ElementAt(4), input.ElementAt(5));
            Assert.IsTrue(candidates != null);
            Assert.IsTrue(candidates[2] == "Eggs");
            Assert.IsTrue(candidates[3] == "Milk");
        }

        [TestMethod]
        public void TestNextCandidates_Size2()
        {
            SetUp4();
            var a = Apriori.GenerateNextCandidates(input);
            int aux = 0;
            foreach (String[] n in a)
            {
                n.SequenceEqual(solution.ToList().ElementAt(aux));
                aux++;
            }
        }

        [TestMethod]
        public void TestNextCandidates_Size3()
        {
            SetUp5();
            var a = Apriori.GenerateNextCandidates(input);
            int aux = 0;
            foreach (String[] n in a)
            {
                n.SequenceEqual(solution.ToList().ElementAt(aux));
                aux++;
            }
        }





        private void SetUp7()
        {
            input2 = new List<String>() { "Bread", "Milk" };
            solution = new List<String[]> { new[] { "Bread" }, new[] { "Milk" }, new[] { "Bread", "Milk" } };
        }

        private void SetUp8()
        {
            input2 = new List<String>() { "Beer", "Bread", "Milk" };
            solution = new List<String[]> { new[] { "Beer" }, new[] { "Bread" },
            new[] { "Milk" }, new[] { "Beer", "Bread" }, new[] { "Beer", "Milk" },new[] { "Bread", "Milk" },new[]{ "Beer", "Bread", "Milk" }};
        }

        private void SetUp9()
        {
            input2 = new List<String>() { "Beer", "Bread", "Diapers", "Milk" };
            solution = new List<String[]> { new[] { "Beer" },  new[] { "Bread" },new[] { "Diapers" }, new[] { "Milk" },
                new[] { "Beer", "Bread" }, new[] { "Beer", "Diapers" }, new[] { "Beer", "Milk" },
                new[] { "Bread", "Diapers" },new[] { "Bread", "Milk" }, new[] { "Diapers", "Milk" },
                new[] { "Beer", "Bread", "Diapers" }, new[] { "Beer", "Bread", "Milk" },
                new[] { "Beer",  "Diapers" , "Milk" },new[] { "Bread" , "Diapers" , "Milk"},
                new[] {"Beer", "Bread", "Diapers", "Milk"},};

        }

        private void SetUp10()
        {
            candidates = new String[] { "Bread", "Milk", "Eggs", };

            solution = new List<String[]> {
                new[] { "Milk" },  new[] { "Eggs" },new[] { "Nilk","Eggs" }
            };

        }

      
    }
}
