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

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {        
        int hora = int.Parse(s.Substring(0,2));        
        string tipoPMoAM = s.Substring(8,2);        
        
        if(tipoPMoAM == "PM" && hora !=12){

            hora += 12;            
            
        }else if(tipoPMoAM == "AM" && hora == 12){
            hora = 0;
        }
        
        string Result = hora.ToString().PadLeft(2,'0')+ s.Substring(2,6);

        return Result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        
        //12:00:01PM

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        Console.WriteLine(result);

        
    }
}
