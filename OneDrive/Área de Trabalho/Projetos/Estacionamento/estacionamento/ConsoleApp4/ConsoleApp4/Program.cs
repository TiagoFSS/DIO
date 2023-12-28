using System;
using System.Collections.Generic;

namespace Estacionamento
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoHora;
        private List<string> veiculos;

        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
            this.veiculos = new List<string>();
        }

        public void AdicionaVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine("Veículo cadastrado com sucesso!");
        }

        public void RemoveVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo que deseja remover:");
            string placa = Console.ReadLine();

            if (veiculos.Contains(placa))
            {
                Console.WriteLine("Digite o tempo gasto no estacionamento:");
                decimal horasEstacionadas = decimal.Parse(Console.ReadLine());

                decimal precoFinal = precoInicial + (horasEstacionadas * precoHora);
                Console.WriteLine($"Preço final: {precoFinal}");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado na lista.");
            }
        }

        public void ListarVeiculos()
        {
            Console.WriteLine($"O estacionamento tem {veiculos.Count} veículos:");

            foreach (var veiculo in veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            decimal precoInicial = 6;
            decimal precoHora = 2;
            Console.WriteLine("Seja bem vindo!  ");
            Estacionamento es = new Estacionamento(precoInicial, precoHora);

            string opcao = string.Empty;
            bool exibirMenu = true;

            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        es.AdicionaVeiculo();
                        break;

                    case "2":
                        es.RemoveVeiculo();
                        break;

                    case "3":
                        es.ListarVeiculos();
                        break;

                    case "4":
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            }

            Console.WriteLine("O programa se encerrou");
        }
    }
}
