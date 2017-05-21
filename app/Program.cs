using System;
using System.Linq;

namespace app
{
    class Program
    {

        static void Main(string[] args)
        {
            //1.
            //pra contar o número de vírgulas
            Console.WriteLine("pra contar o número de vírgulas usando for");
            string s = "123,456,789";
            int contador = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ',')
                    contador++;
            }
            Console.WriteLine(contador.ToString());
            Console.WriteLine("\n");
            //2.
            //em LINQ
            Console.WriteLine("pra contar o número de vírgulas em LINQ");
            string string1 = "123,456,789";
            int contador1 = string1.Count(_ => _ == ',');
            Console.WriteLine(contador1.ToString());
            Console.WriteLine("\n");
            //3.
            //
            Console.WriteLine("conta usando where e count LINQ");
            string string2 = "123,456,789";
            int contador2 = string2.Where(_ => _ == ',').Count();
            Console.WriteLine(contador2.ToString());
            Console.WriteLine("\n");
            //4.
            //mostra as vírgulas retiradas
            Console.WriteLine("mostra as vírgulas retiradas");
            string string3 = "123,456,789";
            var lista = string3.Where(_ => _ == ',');
            foreach (var item in lista)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("\n");
            //5.
            //retorna o maior número que 3 da lista
            Console.WriteLine("retorna o maior número que 3 da lista");
            int[] array1 = { 1, 2, 3, 4, 5 };
            foreach (var item in array1.Where(_ => _ > 3))
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("\n");
            //6.
            //multiplica todos os items por 2
            Console.WriteLine("multiplica todos os items por 2");
            int[] array2 = { 1, 2, 3, 4, 5 };
            foreach (var item in array2.Select(_ => _ * 2))
            {
                Console.Write(item.ToString());
            }
            Console.WriteLine("\n");
            //7.
            //retorna a qtde dos números maiores ou iguais a 3 depois de multiplicados por 2
            Console.WriteLine("retorna a qtde dos números maiores ou iguais a 3 depois de multiplicados por 2");
            int[] array3 = { 1, 2, 3, 4, 5 };
            int contador4 = array3.Where(_ => _ >= 3).Select(_ => _ * 2).Count();
            Console.WriteLine(contador4);
            Console.WriteLine("\n");
            //8.
            //retorna todos da lista
            Console.WriteLine("retorna todos da lista");
            int[] array5 = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < array5.Length; i++)
            {
                Console.Write(array5[i].ToString());
            }
            Console.WriteLine("\n");
            //9.
            //retorna todos da lista
            Console.WriteLine("retorna todos da lista");
            int[] array6 = { 1, 2, 3, 4, 5 };
            foreach (var x in array6)
            {
                Console.Write(x.ToString());
            }
            Console.WriteLine("\n");
            //10.
            //retorna todos da lista LINQ
            Console.WriteLine("retorna todos da lista LINQ");
            int[] array7 = { 1, 2, 3, 4, 5 };
            array7.Count(_ => { Console.Write(_.ToString()); return true; });
            Console.WriteLine("\n");
            //11.
            //conta os itens da lista, se true 5, se false 0
            Console.WriteLine("conta os itens da lista, se true 5, se false 0");
            int[] array8 = { 1, 2, 3, 4, 5 };
            int contador5 = array8.Count(_ => { return true; });
            Console.WriteLine(contador5.ToString());
            Console.WriteLine("\n");
            //12.
            //se retirar o count do final não funciona
            Console.WriteLine("se retirar o count do final não funciona");
            int[] array9 = { 1, 2, 3, 4, 5 };
            array9.Where(x =>
            {
                Console.WriteLine(x.ToString());
                return true;
            }).Count();
            Console.WriteLine("\n");
            //13.
            //pula os 2 primeiros e pega os 2 seguintes
            Console.WriteLine("pula os 2 primeiros e pega os 2 seguintes");
            int[] array10 = { 1, 2, 3, 4, 5 };
            array10.Skip(2).Take(2).Count(x => { Console.WriteLine(x.ToString()); return true; });
            Console.WriteLine("\n");
            //14.
            //pula os 2 primeiros e retorna os 2 seguintes * 2
            Console.WriteLine("pula os 2 primeiros e retorna os 2 seguintes * 2");
            int[] array11 = { 1, 2, 3, 4, 5 };
            array11.Skip(2).Take(2).Select(x => x * 2).Count(x => { Console.WriteLine(x.ToString()); return true; });
            Console.WriteLine("\n");
            //15.
            //retorna todos os numeros do array
            Console.WriteLine("retorna todos os numeros do array");
            int[] array12 = { 1, 2, 3, 4, 5 };
            Array.ForEach(array12, (x => { Console.WriteLine(x.ToString()); }));
            Console.WriteLine("\n");
            //16.
            //retorna o primeiro da lista
            Console.WriteLine("retorna o primeiro da lista");
            int[] array13 = { 1, 2, 3, 4, 5 };
            int value = array13.First();
            Console.WriteLine(value.ToString());
            Console.WriteLine("\n");
            //17.
            //retorna o primeiro da lista maior que 3
            Console.WriteLine("retorna o primeiro da lista maior que 3");
            int[] array14 = { 1, 2, 3, 4, 5 };
            int value1 = array14.First(x => x > 3);
            Console.WriteLine(value1.ToString());
            Console.WriteLine("\n");
            //
            Console.WriteLine("retorna 0 caso int ou null se string se nenhum da lista for encontrado");
            int[] array17 = { 1, 2, 3, 4, 5 };
            int value4 = array17.FirstOrDefault(x => x > 100);
            Console.WriteLine(value4.ToString());
            Console.WriteLine("\n");
            string[] array0 = { "123" };
            string obj = array0.FirstOrDefault(x => x.Equals(""));
            Console.WriteLine("null= " + obj);
            Console.WriteLine("\n");
            //18.
            //retorna o ultimo e  da lista maior que 2 e menor que 4
            Console.WriteLine("retorna o ultimo e  da lista maior que 2 e menor que 4");
            int[] array15 = { 1, 2, 3, 4, 5 };
            int value3 = array15.Last();
            int value2 = array15.Last(x => 4 > x && x > 1);
            Console.WriteLine(value3.ToString() + "\n" + value2.ToString());
            Console.WriteLine("\n");
            //19.
            //retorna o ultimo e  da lista maior que 2 e menor que 4
            Console.WriteLine("soma a=1+b=2 e a recebe soma de a+b e soma b=3 e assim sucessivamente");
            int[] array16 = { 111, 2, 43, 784, 51 };
            int value5 = array16.Aggregate((a, b) => a + b);
            Console.WriteLine(value5.ToString());
            Console.WriteLine("\n");
            int soma = array16.Aggregate((a, b) =>
            {
                Console.WriteLine(a.ToString() + "+" + b.ToString());
                return a + b;
            });
            Console.WriteLine(soma);
            //
            //compara o 1o a e o 2o b da lista e o maior vai para a e compara com 3o b...
            Console.WriteLine("\n");
            int maior = array16.Aggregate((a, b) => a > b ? a : b);
            Console.WriteLine(maior);
            Console.WriteLine("\n");
            int menor = array16.Aggregate((a, b) => a < b ? a : b);
            Console.WriteLine(menor);
            Console.WriteLine("\n");
            //
            //
            Console.WriteLine("soma a=1+b=2 e a recebe soma de a+b e soma b=3 e assim sucessivamente");
            Func<int, int, int> soma2;
            soma2 = (a, b) => { return a + b; };
            int soma1 = array16.Aggregate(soma2);
            Console.WriteLine(soma1);
            Console.WriteLine("\n");
            Console.WriteLine("arrays max, min...");
            Console.WriteLine("max " + array16.Max());
            Console.WriteLine("min " + array16.Min());
            Console.WriteLine("soma" + array16.Sum());
            Console.WriteLine("avg " + array16.Average());
            Console.WriteLine("\n");
            //
            //junta as strings
            Console.WriteLine("?Junta todas as strings");
            string[] array19 = { "a", "b", "c" };
            Console.WriteLine(string.Join(" and ", array19));
            //
            Func<string, string, string> soma4 = (a, b) => { return a + b; };
            Func<string, string, string> soma3 = (a, b) => { return a + " + " + b; };
            string[] array18 = { "a", "b", "c" };
            string result = array18.Aggregate(soma4);
            Console.WriteLine(result);
            string result1 = array18.Aggregate(soma3);
            Console.WriteLine(result1);




            Console.ReadLine();
        }
    }
}
