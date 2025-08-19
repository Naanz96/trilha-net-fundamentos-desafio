namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTADO*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(placa))
            {
                veiculos.Add(placa.ToUpper());
                Console.WriteLine($"Veículo {placa} estacionado com sucesso.");
            }
            else
            {
                Console.WriteLine("Placa inválida. Tente novamente.");
            }
           
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTADO*
            string placa = Console.ReadLine()?.ToUpper();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                if (int.TryParse(Console.ReadLine(), out int horas))
                {
                    decimal valorTotal = precoInicial + (precoPorHora * horas);
                    veiculos.Remove(placa);
                    Console.WriteLine($"O veículo {placa} foi removido e preço total foi de: R${valorTotal:0.00}");
                }

                else
                {
                    Console.WriteLine("Quantidade de horas inválida. Tente novamente.");
                }
                    }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui.Confira se digitou a placa corretamente");
                }    
                }

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                
                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTADO*

                

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"- {veiculo}");
                }
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTADO*
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
