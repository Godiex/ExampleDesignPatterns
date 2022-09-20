namespace AbstractFactory
{
    public class MotoFreno : Freno
    {
        //PRODUCTO CONCRETO
        public override void Pintar()
        {
            Console.WriteLine("Pintando Freno de moto…");
        }
    }
}
