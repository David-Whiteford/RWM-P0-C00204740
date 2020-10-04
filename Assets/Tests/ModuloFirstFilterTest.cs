using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ModuloFirstFilterTest
    {
        [Test]
        public void ModuloFirstSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] output = ModuloFirst.ModFirstVals(input);
            int[] expected = { 0, 2, 0, 3, 1, 0, 2, 1, 3, 2 };

            foreach (var o in output)
            {
                Debug.Log(o);
            }

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void ModuloFirstMinusSimple()
        {
            int[] input = { -4, -2, -8, -3, -9, -4, -10, -5, -11,-6 };
            int[] output = ModuloFirst.ModFirstVals(input);
            int[] expected = { -0, -2, -0, -3, -1, -0, -2, -1, -3, -2 };

            foreach (var o in output)
            {
                Debug.Log(o);
            }

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
