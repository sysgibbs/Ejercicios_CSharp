class WeighingMachine
{
    
    public int Precision { get; }

    
    private double _weight;

    
    public double Weight
    {
        get => _weight;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "El peso no puede ser negativo.");
            }
            _weight = value;
        }
    }

    
    public double TareAdjustment { get; set; } = 5.0;

    
    public WeighingMachine(int precision)
    {
        Precision = precision;
    }

    
    public string DisplayWeight
    {
        get
        {
            double displayValue = Weight - TareAdjustment;
            return $"{displayValue.ToString($"F{Precision}")} kg";
        }
    }
}
