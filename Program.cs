using CarsCodeCademy;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Sedan s = new (60);
s.SpeedUp();
Console.WriteLine(s.Describe());

Truck t = new Truck(50, 600);
t.SlowDown();
Console.WriteLine(t.Describe());

Bicycle b = new(16);
b.SpeedUp();
Console.WriteLine(b.Describe());

Hybrid h = new(180, 700);
h.SpeedUp();
Console.WriteLine(h.Describe());

Electric e = new(200, 2000);

Vehicle v1 = new Bicycle(11);
v1.SlowDown();
Console.WriteLine(v1.Describe());

Console.WriteLine($"Number of vehicles: {Vehicle.NumVehicles}");



// ARRAYS OF OBJECTS

IElectricVehicle[] electrics = new IElectricVehicle[2];
electrics[1] = e;
electrics[0] = h;

foreach (IElectricVehicle ev in electrics) Console.WriteLine($"{ev} has a potential distance of: {ev.DistancePotential}");


Vehicle[] vehicles = new Vehicle[] { s, t, e, h, b, v1 };
foreach (Vehicle v in vehicles)
{
    Console.WriteLine($"this {v} has {v.Wheels} wheels. The wheels are inherited from the Vehicle super class!");
}



// LISTS & LINQ

List<Vehicle> vehicles2 = new List<Vehicle> { s, h, e };
vehicles2.Add(b);
vehicles2.Add(v1);
vehicles2.Insert(1, t);

var fastVehicles = vehicles2
                    .Where(v => v.Speed > 15)
                    .Select(v => $"This {v.GetType()} can drive on the main road with speed: {v.Speed}");
foreach (var v in fastVehicles) Console.WriteLine(v);

var bikes = from v in vehicles2
            where v.Wheels == 2
            select $"{v.GetType()} is a bike, cause it only has {v.Wheels} wheels";
foreach (var bk in bikes) Console.WriteLine(bk);
