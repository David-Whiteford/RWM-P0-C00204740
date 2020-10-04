using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuloFirst 
{
    public static int ModFirst(int x,int n)
    {
        return x % n;
    }
    public static int[] ModFirstVals(int[] xs)
    {
        int[] result = new int[xs.Length];
        int first = xs[0];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = ModFirst(xs[i], first);
        }
        return result;
    }
}
