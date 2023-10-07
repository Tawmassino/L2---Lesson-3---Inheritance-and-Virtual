namespace L2___Lesson_3___Inheritance_and_Virtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialize objects of manager and employees
            Manager menedzeris = new Manager("Vardenis", 2023);//kad galetumeme is karto rasyti parametrus, reikia konstruktoriaus uzpildyto
            Employee1 darbuotojas1 = new Employee1("Darbas", 666);
            Employee1 darbuotojas2 = new Employee1("Veikla", 777);
            Employee1 darbuotojas3 = new Employee1("Uzimtumas", 999);
            Programmer programmer1 = new Programmer("Hackeris", 42069);


            //manager klaseje yra jam pavaldziu darbuotoju sarasas, todel accessinam manager objekta, ten imame sarasa vardu employeeS ir pridedame.
            menedzeris.Employees.Add(darbuotojas1);
            menedzeris.Employees.Add(darbuotojas2);
            menedzeris.Employees.Add(darbuotojas3);


            foreach (var workeris in menedzeris.Employees)
            {
                Console.WriteLine($" Name: {workeris.Name}, Salary: {workeris.Salary}  ");
            }

            programmer1.ProgrammingLanguage = "C#";

            Console.WriteLine($" Name: {programmer1.Name}, Salary: {programmer1.Salary}, Programming language: {programmer1.ProgrammingLanguage}  ");


            #region Squared

            // /*
            Square square = new Square(3.5);
            Console.WriteLine($"Kvadratas turi {square.NumberOfAngles} kampus");
            Console.WriteLine($"Kvadrato krastine ilgis = {square.Size} ");
            // */

            #endregion

            #region Entity-human-employee


            Entity entity = new Entity();
            Human human = new Human();
            Employee employee = new Employee();

            //entity turi tik ID nes yra parent class
            entity.Id = 1;


            //human class is child of ENTITY, so inherit ID
            human.Name = "Tomas";
            human.Surname = "Lol";
            human.Birthday = DateTime.Now;
            human.Id = 2;


            //employee is child of HUMAN class, which is also child of ENTITY
            employee.Salary = 3000;
            employee.EmploymentDate = DateTime.Now;
            employee.Name = "name";
            employee.Surname = "surname";
            employee.Birthday = new DateTime(2000, 01, 02);
            employee.Id = 3;

            #endregion


        }
    }
}