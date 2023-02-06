//contador de palabras
using System.Text.RegularExpressions;

//string text = "     un   texto    que   tiene    palabras    ";
//int n = 0;
//text = Regex.Replace(text, @"\s+", " ").Trim(); //para limpiar espacios y una expresion regular

string sentence = "   hello   my  friends  ";
string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);            

//foreach(var element in words){
    //Console.WriteLine(element+"");
//}


string newSentence = string.Join(" ", words);
int lastWordLength = words[words.Length - 1].Length;
Console.WriteLine("Oración sin espacios en exceso: " + newSentence);
Console.WriteLine("Última palabra: " + words[words.Length - 1]);
Console.WriteLine("Longitud de la última palabra: " + lastWordLength);


//var words = text.Split(' ');  //para contar palabras
//n = words.Length;

//Console.WriteLine("Numero de palabras: "+n);
