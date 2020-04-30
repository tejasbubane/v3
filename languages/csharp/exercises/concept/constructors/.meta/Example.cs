class RemoteControlCar
{
    private int battery = 100;
    private int distance = 0;
    private int speed;
    private int batteryDrain;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            battery -= batteryDrain;
            distance += speed;
        }
    }

    public bool BatteryDrained()
    {
        return battery < batteryDrain;
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

    public static Race Marathon()
    {
        return new Race(42195);
    }
}
