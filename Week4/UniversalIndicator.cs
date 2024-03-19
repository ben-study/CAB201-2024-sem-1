namespace Week4;

class UniversalIndicator : IPHIndicator
{
    private double ph;

    public void SetPh(double ph)
    {
        this.ph = ph;
    }

    public string getColor()
    {
        if (ph < 2)
        {
            return "Red";
        }
        else if (ph < 4)
        {
            return "Orange";
        }
        else if (ph < 6)
        {
            return "Yellow";
        }
        else if (ph < 8)
        {
            return "Green";
        }
        else if (ph < 10)
        {
            return "Blue";
        }
        else if (ph < 12)
        {
            return "Indigo";
        }
        else
        {
            return "Violet";
        }
    }
}