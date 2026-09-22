using System;

class RemoteControlCar
{
    private int speed;
    private int batteryDrain;
    private int battery = 100;
    private int distanceDriven = 0;

    // Task 1: Constructor for RemoteControlCar
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    // Task 4: Check if the battery is drained (cannot drive anymore)
    public bool BatteryDrained()
    {
        return this.battery < this.batteryDrain;
    }

    // Task 3: Return the total distance driven
    public int DistanceDriven()
    {
        return this.distanceDriven;
    }

    // Tasks 3 & 4: Drive updates distance and battery if enough power remains
    public void Drive()
    {
        if (!BatteryDrained())
        {
            this.distanceDriven += this.speed;
            this.battery -= this.batteryDrain;
        }
    }

    // Task 5: Static factory method for the "Nitro" model
    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int distance;

    // Task 2: Constructor for RaceTrack
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    // Task 6: Calculate if the car can clear the distance before running out of power
    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            car.Drive();
        }
        
        return car.DistanceDriven() >= this.distance;
    }
}
