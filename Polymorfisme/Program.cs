
using Polymorfisme;

Console.WriteLine("Voorbeeld polymorfisme");

// De "Vorm" neemt hier de vorm van een "Cirkel" aan
Vorm deVorm = new Cirkel("cirkel", 100);
double area = deVorm.BerekenOppervlakte();
double circumference = ((Cirkel)deVorm).BerekenOmtrek();
Console.WriteLine($"De oppervlakte van {deVorm.Name} is {area}");
Console.WriteLine($"De omtrek van {deVorm.Name} is {circumference}");

// Nu neemt de "Vorm" de vorm van "Vierkant" aan
deVorm = new Vierkant("vierkant", 100);
area = deVorm.BerekenOppervlakte();
circumference = deVorm.BerekenOmtrek();
Console.WriteLine($"De oppervlakte van {deVorm.Name} is {area}");
Console.WriteLine($"De omtrek van {deVorm.Name} is {circumference}");

//De "Vorm" neemt nu de vorm van "Driehoek" aan
deVorm = new Driehoek("driehoek", 100, 50);
area = deVorm.BerekenOppervlakte();
circumference = deVorm.BerekenOmtrek();
Console.WriteLine($"De oppervlakte van {deVorm.Name} is {area}");
Console.WriteLine($"De omtrek van {deVorm.Name} is {circumference}");
