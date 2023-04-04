namespace Aula02Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
            // A fórmula da conversão é F = (9 * C + 160) / 5.

            // Declaração de duas variáveis do tipo double.
            double temperaturaCelsius, temperaturaFahrenheit;

            // Exibe uma mensagem na tela para o usuário.
            Console.Write("Digite a temperatura em graus Celsius: ");

            // Lê a entrada do usuário como uma string, converte para double e armazena na variável temperaturaCelsius.
            temperaturaCelsius = double.Parse(Console.ReadLine());

            // Calcula a temperatura em Fahrenheit usando a fórmula dada e armazena na variável temperaturaFahrenheit.
            temperaturaFahrenheit = (9 * temperaturaCelsius + 160) / 5;

            // Exibe a temperatura em Fahrenheit para o usuário.
            Console.WriteLine("A temperatura convertida para Fahrenheit é: " + temperaturaFahrenheit + "°F"); 
        }
    }
}