class Var
{
    public static void MyVar()
    {
        string myName = "Jose";
        Console.WriteLine(myName);
    }

    public static void DataType()
    {
        string firstName = "Jose";
        string lastName = "Maldonado";
        string wholeName = firstName + " " + lastName;
        int age = 16;
        float gpa = 5.4f;
        double height = 5.8;
        decimal dollar = 34.98m;
        bool is_Teacher = false;
        char grade = 'A';

        //Console.WriteLine(firstName);
        //Console.WriteLine(lastName);
        Console.WriteLine(wholeName);
        Console.WriteLine(age);
        Console.WriteLine(gpa);
        Console.WriteLine(height);
        Console.WriteLine(dollar);
        Console.WriteLine(is_Teacher);
        Console.WriteLine(grade);
    }
}