
//invertir una cadena
string textResult = "";
Console.WriteLine("introduce una palabra:");
string text = Console.ReadLine();

//normal ------------------------------------
/*
    for (int i = text.Length-1; i>=0; i--)
{
    textResult += text[i];
} 
 */
 

//pro
char[] chars = text.ToCharArray();
Array.Reverse(chars);
textResult = new string(chars);

Console.WriteLine(textResult);
