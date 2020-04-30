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
        if (BatteryDrained())
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
}

class Race
{
    private int distance;

    public Race(int distance)
    {
        this.distance = distance;
    }

    public bool CanFinish(RemoteControlCar car)
    {
        while (!car.BatteryDrained)
        {

        }
    }
}
