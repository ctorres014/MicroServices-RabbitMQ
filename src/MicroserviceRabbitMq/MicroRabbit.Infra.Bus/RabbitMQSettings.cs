namespace MicroRabbit.Infra.Bus
{
    public class RabbitMQSettings
    {
        // Declaramos las properties de setting para RabbitMQ
        public string HostName { get; set; } = string.Empty;
        public string UserName {  get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
