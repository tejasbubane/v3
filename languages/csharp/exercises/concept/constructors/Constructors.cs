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
        if (battery >= batteryDrain)
        {
            battery -= batteryDrain;
            distance += speed;
        }
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

    public RemoteControlCar Winner(RemoteControlCar firstCar, RemoteControlCar secondCar)
    {
        while (firstCar.DistanceDriven() < distance && firstCar.DistanceDriven() < distance)
        {

        }
    }
}
