Circle krug = new Circle();
System.Console.Write("Enter circle's radius: ");
string radius = krug.SetRadius(double.Parse(Console.ReadLine()));

System.Console.Write("Area of the circle: ");
double area = krug.GetArea();
System.Console.WriteLine(area);

System.Console.Write("Diameter of the circle: ");
double diameter = krug.GetDiameter();
System.Console.WriteLine(diameter);

System.Console.Write("Circumference of the circle: ");
double circumference = krug.GetCircumference();
System.Console.WriteLine(circumference);

class Circle{
    private double radius;
    private double PI = 3.14159;

    public string SetRadius (double radius){
        this.radius = radius;
        return "None";
    }
    public double GetArea(){
        return PI*radius*radius;
    }
    public double GetDiameter(){
        return radius*2;
    }
    public double GetCircumference(){
        return 2*PI*radius;
    }

}