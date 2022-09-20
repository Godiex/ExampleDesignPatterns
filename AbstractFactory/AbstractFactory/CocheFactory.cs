namespace AbstractFactory
{
    //Concrete factory FRABRICAS CONCREATS
    public class CocheFactory : IVehiculo
    {
        public Freno CreateFreno()
        {
            return new CocheFreno();
        }

        public Neumatico CreateNeumatico()
        {
            return new CocheNeumatico();
        }

      
    }
}
