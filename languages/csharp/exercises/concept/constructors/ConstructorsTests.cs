using Xunit;

public class RemoteControlCarTests
{
    [Fact]
    public void NewRemoteControlCarHasNotDrivenAnyDistance()
    {
        var car = new RemoteControlCar(speed: 10, batteryDrain: 2);
        Assert.Equal(0, car.DistanceDriven());
    }

    [Fact]
    public void NewRemoteControlCarBatteryIsNotDrained()
    {
        var car = new RemoteControlCar(speed: 15, batteryDrain: 3);
        Assert.False(car.BatteryDrained());
    }

    [Fact]
    public void DriveIncreasesDistanceDrivenWithSpeed()
    {
        var car = new RemoteControlCar(speed: 5, batteryDrain: 1);
        car.Drive();
        Assert.Equal(5, car.DistanceDriven());
    }

    [Fact]
    public void DriveDoesNotIncreaseDistanceDrivenWhenBatteryDrained()
    {
        var car = new RemoteControlCar(speed: 9, batteryDrain: 50);

        // Drain the battery
        car.Drive();
        car.Drive();

        // One extra drive attempt (should not succeed)
        car.Drive();

        Assert.Equal(18, car.DistanceDriven());
    }

    [Fact]
    public void DriveToAlmostDrainBattery()
    {
        var car = new RemoteControlCar(speed: 2, batteryDrain: 1);

        // Almost drain the battery
        for (var i = 0; i < 99; i++)
        {
            car.Drive();
        }

        Assert.False(car.BatteryDrained());
    }

    [Fact]
    public void DriveUntilBatteryIsDrained()
    {
        var car = new RemoteControlCar(speed: 2, batteryDrain: 1);

        // Drain the battery
        for (var i = 0; i < 100; i++)
        {
            car.Drive();
        }

        Assert.True(car.BatteryDrained());
    }
}
