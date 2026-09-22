class RemoteControlCar
{

    private int distancia = 0;
    private int bateria = 100;
    
    public static RemoteControlCar Buy()
    {

    return new RemoteControlCar();
   
    }

    public string DistanceDisplay()
    {
         return $"Driven {distancia} meters";
    }

    public string BatteryDisplay()
    {
    if (bateria <= 0){
        return "Battery empty";
    }
    else 
    {     
        return $"Battery at {bateria}%";
    }

    }

    public void Drive()
    {
        if (bateria > 0){
            distancia += 20;
            bateria -= 1;
        }
    }
}
