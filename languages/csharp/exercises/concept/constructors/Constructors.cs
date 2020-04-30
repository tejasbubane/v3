using System;

class RemoteControlCar
{
    private int speed;
    private int battery = 100;
    private int batteryDrain;
    private int distance;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        return battery < batteryDrain;
    }

    public int DistanceDriven()
    {
        return distance;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            battery -= batteryDrain;
            distance += speed;
        }
    }

    public static RemoteControlCar TopOfTheLine()
    {
        return new RemoteControlCar();
    }
}

class RaceTrack
{
    private int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool CarCanFinish(RemoteControlCar car)
    {
        throw new NotImplementedException("Please implement the RaceTrack.CarCanFinish() method");
    }
}


// using System;

// class RemoteControlCar
// {
//     // TODO: define the 'RemoteControlCar' classes' constructor

//     public bool BatteryDrained()
//     {
//         throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDrained() method");
//     }

//     public int DistanceDriven()
//     {
//         throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDriven() method");
//     }

//     public void Drive()
//     {
//         throw new NotImplementedException("Please implement the RemoteControlCar.Drive() method");
//     }

//     public static RemoteControlCar TopModel()
//     {
//         throw new NotImplementedException("Please implement the (static) RemoteControlCar.TopModel() method");
//     }
// }

// class RaceTrack
// {
//     // TODO: define the 'RaceTrack' classes' constructor

//     public bool CarCanFinish(RemoteControlCar car)
//     {
//         throw new NotImplementedException("Please implement the RaceTrack.CarCanFinish() method");
//     }
// }
