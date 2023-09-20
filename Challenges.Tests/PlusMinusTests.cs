using NUnit.Framework;
using Challenges;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System;
using System.IO;

namespace Challenges.Tests;

public class PlusMinusTests
{

    [TestCaseSource(nameof(arrCases))]
    public void TestArrPlusMinus(List<int> arr, string expected)
    {
       
        //List<int> arr=new List<int>(){1,1,0,-1,-1};
        StringWriter sw = new StringWriter();
        Console.SetOut(sw);
        Challenges.PlusMinus.plusMinus(arr);

        // string expected = $"0.400000\n0.400000\n0.200000\r\n";
        Assert.AreEqual(expected, sw.ToString());
   

    }
    [Test]
     public void TestPlusMinus()
    {
       
        List<int> arr=new List<int>(){1,1,0,-1,-1};
        StringWriter sw = new StringWriter();
        Console.SetOut(sw);
        
        Challenges.PlusMinus.plusMinus(arr);

        string expected = $"0.400000\n0.400000\n0.200000\r\n";
        Assert.AreEqual(expected, sw.ToString());
   

    }
     public static object[] arrCases =
    {
        new object[] {new List<int>() { 1,1,0,-1,-1 },$"0.400000\n0.400000\n0.200000\r\n"},
        new object[] {new List<int>() {-4,3,-9,0,4,1},$"0.500000\n0.333333\n0.166667\r\n"},
        new object[] {new List<int>() {1,2,3,-1,-2,-3,0,0},$"0.375000\n0.375000\n0.250000\r\n"},

    };
}
