
using StaticAndNonStatic;

public class program
{
    public static void Main()
    {
        // Calling Non-Static in static...so we have to create object.

        Console.WriteLine("Enter the Data for Doctor1:");
        Doctor doctor1 = new Doctor();
        doctor1.GetData();
        doctor1.PutData();

        ///////////////// OR /////////////////

        //Calling Static in Static...We can call directly.

        Console.WriteLine("Enter Data for Doctor2:");
        Doctor.GetInput(); 
        Doctor.ShowOutput();


    }
}