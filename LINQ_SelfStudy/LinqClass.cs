using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_SelfStudy
{
    // agar biz bitta list uchun bitta linq yozsak keyin list elementlarini almashtirsak u biz yozgan linq boyicha ham almashadi
    internal class LinqClass
    {
        public void WhereMethod()
        {
            #region 
            List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var EvenNumbers = Numbers.Where(x => x % 2 == 0);
            Console.WriteLine("Juft sonlar listi method sintaksisi orqali");
            foreach (var number in EvenNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Toq sonlar query sintaksisi orqali");
            var OddNumbers = from number in Numbers where number % 2 == 1 select number;
            foreach (var number in OddNumbers)
            {
                Console.WriteLine(number);
            }
            #endregion
        }
        public void OfftypeMethod()
        {             
            #region 
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add("four");
            arrayList.Add("fife");
            arrayList.Add("six");
            Console.WriteLine("Offtype method sintaksisi orqali");
            var IntArrayList = arrayList.OfType<int>();
            foreach (int i in IntArrayList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Offtype query sintaksisi orqali");
            var StringArrayList = from a in arrayList.OfType<string>() select a;
            foreach (string s in StringArrayList)
            { Console.WriteLine(s); }
            #endregion
        }
        public void OrderBy()
        {
            #region
            List<Student> students = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 },
                new Student() { StudentID = 6, StudentName = "Ram" , Age = 18 },
                new Student() { StudentID = 7, StudentName = "Alica" , Age = 22 },
                new Student() { StudentID = 8, StudentName = "David" , Age = 23 },
                new Student() { StudentID = 9, StudentName = "Ctiven" , Age = 25 },
                new Student() { StudentID = 7, StudentName = "Edvard" , Age = 13 },
                new Student() { StudentID = 1, StudentName = "John", Age = 17 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 14 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 24 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 19 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 18 },
                new Student() { StudentID = 6, StudentName = "Ram" , Age = 17 },
                new Student() { StudentID = 7, StudentName = "Alica" , Age = 21 },
                new Student() { StudentID = 8, StudentName = "David" , Age = 22 },
                new Student() { StudentID = 9, StudentName = "Ctiven" , Age = 24 },
                new Student() { StudentID = 7, StudentName = "Edvard" , Age = 12 }
            };
            Console.WriteLine("Sudents Array List");
            foreach (Student student in students)
            {
                Console.Write(student.StudentID+" "+student.StudentName+" "+student.Age);
                Console.WriteLine();
            }

            var SortedByAge=students.OrderBy(x=>x.Age);
            Console.WriteLine("Age boyicha method sintaksisi orqali sortlash");
            foreach (Student student in SortedByAge)
            {
                Console.Write(student.StudentID + " " + student.StudentName + " " + student.Age);
                Console.WriteLine();
            }

            var SortedByAgeDistinct = students.OrderByDescending(x => x.Age);
            Console.WriteLine("Age boyicha method sintaksisi orqali teskari  sortlash");
            foreach (Student student in SortedByAgeDistinct)
            {
                Console.Write(student.StudentID + " " + student.StudentName + " " + student.Age);
                Console.WriteLine();
            }

            Console.WriteLine("Student name boyicha order by query sintaksisi orqali");
            var SortedByName = from a in students orderby a.StudentName select a;
            foreach (Student student in SortedByName)
            {
                Console.Write(student.StudentID + " " + student.StudentName + " " + student.Age);
                Console.WriteLine();
            }

            Console.WriteLine("Student name boyicha order by query sintaksisi orqali teskari sortlash");
            var SortedByNameDistinct = from a in students orderby  a.StudentName descending select a ;
            foreach (Student student in SortedByNameDistinct)
            {
                Console.Write(student.StudentID + " " + student.StudentName + " " + student.Age);
                Console.WriteLine();
            }


            Console.WriteLine("Order by name then by age");
            var lst = students.OrderBy(x => x.StudentName).ThenBy(x => x.Age);
            foreach (Student student in lst)
            {
                Console.Write(student.StudentID + " " + student.StudentName + " " + student.Age);
                Console.WriteLine();
            }
            #endregion
        }
        public void GroupBYMethod()
        {
            #region
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 },
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 },
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 }
            };
            Console.WriteLine("----lstMetjodsyntaksis");
            var lstMetjodsyntaksis = studentList.GroupBy(x => x.Age);
            foreach(var l in lstMetjodsyntaksis)
            {
                Console.WriteLine(l.Key);
                foreach(Student student in l)
                {
                    Console.WriteLine($"     {student.StudentID} {student.StudentName} {student.Age}");
                }
                
            }
            Console.WriteLine("----query syntaksis");
            var querysyntaksis = from student in studentList
                                 group student by student.StudentID;

            foreach (var l in querysyntaksis)
            {
                Console.WriteLine(l.Key);
                foreach (Student student in l)
                {
                    Console.WriteLine($"     {student.StudentID} {student.StudentName} {student.Age}");
                }

            }
            #endregion
        }
        public void ToLookUp()
        {
            #region
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 }
            };
            var lst=studentList.ToLookup(x=> x.Age);
            foreach (var student in lst)
            {
                Console.WriteLine(student.Key);
                foreach(var s in student)
                {
                    Console.WriteLine($"{s.StudentID} {s.StudentName} {s.Age}");
                }
            }
            #endregion
        }
        public void JoinMethod()
        {
            #region
            List<Department> departments = new List<Department>() {
                new Department(1, "HR"),
                new Department(2,"O'quv bo'limi"),
                new Department(3,"Adminstratsiya")};

            List<Employee> employees = new List<Employee>()
            {
                new Employee(1,"Robiya",1),
                new Employee(2,"Laylo",2),
                new Employee(3,"Zahro",3),
                new Employee(4,"Hafiza",3),
                new Employee(5,"Omina",1),
                new Employee(6,"Odina",2),
                new Employee(7,"Hadicha",3),
                new Employee(8,"Fotima",3),
                new Employee(9,"Sanoat",1),
                new Employee(10,"Sevara",2),
                new Employee(11,"Dilnura",3),
                new Employee(12,"Malika",3),
            };
            var DE = employees.Join(departments,
                employee => employee.DepartmentId,
                department => department.DepartmentId,
                (employee,department)=>new { employee.EmployeeID,employee.EmployeeName,department.DepartmentName });

            var DEQ = from e in employees
                      join d in departments
                      on e.DepartmentId equals d.DepartmentId
                      select new
                      {
                          e.EmployeeID,
                          e.EmployeeName,
                          d.DepartmentName
                      };
            
            Console.WriteLine("-----Method sytntaksisi orqali");
            foreach (var de in DE)
            {
                Console.WriteLine($"{de.EmployeeID} , {de.EmployeeName} , {de.DepartmentName}");
            }
            Console.WriteLine("-----Query sytaksisi");
            foreach (var de in DEQ)
            {
                Console.WriteLine($"{de.EmployeeID} , {de.EmployeeName} , {de.DepartmentName}");
            }
            #endregion
        }
        public void GroupJoinMethod()
        {
            #region
            List<Department> departments = new List<Department>() {
                new Department(1, "HR"),
                new Department(2,"O'quv bo'limi"),
                new Department(3,"Adminstratsiya")};

            List<Employee> employees = new List<Employee>()
            {
                new Employee(1,"Robiya",1),
                new Employee(2,"Laylo",2),
                new Employee(3,"Zahro",3),
                new Employee(4,"Hafiza",3),
                new Employee(5,"Omina",1),
                new Employee(6,"Odina",2),
                new Employee(7,"Hadicha",3),
                new Employee(8,"Fotima",3),
                new Employee(9,"Sanoat",1),
                new Employee(10,"Sevara",2),
                new Employee(11,"Dilnura",3),
                new Employee(12,"Malika",3),
            };

            var DE = departments.GroupJoin(
                employees,
                department=>department.DepartmentId,
                employee=>employee.DepartmentId,
                (departments, emp) => new
                {
                    departments.DepartmentId,
                    departments.DepartmentName,
                    employees=emp
                }
                );
            foreach ( var de in DE)
            {
                Console.WriteLine(de.DepartmentId+" "+de.DepartmentName);
                foreach( var emp in de.employees)
                {
                    Console.WriteLine($"{emp.EmployeeID} {emp.EmployeeName} {emp.DepartmentId}");
                }
            }
            #endregion
        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    public class Employee
    {
        public int EmployeeID { get; set; } 
        public string EmployeeName { get; set; }
        public int DepartmentId { get; set; }
        public Employee(int EmployeeId, string EmployeeName, int DepartmentId)
        {
            this.EmployeeID = EmployeeId;
            this.EmployeeName = EmployeeName;
            this.DepartmentId = DepartmentId;

        }
    };
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public Department(int DepartmentID, string name)
        {
            DepartmentId = DepartmentID;
            DepartmentName = name;
        }
    };
}
