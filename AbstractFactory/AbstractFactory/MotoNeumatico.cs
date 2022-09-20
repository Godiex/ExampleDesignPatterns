namespace AbstractFactory
{
    public class MotoNeumatico : Neumatico
    //PRODUCTO CONCRETO
    {
        public override void Pintar()
        {
            Console.WriteLine("Pintando neumatico de moto…");

        }
    }
}
