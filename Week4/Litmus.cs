namespace Week4;

class Litmus : IPHIndicator
{
    private double ph;

    public void SetPh(double ph)
    {
        this.ph = ph;
    }

    public string getColor()
    {
        if (ph < 4.5)
        {
            return "Red";
        }
        else if (ph >= 8.3)
        {
            return "Blue";
        }
        else
        {
            return "Purple";
        }
    }
}