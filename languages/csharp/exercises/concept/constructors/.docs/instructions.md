In this exercise you'll be organizing a race between various types of remote controlled cars. Each car has its own speed and battery drain characteristics.

Cars start with full (100%) batteries. Each time you drive the car using the remote control, it covers the car's speed in meters and decreases the remaining battery percentage by its battery drain.

If a car's battery is below its battery drain percentage, you can't drive the car anymore.

You have six tasks, each of which will work with remote controller car instances.

### 1. Allow creating a new remote controlled car

Implement a constructor for the `RemoteControlCar` class that takes the speed of the car and the batter:

```csharp
RemoteControlCar car = new RemoteControlCar(speed: 5, batteryDrainPercentage: 2);
```

### 2. Display the distance driven

Implement the `RemoteControlCar.DistanceDisplay()` method to return the distance as displayed on the LED display:

```csharp
var car = RemoteControlCar.Buy();
car.DistanceDisplay();
// => "Driven 0 meters"
```

### 3. Display the battery percentage

Implement the `RemoteControlCar.BatteryDisplay()` method to return the distance as displayed on the LED display:

```csharp
var car = RemoteControlCar.Buy();
car.BatteryDisplay();
// => "Battery at 100%"
```

### 4. Update the number of meters driven when driving

Implement the `RemoteControlCar.Drive()` method that updates the number of meters driven:

```csharp
var car = RemoteControlCar.Buy();
car.Drive();
car.Drive();
car.DistanceDisplay();
// => "Driven 40 meters"
```

### 5. Update the battery percentage when driving

Update the `RemoteControlCar.Drive()` method to update the battery percentage:

```csharp
var car = RemoteControlCar.Buy();
car.Drive();
car.Drive();
car.BatteryDisplay();
// => "Battery at 98%"
```

### 6. Don't allowing driving the car when the battery is drained

Update the `RemoteControlCar.Drive()` method to not increase the distance driven nor decrease the battery percentage when the battery is drained (at 0%):

```csharp
var car = RemoteControlCar.Buy();

// Drain the battery
// ...

car.DistanceDisplay();
// => "Driven 2000 meters"

car.BatteryDisplay();
// => "Battery empty"
```
