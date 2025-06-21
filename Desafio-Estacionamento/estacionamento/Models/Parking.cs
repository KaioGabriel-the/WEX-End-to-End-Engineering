using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamento.Models
{
    public class Parking
    {
        private decimal stargingPrice;
        private decimal perHour;
        private List<Vehicle> listVehicle;

        public Parking(decimal stargingPrice, decimal perHour)
        {
            this.stargingPrice = stargingPrice;
            this.perHour = perHour;
            this.listVehicle = new List<Vehicle>();
        }

        public void addVehicle(string plate)
        {
            Vehicle vehicle = new Vehicle(plate);
            listVehicle.Add(vehicle);
            Console.WriteLine("Veiculo adicionado com sucesso");
        }

        public void removeVehicle(string plate)
        {
            Vehicle vehicle = null;

            foreach (var item in listVehicle)
            {
                if (item.plate.ToLower() == plate.ToLower())
                {
                    vehicle = item;
                }
            }

            if (vehicle != null)
            {
                Console.WriteLine("Digite a quantidade de horas que o veiculo ficou estacionado: ");
                int quanntity = Convert.ToInt32(Console.ReadLine());
                calculateValuePerHour(quanntity);
                listVehicle.Remove(vehicle);
                Console.WriteLine("Veiculo removido com sucesso");
            }
            else
            {
                Console.WriteLine("Veiculo não está no nosso estacionamento");
            }
        }

        public void showVehicle()
        {
            if (listVehicle != null && listVehicle.Any())
            {
                int counter = 0;
                foreach (var item in listVehicle)
                {
                    Console.WriteLine("" + counter + " - Carro -> " + item.plate);
                }
            }
            else
            {
                Console.WriteLine("Não tem nenhum carro no estacionamento");
            }
        }

        private void calculateValuePerHour(int quanntity)
        {
            decimal valueFinal = stargingPrice + (perHour * Convert.ToDecimal(quanntity));
            Console.WriteLine("O valor do pagamento final é R$ " + valueFinal);
        }
    }
}