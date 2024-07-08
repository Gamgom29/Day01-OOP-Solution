namespace Task
{
    enum Gender
    {
        Male = 1, M = 1 , F = 2 ,Female = 2
    }

    internal struct Employee
    {
        private int id;
        private string? name;
        private decimal salary;
        private Gender gender;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Salary 
        {
            get { return salary; }
            set { salary = value; }
        }

        public Gender Gender 
        {
            get { return gender; }
            set { gender = value; }
        }
        public Employee(int id , string name , decimal salary , Gender gender)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.gender = gender;
        }

        public override string ToString()
        {
            return $" id: {id} \n Name: {name} \n Salary: {salary:c}  \n Gender: {gender} ";
        }
    }

    internal class Program
    {
        static Employee CreateEmployee()
        {

            int id;
            string name; 
            decimal salary;
            Gender gender;
            do
            {
                Console.Write("Enter Employee Id : ");

            } while (!int.TryParse(Console.ReadLine(), out id));

            Console.Write("Enter Employee Name: ");
            name = Console.ReadLine() ?? "No Name";

            do
            {
                Console.Write("Enter Employee Salary : ");

            } while(!decimal.TryParse(Console.ReadLine(),out salary));

            do
            {
                Console.Write("Enter Employee Gender: ");
            } while (!Enum.TryParse(Console.ReadLine(), true ,out gender));

            Employee emp = new Employee(id, name, salary , gender);

            Console.WriteLine(emp.ToString());
            return emp;
        }
        static void Main(string[] args)
        {
            Employee emp = CreateEmployee();
        }
    }
}
