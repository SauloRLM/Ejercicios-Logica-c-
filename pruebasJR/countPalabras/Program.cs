//contador de palabras
using System.Text.RegularExpressions;

string text = "     un   texto    que   tiene    palabras    ";
int n = 0;
text = Regex.Replace(text, @"\s+", " ").Trim(); //para limpiar espacios y una expresion regular
var words = text.Split(' ');  //para contar palabras
n = words.Length;

Console.WriteLine("Numero de palabras: "+n);
