using System.Collections;

namespace LINQ_SelfStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //MyCollection<int> collection = new MyCollection<int>();
            //collection.ADD(1);
            //collection.ADD(2);
            //collection.ADD(3);
            //collection.ADD(4);
            //collection.ADD(5);
            //collection.ADD(6);
            //collection.ADD(7);
            //collection.ADD(8);
            //collection.ADD(9);
            //collection.ADD(10);
            //collection.ADD(11);
            //collection.ADD(12);
            //var lst = collection.Where(x => x % 2 == 1);
            //Console.WriteLine("BIRINCHI");
            //foreach (var x in lst)
            //{
            //    Console.WriteLine(x);
            //}
            //collection.ADD(1);
            //collection.ADD(2);
            //collection.ADD(3);
            //collection.ADD(4);
            //collection.ADD(5);
            //collection.ADD(6);
            //collection.ADD(7);
            //collection.ADD(8);
            //collection.ADD(9);
            //collection.ADD(10);
            //collection.ADD(11);
            //collection.ADD(12);
            //Console.WriteLine("IKKINCHI");
            //foreach (var x in lst)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion

            LinqClass linqClass = new LinqClass();
            linqClass.GroupJoinMethod();
        }
    }
}
