using System;
using estacionamento.Models;

class Program
{
    static void Main(string[] args)
    {
        // Coloca o encoding para UTF8 para exibir acentuação
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Seja bem-vindo ao sistema de estacionamento \n");
        Console.WriteLine("Digite o preço inicial: ");
        decimal startingPrice = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Digite o preço por hora: ");
        decimal perHour = Convert.ToDecimal(Console.ReadLine());

        Parking parking = new Parking(startingPrice, perHour);

        string menu = "----- Menu ----- \n" +
        "1 - Cadastrar veiculo; \n" +
        "2 - Remover veiculo; \n" +
        "3 - Listar veiculo; \n" +
        "4 - Sair \n" +
        "Digite a opção que deseja: ";
        bool spin = true;
        do
        {
            Console.WriteLine(menu);
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Digite a placa do veiculo: ");
                    string plate = Console.ReadLine();
                    parking.addVehicle(plate);
                    break;
                case 2:
                    Console.WriteLine("Digite a placa do veiculo: ");
                    plate = Console.ReadLine();
                    parking.removeVehicle(plate);
                    break;
                case 3:
                    parking.showVehicle();
                    break;
                case 4:
                    spin = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadLine();
            Console.Clear();
        } while (spin);

        Console.WriteLine("O programa se encerrou");
    }
}