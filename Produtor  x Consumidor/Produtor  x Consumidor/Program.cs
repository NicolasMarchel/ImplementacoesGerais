using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Produtor__x_Consumidor
{
	

	class Program
	{
		private static readonly Object Objeto = new Object();
		//variável que controla a sincronização das threads produtor e consumidor

		private static char[] Buffer = new char[40];

		private static int IndiceConsumidor = 1;
		//Variável usada para controlar o índice do consumidor
		private static int IndiceProdutor = 1;
	    //Variável usada para controlar o índice do produtor
		private static int ContElementos = 0;
		//Variável usada para controlar a quantidade de valores no buffer

		private static Thread ThreadConsumidor = new Thread(Consumidor);
		private static Thread ThreadProdutor = new Thread(Produtor);

		static void Main(string[] args)
		{
			DesenhaVetor();
			ThreadProdutor.Start();
			Thread.Sleep(300);
			//Faz com que a thread produtor seja executada primeiro
			ThreadConsumidor.Start();
			ThreadProdutor.Join();
			ThreadConsumidor.Join();



		}
		static void Consumidor()
		{
			while (true)
			{
				lock (Objeto)
				{
					////Apaga o C da posição anterior
					Console.ForegroundColor = ConsoleColor.Black;
					Console.SetCursorPosition(IndiceConsumidor * 2 - 2, 4);
					Console.Write(".");
					////
					///Apaga o retângulo da posição anterior
					Console.ForegroundColor = ConsoleColor.Black;
					Console.SetCursorPosition(IndiceConsumidor * 2 - 2, 6);
					Console.Write((char)9608);
					///
					////Adiciona o C Acima da posição de Remoção atual
					Console.ForegroundColor = ConsoleColor.White;
					Console.SetCursorPosition(IndiceConsumidor * 2, 4);
					Console.Write("C");
					////
					///Adiciona um retângulo abaixo da posição de remoção
					Console.SetCursorPosition(IndiceConsumidor * 2, 6);
					Console.Write((char)9608);
					///	

					//A thread Consumidor só caminha no buffer se houver ao menos um elemento
					if (ContElementos > 0)
					{
						//Sem passar uma char esse método apaga o caractere no indice passado
						Entrada(IndiceConsumidor - 1);

						ContElementos--;

						IndiceConsumidor++;

					}

				
					//Reinicia a contagem do IndiceConsumidor
					if (IndiceConsumidor == 41)
					{
						////Apaga o C da posição 40
						Thread.Sleep(200);
						Console.ForegroundColor = ConsoleColor.Black;
						Console.SetCursorPosition((IndiceConsumidor - 1) * 2, 4);
						Console.WriteLine(".");
						////
						///Apaga o retângulo da posição 40
						Console.ForegroundColor = ConsoleColor.Black;
						Console.SetCursorPosition((IndiceConsumidor - 1) * 2, 6);
						Console.WriteLine((char)9608);
						///

						IndiceConsumidor = 1;

					}
					//Faz com que o cursor sempre fique na posição de inserção ao final da remoção
					Console.SetCursorPosition(IndiceProdutor * 2, 6);
				}
				//Faz com que a remoção ocorra em intervalos de 600 (ms)
				Thread.Sleep(600);
			}

		}
		static void Produtor()
		{
			//Valor padrão  que o Construtor do C# atribui a uma char vazio.
			char x ='\0';

			//A inserção ocorre enquanto houver posições disponíveis
			while (ContElementos < 40)
			{
				////Apaga o P da coluna anterior
				Console.ForegroundColor = ConsoleColor.Black;
				Console.SetCursorPosition(IndiceProdutor * 2 - 2, 8);
				Console.WriteLine((char)184);
				////


				////Adiciona o P abaixo da posição de inserção atual
				Console.ForegroundColor = ConsoleColor.White;
				Console.SetCursorPosition(IndiceProdutor * 2, 8);
				Console.WriteLine("P");
				////

				//Seleciona a posição de inserção atual
				Console.SetCursorPosition(IndiceProdutor * 2, 6);
				try
				{
					x = char.Parse(Console.ReadLine());
				}
				catch (FormatException)
				{
					Console.SetCursorPosition(1, 9);
					Console.Write("Entrada inválida!");
					Thread.Sleep(300);
					Console.ForegroundColor = ConsoleColor.Black;
					Console.SetCursorPosition(1, 9);
					Console.Write("Entrada inválida!");
					Console.ForegroundColor = ConsoleColor.White;
				}
				catch(Exception)
				{
					Console.SetCursorPosition(1, 9);
					Console.Write("Erro!");
					Thread.Sleep(300);
					Console.ForegroundColor = ConsoleColor.Black;
					Console.SetCursorPosition(1, 9);
					Console.Write("Erro!");
					Console.ForegroundColor = ConsoleColor.White;
				}
			

				lock (Objeto)
				{

					Entrada(IndiceProdutor - 1, x);

					ContElementos++;

					IndiceProdutor++;

					//Quando chegar na Última posição, recomeça
					if (IndiceProdutor == 41)
					{
						////Apaga o P da coluna 40
						Console.ForegroundColor = ConsoleColor.Black;
						Console.SetCursorPosition((IndiceProdutor - 1) * 2, 8);
						Console.WriteLine((char)184);
						////
						IndiceProdutor = 1;

					}

				}
				
				//Verifica se a próxima posição pode ser utilizada, se não puder, é feito a troca para a thread consumidor. 
				if (IndiceProdutor == IndiceConsumidor)
				{
					Console.SetCursorPosition(1, 9);
					Console.Write("Fila Cheia, Aguarde...");
					Thread.Sleep(200);
					Console.ForegroundColor = ConsoleColor.Black;
					Console.SetCursorPosition(1, 9);
					Console.Write("Fila Cheia, Aguarde...");
					Console.ForegroundColor = ConsoleColor.White;
				}
			}
		}

		static void DesenhaVetor(int Tamanho = 40)
		{

			Console.SetCursorPosition(1, 1);
			Console.Write("Tempo do consumidor:  600 (ms)");
			int col = 1;

			// O vetor tera 40 posições e as imagens ocupam 41 colunas.Portanto, o while
			//deve continuar enquanto for menor que a soma de posições do vetor e colunas utilizadas mais um(82). 
			while (col < (Tamanho + Tamanho + 2))
			{
				if (col == 1)
				{
					Console.SetCursorPosition(col, 5);
					Console.Write((char)9555);
					Console.SetCursorPosition(col, 6);
					Console.Write((char)9553);
					Console.SetCursorPosition(col, 7);
					Console.Write((char)9561);
					col++;
				}
				else
				{
					// O índice da coluna é sempre o pos 
					if (col == (Tamanho + Tamanho + 1))
					{

						Console.SetCursorPosition(col, 5);
						Console.Write((char)9557);
						Console.SetCursorPosition(col, 6);
						Console.Write((char)9553);
						Console.SetCursorPosition(col, 7);
						Console.Write((char)9564);

					}
					else
					{
						if (col % 2 == 0)
						{

							Console.SetCursorPosition(col, 5);
							Console.Write((char)9552);
							Console.SetCursorPosition(col, 7);
							Console.Write((char)9552);

						}
						else
						{
							Console.SetCursorPosition(col, 5);
							Console.Write((char)9574);
							Console.SetCursorPosition(col, 6);
							Console.Write((char)9553);
							Console.SetCursorPosition(col, 7);
							Console.Write((char)9575);


						}


					}


					col++;
				}
			}


			Console.SetCursorPosition(1, 10);

			Console.WriteLine("Para não fazer entrada - espaço");
			Console.SetCursorPosition(1, 11);
			Console.WriteLine("Para confirmar entrada - Enter");


		}

	
		
		//O método Entrada controla tanto a entrada, quanto a saída de valores no buffer.
		//Se não for passado argumento, o x se torna '\0'. O valor padrão 
		//que o Construtor do C# atribui a uma char vazio. Portanto, ele está removendo o item!

		static void Entrada(int Pos, char X = '\0')
		{
			Buffer[Pos] = X;
		}
	}
}
