class Sharpie
{
    public string Color;
    public float Width;
    public float InkAmount;

    public Sharpie(string Color, float Width, float InkAmount)
    {
        this.Color = Color;
        this.Width = Width;
        this.InkAmount = InkAmount;
    }

    public Sharpie(string Color, float Width) : this(Color, Width, 100)
    {
    }

    public void use()
    {
        InkAmount--;
    }
}