//Distancia de hamming

int distance = 0;

Console.WriteLine("introduce la primera palabra:");
string text1 = Console.ReadLine();

Console.WriteLine("introduce la segunda palabra:");
string text2 = Console.ReadLine();


//verificar que las palabras midan lo mismo
if(text1.Length != text2.Length)
    throw new Exception("Longitudes distintas");

for(int i = 0; i < text1.Length; i++){
    if(text1[i]!= text2[i])
        distance++;
}

Console.WriteLine("Distancia es de: "+distance);