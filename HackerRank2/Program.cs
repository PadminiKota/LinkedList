using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr)
    {

        int[] output = new int[20];
        int temp = 0;
        int ic = 0;
        int result = 0;
        for (int row = 0; row < arr.Length - 2; row++)
        {
            for (int col = 0; col < arr.Length - 2; col++)
            {

                temp = arr[row][col] + arr[row][col + 1] + arr[row][col + 2] +
                                  arr[row + 1][col + 1] +
                                  arr[row + 2][col] + arr[row + 2][col + 1] + arr[row + 2][col + 2];
                output[ic] = temp;
                ic++;

            }
        }
        result = output.Max();
        return result;


    }

    static void Main(string[] args)
    {
       //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
