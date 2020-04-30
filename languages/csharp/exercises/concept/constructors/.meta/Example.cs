class RemoteControlCar
{
    private int batteryPercentage = 100;
    private int distance = 0;
    private int speed;
    private int batteryDrainPercentage;

    public RemoteControlCar(int speed, int batteryDrainPercentage)
    {
        this.speed = speed;
        this.batteryDrainPercentage = batteryDrainPercentage;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            batteryPercentage -= batteryDrainPercentage;
            distance += speed;
        }
    }

    public bool BatteryDrained()
    {
        return batteryPercentage < batteryDrainPercentage;
    }

    public int DistanceDriven()
    {
        return distance;
    }

    public static RemoteControlCar TopModel()
    {
        return new RemoteControlCar(50, 4);
    }
}

class Race
{
    private int distance;

    public Race(int distance)
    {
        this.distance = distance;
    }

    public bool CarCanFinish(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            car.Drive();
        }

        return car.DistanceDriven() >= distance;
    }
}
