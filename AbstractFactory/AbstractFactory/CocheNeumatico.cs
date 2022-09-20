namespace AbstractFactory
{
    public class CocheNeumatico : Neumatico
    {

        //PRODUCTO CONCRETO

        public override void Pintar()
        {
            Console.WriteLine("Pintando neumatico de Coche…");
        }
    }
}
