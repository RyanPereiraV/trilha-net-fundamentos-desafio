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
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
            Console.WriteLine("\nO veiculo foi cadastrado com sucesso!!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {  

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = 0;
                decimal valorTotal = 0;

                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa);
                Console.Clear();

                Console.WriteLine($"O veículo de placa: {placa}, foi REMOVIDO, permanecendo por {horas}:00 horas no estacionamento, o preço total foi de: R$ {valorTotal},00");
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
                Console.WriteLine("Os veículos estacionados são:");
  
                int contador = 1;
                foreach(string veiculosEstacionados in veiculos )
                {
                    Console.WriteLine($"N°{contador} - Placa: {veiculosEstacionados}");
                    contador++;
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
