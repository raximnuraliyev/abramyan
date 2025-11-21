//  Begin19.The coordinates(x1, y1) and(x2, y2) of two opposite vertices of a rectangle
//  are given. Sides of the rectangle are parallel to coordinate axes. Find the
//  perimeter and the area of the rectangle.
double x1, y1, x2, y2;
Console.WriteLine("x1: ");
x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("y1: ");
y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("x2: ");
x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("y2: ");
y2 = Convert.ToDouble(Console.ReadLine());

double P = 2 * (Math.Abs(x1 - x2) + Math.Abs(y1 - y2));
Console.WriteLine("P: " + P);

double Area = Math.Abs(x1 - x2) * Math.Abs(y1 - y2);
Console.WriteLine("Area: " + Area);
