namespace AbstractFactory
{
    public class CocheFreno : Freno
    {
        //PRODUCTO CONCRETO

        public override void Pintar()
        {
            Console.WriteLine("Pintando Freno de Coche…");
        }

        
    }
}
