class Lasagna
{

   
    public int ExpectedMinutesInOven() => 40;

    
    public int RemainingMinutesInOven(int actualMinutesInOven) => 40 - actualMinutesInOven;
   
    public int PreparationTimeInMinutes(int layers) => layers * 2;

public int ElapsedTimeInMinutes(int numberOfLayers, int actualMinutesInOven) => PreparationTimeInMinutes(numberOfLayers) + actualMinutesInOven;
    }
    
