namespace AbstractFactory
{
    public interface IVehiculo
    {
        //contendra los diferentes productos abstractos
        //devuelve la clase abstracta que contiene los metodos
        //FABRICA ABSTRACTA
        Neumatico CreateNeumatico();
        Freno CreateFreno();
    }
}
