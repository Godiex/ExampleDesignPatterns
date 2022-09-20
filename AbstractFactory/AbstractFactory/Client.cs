namespace AbstractFactory
{
    public class Client
    {
        public void Main()
        {
            
            Console.WriteLine("Client: Probando el código del cliente con el primer tipo de fábrica...");
            ClientMethod();
            Console.WriteLine();

        }

        public void ClientMethod()
        {
            // Objetos para el Coche
            IVehiculo factory = new CocheFactory();
            Freno freno = factory.CreateFreno();
            Neumatico neumatico = factory.CreateNeumatico();

            neumatico.Pintar();
            freno.Pintar();

            Console.WriteLine();
            // Objetos para la Moto
            factory = new MotoFactory();
            freno = factory.CreateFreno();
            neumatico = factory.CreateNeumatico();

            neumatico.Pintar();
            freno.Pintar();
        }
    }
}
