namespace Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1, "Ruben");
            emp.Salary = 60000;
            Console.WriteLine(emp);
            (int id, string empName) = emp;
            Console.WriteLine($"employee: {id}, name: {empName}");
            //emp.Name = "Joost" this should not 

            if (emp is Employee { Salary: > 5000 })
                Console.WriteLine("Nice Salaryy");


            Employee boss = emp; // waarden worden overgenomen
            boss.RaiseSalery(1.5);
            Console.WriteLine(boss);
           
        }

        public record Employee (int Id, string Name)
        {
            public double Salary { get; set; }

            public void RaiseSalery(double procentige) 
            {
                Salary = Salary * procentige;
            }
        }
    }
}
