namespace Functions
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class ClassRoom
    {
        public List<Student> Students { get; set; }

        public double AverageAge() => Students.Average(s => s.Age);

        /*KISS: Keep it simple & stupit */
        /*DRY: Don't Repeat Yourself!*/
        /*Occam'ın Usturası*/

    }
}
