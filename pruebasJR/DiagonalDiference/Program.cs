//programa para ver la diferncia de una diagonal

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

class Result
{   

    public static int diagonalDifference(List<List<int>> arr)
    {        
       int tamMatriz = arr.Count;
        int diag1 = 0;
        int diag2 = 0;        
        for(int i = 0; i<tamMatriz;i++ ){            
            for(int j = 0; j<tamMatriz;j++ ){                                                                

                  if(i == j){
                    diag1 += arr[i][j];
                }                                                                                                
                if(i == tamMatriz-1-j){
                    diag2 += arr[i][j];
                }
                /**/
                
            }                                    
        }
        int res = Math.Abs(diag1 - diag2);
        return res;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        
        /*
        3
        11 2 4
        4 5 6
        10 8 -12
        */

        List<List<int>> arr = new List<List<int>>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            List<int> row = new List<int>(Console.ReadLine().Split(' ').Select(a => int.Parse(a)));
            arr.Add(row);
        }
                
        int result = Result.diagonalDifference(arr);                

        Console.WriteLine(result);
 
    }
}


