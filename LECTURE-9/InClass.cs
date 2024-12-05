// using System.Data.Common;
// using System.Runtime.InteropServices;
// using System.Xml.Linq;
// using InClassExcercise;

// namespace InClassExcercise {
//     enum Department {
//         HR,
//         IT,
//         Finance,
//         Marketing,
//     }

//     class Employee {
//         public int Id {set; get;}
//         public string Name {set; get;}

//         public Department Department {get; set;}
//         public double Salary {get; set;}

//         public Employee(int id, string name, Department department, double salary) {
//             Id = id;
//             Name = name;
//             Department = department;
//             Salary = salary;
//         }

//         public virtual string GetDetails() {
//             return $"Id: {Id}, Name: {Name}, Department: {Department}, Salary: ${Salary}";
//         }
//     }

//     class Manager : Employee {
       
//         public Manager(int id, string name, Department department, double salary): base(id, name, department, salary) {
            
//         }

//         public override string GetDetails()
//         {
//             return base.GetDetails() + ", Role: Manager";
//         }
//     }

//     class Developer : Employee {
//         public Developer(int id, string name, Department department, double salary): base(id, name, department, salary) {
            
//         }
//         public override string GetDetails()
//         {
//             return base.GetDetails() + ", Role: Developer";
//         }
//     }

//     class InClass {
//         static void Main(string[] args) {

//             Console.Write("Enter number of employer: ");

//             Employee[] employees = new Employee[int.Parse(Console.ReadLine())];
//             for (int i = 0; i < employees.Length; i++) {
//                 bool type = false;
        
//                 while (!type) {
//                     Console.Write("\nEnter the type of Employee(Developer, Manager): ");
//                     string intput = Console.ReadLine();
//                     if (string.Equals(intput, "manager", StringComparison.OrdinalIgnoreCase)){
//                         type = true;
//                         employees[i] = createEmployee("Manager", i+1);
//                         Console.WriteLine(employees[i].GetDetails());
//                     } else if (string.Equals(intput, "developer", StringComparison.OrdinalIgnoreCase)) {
//                         type = true;
//                         employees[i] = createEmployee("Developer", i+1);
//                         Console.WriteLine(employees[i].GetDetails());
//                     } else {
//                         Console.WriteLine("!!! ERROR: input is: " + intput);
//                     }
                    
//                 }  
//             }
//         }


//         static Employee createEmployee(string role, int id) {
//             Console.WriteLine($"Id: {id}");
//             Console.Write("Name: ");
//             string name = Console.ReadLine();

//             Console.Write("Department (HR, IT, Finance, Marketing): ");
//             Department department = (Department)Enum.Parse(typeof(Department), Console.ReadLine());

//             Console.Write("Salary: ");
//             double salary = double.Parse(Console.ReadLine());

//             if (role == "Manager") {
//                 return new Manager(id, name, department, salary);
//             } else {
//                 return new Developer(id, name, department, salary);
//             }
//         }
    
//     }
// }