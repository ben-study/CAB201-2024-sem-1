namespace Week4;

public class Turmeric : IPHIndicator
{
    private double ph;
    public void SetPh(double ph) 
    {
        this.ph = ph;
    }
    public string getColor() 
    {
        if (ph < 11) 
        {
            return "Vermilion";
        } else 
        {
            return "Yellow";
        }
    }
}