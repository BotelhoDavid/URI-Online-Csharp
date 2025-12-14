// A tarefa aqui neste problema é ler uma expressão matemática na forma de dois números Racionais (numerador / denominador) e apresentar o resultado da operação. Cada operando ou operador é separado por um espaço em branco. A sequência de cada linha que contém a expressão a ser lida é: número, caractere, número, caractere, número, caractere, número. A resposta deverá ser apresentada e posteriormente simplificada. Deverá então ser apresentado o sinal de igualdade e em seguida a resposta simplificada. No caso de não ser possível uma simplificação, deve ser apresentada a mesma resposta após o sinal de igualdade.

// Considerando N1 e D1 como numerador e denominador da primeira fração, segue a orientação de como deverá ser realizada cada uma das operações:
// Soma: (N1*D2 + N2*D1) / (D1*D2)
// Subtração: (N1*D2 - N2*D1) / (D1*D2)
// Multiplicação: (N1*N2) / (D1*D2)
// Divisão: (N1/D1) / (N2/D2), ou seja (N1*D2)/(N2*D1)

// Entrada
// A entrada contem vários casos de teste. A primeira linha de cada caso de teste contem um inteiro N (1 ≤ N ≤ 1*104), indicando a quantidade de casos de teste que devem ser lidos logo a seguir. Cada caso de teste contém um valor racional X (1 ≤ X ≤ 1000), uma operação (-, +, * ou /) e outro valor racional Y (1 ≤ Y ≤ 1000).

// Saída
// A saída consiste em um valor racional, seguido de um sinal de igualdade e outro valor racional, que é a simplificação do primeiro valor. No caso do primeiro valor não poder ser simplificado, o mesmo deve ser repetido após o sinal de igualdade.

using System;
using System.Text.RegularExpressions;
using System.Numerics;
using System.Linq;

class URI {
  
  public static void Main()
	{
		int cases = int.Parse(Console.ReadLine());
		int counter = 0;
		
		while( counter < cases){
			string entry = Console.ReadLine();
			
			var numbers = Regex.Split(entry, @"\D+")
                     		   .Where(s => !string.IsNullOrWhiteSpace(s))
                     		   .Select(int.Parse)
                     		   .ToArray();;
			
			var _operator = Regex.Match(entry, @"[+\-*]").Value;
			
			int numerator1 = 0;
			int denominator1 = numbers[1]*numbers[3];
			
			switch(_operator){
				case "+":
					numerator1 = numbers[0]*numbers[3]+ numbers[2]*numbers[1];
					break;
				case "-":
					numerator1 = numbers[0]*numbers[3] - numbers[2]*numbers[1] ;
					break;
				case "*":
					numerator1 = numbers[0]*numbers[2];
					break;
  				default:
					numerator1 = numbers[0]*numbers[3];
					denominator1 = numbers[2]*numbers[1];
    				break;					
			}
			
			var mdc = BigInteger.GreatestCommonDivisor(numerator1, denominator1);

			int numerator2 = numerator1/ (int)mdc;
			int denominator2 =  denominator1/ (int)mdc;
			
			Console.WriteLine($"{numerator1}/{denominator1} = {numerator2}/{denominator2}");
			
			counter++;
		}
	}
}
