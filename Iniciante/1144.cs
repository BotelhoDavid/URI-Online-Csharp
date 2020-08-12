// Escreva um programa que leia um valor inteiro N. N * 2 linhas de saída serão apresentadas na execução do programa, seguindo a lógica do exemplo abaixo. Para valores com mais de 6 dígitos, todos os dígitos devem ser apresentados.

// Entrada
// O arquivo de entrada contém um número inteiro positivo N (1 < N < 1000).

// Saída
// Imprima a saída conforme o exemplo fornecido.

// Exemplo de Entrada	|   Exemplo de Saída
//        5            |      1 1 1
//                     |      1 2 2
//                     |      2 4 8
//                     |      2 5 9
//                     |      3 9 27
//                     |      3 10 28
//                     |      4 16 64
//                     |      4 17 65
//                     |      5 25 125
//                     |      5 26 126

using System; 

class URI {

    static void Main(string[] args) {
            int _numb = int.Parse(Console.ReadLine());
            int j = 0;

            for (int i = 1; i <= _numb; i++)
            {
                j = i * i;
                Console.WriteLine($"{i} {j} {i*j}");
                Console.WriteLine($"{i} {j+1} {i*j+1}");

            }
        }

}