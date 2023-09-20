using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;

using System;

namespace Challenges;
public class PlusMinus
{
     /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
    float noOfPositive = 0;
    float noOfNegative = 0;
    float noOfZero = 0;
    
    float length = arr.Count;
    
    for(var i = 0; i < arr.Count; i++){
    if(arr[i] > 0)
        noOfPositive++;
    else if(arr[i] == 0)
        noOfZero++;
    else
        noOfNegative++;
    
    }
    
    Console.WriteLine($"{string.Format("{0:N6}", noOfPositive/length)}\n{string.Format("{0:N6}", noOfNegative/length)}\n{string.Format("{0:N6}", noOfZero/length)}");

    }

}
// class Solution
// {
//     public static void Main(string[] args)
//     {
//         int n = Convert.ToInt32(Console.ReadLine().Trim());

//         List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//         PlusMinus.plusMinus(arr);
//     }
//}
