In this exercise you'll be organizing races between various types of remote controlled cars. Each car has its own speed and battery drain characteristics.

Cars start with full (100%) batteries. Each time you drive the car using the remote control, it covers the car's speed in meters and decreases the remaining battery percentage by its battery drain.

If a car's battery is below its battery drain percentage, you can't drive the car anymore.

Each race track has its own distance. Cars are tested by checking if they can finish the track without running out of battery.

You have six tasks, each of which will work with remote controller car instances.

### 1. Creating a remote controlled car

Allow creating a remote controller car by defining a constructor for the `RemoteControlCar` class that takes the speed of the car in meters and the battery drain percentage as its two parameters (both of type `int`):

```csharp
var car = new RemoteControlCar(speed: 5, batteryDrain: 2);
```

### 2. Creating a race track

Allow creating a race track by defining a constructor for the `RaceTrack` class that takes the track's distance in meters as its sole parameter (which is of type `int`):

```csharp
var raceTrack = new RaceTrack(distance: 800);
```

### 3. Drive the car

Implement the `RemoteControlCar.Drive()` method that updates the number of meters driven based on the car's speed. Next, implement the `RemoteControlCar.DistanceDriven()` method to return the number of meters driven by the car:

```csharp
var car = new RemoteControlCar(speed: 5, batteryDrain: 2);
car.Drive();
car.DistanceDriven();
// => 5
```

### 4. Check for a drained battery

Update the `RemoteControlCar.Drive()` method to drain the battery based on the car's battery drain. Next, implement the `RemoteControlCar.BatteryDrained()` method that indicates if the battery is drained:

```csharp
var car = new RemoteControlCar(speed: 5, batteryDrain: 2);
car.Drive();
car.BatteryDrained();
// => false
```

### 5. Create the top of the line remote control car

The current top of the line car is the Nitro, which speed is a stunning 50 meters and its battery drain is 4%. Implement the (static) `RemoteControlCar.TopOfTheLine()` method to return this top of the line car:

```csharp
var car = RemoteControlCar.TopOfTheLine();
car.Drive();
car.DistanceDriven();
// => 50
```
