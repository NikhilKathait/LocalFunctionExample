class Student
{
    //Method
    public void DisplayMarks(params int[] marks)
    {
        double avgMarks = GetAverageMarks();
        for(int i = 0; i < marks.Length; i++)
        {
            System.Console.WriteLine("Marks "+ i +" : " +marks[i]);
        }
        System.Console.WriteLine("Average Marks is " + avgMarks);

        //Local Function
        double GetAverageMarks()
        {
            double avg=0;
            for (int j = 0; j < marks.Length; j++)
            {
                avg = avg+(double)(marks[j]);
            }
            avg= avg/ (double)marks.Length;

            return avg;
        }
    }
}

class Program
{
    static void Main()
    {
        //Create object for student class
        Student s = new Student();

        //Call DisplayMarks method
        s.DisplayMarks(80,70,60,50);
    }
}