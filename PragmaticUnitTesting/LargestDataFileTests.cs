using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Microsoft.SqlServer.Server;
using System.IO;

namespace PragmaticUnitTesting
{
    [TestFixture]
    public class LargestDataFileTests
    {
        private int[] getNumberList(string line)
        {
            string[] tokens = line.Split();
            List<int> numbList = new List<int>();
            for (int i = 0; i < tokens.Length; i++)
            {
                numbList.Add(Int32.Parse(tokens[i]));
            }
            return numbList.ToArray();
        }

        private int getLargestNumber(string line)
        {
            string[] tokens = line.Split(null);
            string val = tokens[0];
            int expected = Int32.Parse(val);
            return expected;
        }

        private bool hasComment(string line)
        {
            return line.StartsWith("#");
        }

        [Test]
        public void FromFile()
        {
            string line;

            StreamReader reader = new StreamReader("../../testdata.txt");
            while ((line = reader.ReadLine())!= null)
            {
                if (hasComment(line))
                {
                    continue;
                }

                int[] numberListForLine = getNumberList(line);
                int expectedLargestNumber = getLargestNumber(line);
                int actualLargestNumber = Cmp.Largest(numberListForLine);
                Assert.That(expectedLargestNumber, Is.EqualTo(actualLargestNumber));
            }
        }

    }
}

