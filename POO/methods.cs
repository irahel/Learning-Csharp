public class MotorcycleController
{
    //Anyone can call
    public void Start(){}
    //Derived classes can call
    protected void AddGas(int gallons){}
    //Derived classes can override
    public virtual int Drive(int miles, int speed){return 1;}
    //Derived classes must implement
    public abstract double getTopSpeed();
}