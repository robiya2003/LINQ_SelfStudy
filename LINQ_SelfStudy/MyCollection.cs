using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_SelfStudy
{
    public class MyCollection<T> : IEnumerable<T>
    {
        private readonly List<T> list=new();
        private  Func<T,bool> _predicate;

        public void ADD(T item)
        {
            list.Add(item);
        }
        public MyCollection<T> Where(Func<T,bool> predicate)
        {
            _predicate = predicate;
            return this;
        }
        public IEnumerator<T> GetEnumerator()  // GetEnumerator();  1 2 3 4 5 6 7 8 9 10
        {
            var ResultList = new List<T>();
            foreach (T item in list)
            {
                if (_predicate(item))
                {
                    ResultList.Add(item);
                }
            }
            return ResultList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
