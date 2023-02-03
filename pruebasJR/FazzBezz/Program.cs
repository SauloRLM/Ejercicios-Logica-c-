//hacer un programa que permita mostrar los numeros del  1 al 100 peor 
//en los multiplos de 3 mostrar sau
// y en los de 5 lo
//y en los de ambos saulo

class Solution
{
    public static void Main(string[] args)
    {
        for(int i = 1; i<=100; i++){

            if(i % 15 == 0){
                Console.WriteLine("saulo");
            }else if(i%3 ==0){
                Console.WriteLine("sau");
            }else if(i%5==0){
                Console.WriteLine("lo");
            }else{
                Console.WriteLine(i);
            }


        }
        


    }
}




