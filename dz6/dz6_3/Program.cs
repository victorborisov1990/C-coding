// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.

double LengthXY (double x1, double y1, double x2, double y2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2-x1,2)
                               +Math.Pow(y2-y1,2)),2);
}
Console.Clear(); 
Console.Write("Введите X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите X3: ");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y3: ");
double y3 = Convert.ToDouble(Console.ReadLine());

double ab = LengthXY(x1,y1,x2,y2);
double bc = LengthXY(x2,y2,x3,y3);
double ac = LengthXY(x1,y1,x3,y3);
double halfPerimetr = (ab+bc+ac)/2;
double S = Math.Round(Math.Sqrt(halfPerimetr
                                *(halfPerimetr-ab)
                                *(halfPerimetr-bc)
                                *(halfPerimetr-ac)),2);

Console.WriteLine($"Площадь треугольника = {S}");

