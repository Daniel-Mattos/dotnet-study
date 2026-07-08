namespace MeuTeste
{
	public class Estacionamento
	{
		public static void Executar()
		{
			bool next = true;
			List<string> placas = [];

			do
			{
				Console.Clear();

				Console.WriteLine("--- SISTEMA DE ESTACIONAMENTO ---");
				Console.WriteLine("1 - Cadastrar veículo");
				Console.WriteLine("2 - Remover veículo");
				Console.WriteLine("3 - Listar veículo");
				Console.WriteLine("4 - Encerrar");
				Console.Write("Escolha uma opção: ");

				if (!int.TryParse(Console.ReadLine(), out int opcao))
				{
					opcao = 0;
				}

				switch (opcao)
				{
					case 1:
						Console.Write("\nDigite a placa do veículo para adicionar: ");
						string placa = (Console.ReadLine() ?? "").ToUpper().Trim();

						if (!string.IsNullOrEmpty(placa))
						{
							placas.Add(placa);
							Console.WriteLine($"\nVeículo de placa {placa} cadastrado com sucesso!");
						}
						break;

					case 2:
						Console.Write("\nDigite a placa do veículo para remover: ");
						string remover = (Console.ReadLine() ?? "").ToUpper().Trim();

						if (placas.Remove(remover))
						{
							Console.Write("Digite quantas horas ficou no estacionamento: ");

							if (!int.TryParse(Console.ReadLine(), out int hora))
							{
								Console.WriteLine("Valor inválido digitado para horas! Será cobrado o valor mínimo de 1 hora.");
								hora = 1;
							}

							int valor = hora * 10;
							Console.WriteLine($"\nDeve pagar: R${valor},00");
							Console.WriteLine($"A placa {remover} foi removida com sucesso!");
						}
						else
						{
							Console.WriteLine($"\nA placa {remover} não foi encontrada no sistema.");
						}
						break;

					case 3:
						Console.WriteLine("\n- LISTA DE VEÍCULOS -");
						if (placas.Count == 0)
						{
							Console.WriteLine("Não há veículos estacionados.");
						}
						else
						{
							foreach (string p in placas)
							{
								Console.WriteLine($"- {p}");
							}
						}
						break;

					case 4:
						next = false;
						Console.WriteLine("\nEncerrando o sistema. Até logo!");
						break;

					default:
						Console.WriteLine("\nOpção inválida! Escolha um número de 1 a 4.");
						break;
				}

				if (next)
				{
					Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
					Console.ReadKey();
				}

			} while (next);

			Console.Clear();
		}
	}
}