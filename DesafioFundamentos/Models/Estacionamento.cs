
namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<string> veiculos;

       
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            this.veiculos = new List<string>();
        }

        public void AdicionarVeiculo()
        {
            //implementado

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine($"Veículo com placa {placa} adicionado com sucesso.");
        }

        public void RemoverVeiculo()
        {
            //implementado

            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                //implementado
                if (int.TryParse(Console.ReadLine(), out int horas) && horas >= 0)
                {
                    decimal valorTotal = precoInicial + precoPorHora * horas;
                    
                    
                    veiculos.Remove(placa);
                    
                    //implementado 

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total é: R$ {valorTotal:F2}");
                }
                else
                {
                    Console.WriteLine("Quantidade de horas inválida. Por favor, insira um número inteiro não negativo.");
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                //implementado

                Console.WriteLine("Os veículos estacionados são:");
                
                
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
