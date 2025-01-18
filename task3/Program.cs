Date input = new Date();

System.Console.Write("Day: ");
input.GetDay(int.Parse(Console.ReadLine()));

System.Console.Write("Month: ");
input.GetMonth(int.Parse(Console.ReadLine()));

System.Console.Write("Year: ");
input.GetYear(int.Parse(Console.ReadLine()));

string date = input.ToString();
System.Console.WriteLine(date);

class Date{
    private int day;
    private int month;
    private int year;

    public void SetDate(int day, int month, int year){
        this.day=day;
        this.month=month;
        this.year=year;
    }
    public void GetDay(int day){
        this.day=day;
    }
    public void GetMonth(int month){
        this.month=month;
    }
    public void GetYear(int year){
        this.year=year;
    }
    public string ToString(){
        return $"{day}/{month}/{year}";
    }

}