namespace AbstractFactory
{
    //FRABRICAS CONCRETAS
    public class MotoFactory : IVehiculo

    {
        public Neumatico CreateNeumatico()
        {
            return new MotoNeumatico();
        }

        public Freno CreateFreno()
        {
            return new MotoFreno();
        }
    }
}
