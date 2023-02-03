//5 contar numeros
using System.Text.RegularExpressions;

string text = "an1298jq???da°22121230001masA";
string pattern = @"[0-9]"; //para numeros
//string pattern = @"[a-zA-Z]";//para letras

var regex = new Regex(pattern);
int n = regex.Matches(text).Count();

Console.WriteLine("Numero de Numeros: "+ n);



