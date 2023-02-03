//contar caracteres repetidos en una cadena
Console.WriteLine("introduce una palabra:");
string text = Console.ReadLine();
Console.WriteLine("introduce el caracter a buscar:");
//obtener un dato 
string character = Console.ReadLine();

//volver variable a un arreglo de caracteres
char[] chars = character.ToCharArray();

//normal
int num = 0;
foreach(var c in text){
    if(c==chars[0])
        num++;
}

//pro
int n = text.Where(c=> c == chars[0]).Count();


//imprimir el resultado
Console.WriteLine($"se repite la letra {chars[0]} {num} {n} veces.");
