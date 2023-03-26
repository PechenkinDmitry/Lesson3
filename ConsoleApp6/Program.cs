public void Main()
{ 
class Doctor
{
    public string Name = "";
    public int age = 0;
    public int expirience = 0;

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}  Age: {age}  Expirience {expirience}" );
    }
}
class Surgeon : Doctor
{
    public new string Name = "";

    public int Age = 0;
        public void help()
    {
        Console.WriteLine($"Help from gemorroi");
        }
}
}