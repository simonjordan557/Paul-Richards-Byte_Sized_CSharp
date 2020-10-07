using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lesson_57_Library
{

    // Question 152: Changing the method header of GetEnumerable() would mean that the class no longer implements the interface as required.

    // Question 153: Apparently, a nested class being public is fine. i.e. a Student instance might contain an IEnumerable of Courses they attend.
    // And each Course might contain an IEnumerable of Students who attend. Nested classes aren't limited to just a certain enclosing class.

    // Question 154: I'm honestly a bit lost now - a lot of this code seems unnecessary, given the built-in functionality that already exists.
    // I guess it will just return null? 

    // I was right, as remaining = 0 right from the start, so MoveNext returns false and stops the IEnumerator.

    // 
    public class Bag<T> : IEnumerable<T>
    {
        private class BagEnumerator : IEnumerator<T>
        {
            private readonly Bag<T> bag;
            private Dictionary<T, int>.Enumerator baseEnumerator;
            private T current;
            private int remaining;

            public BagEnumerator(Bag<T> bag)
            {
                this.bag = bag; // bad use of variables.
                Reset();
            }

            public T Current
            {
                get
                {
                    return current;
                }
            }



            object IEnumerator.Current
            {
                get
                {
                    return current;
                }
            }

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                if (remaining > 0)
                {
                    remaining--;
                    return true; 
                }

                bool hasNext = baseEnumerator.MoveNext();
                if (hasNext)
                {
                    current = baseEnumerator.Current.Key;
                    remaining = baseEnumerator.Current.Value - 1;
                }

                return hasNext;
            }

            public void Reset()
            {
                baseEnumerator = bag.totals.GetEnumerator();
                current = default(T);
                remaining = 0;
            }
        }
        private Dictionary<T, int> totals;

        public Bag()
        {
            totals = new Dictionary<T, int>();
        }
        public int this[T item]
        {
            get
            {
                if (totals.ContainsKey(item))
                {
                    return totals[item];
                }

                return 0;
            }
        }

        public int Add(T item)
        {
            int count = 0;
            if (totals.ContainsKey(item))
            {
                count = totals[item];
            }

            else
            {
                count = 0;
            }

            count++;
            totals[item] = count;
            return count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new BagEnumerator(this);
        }

        public bool Remove(T item)
        {
            if (totals.ContainsKey(item))
            {
                int count = totals[item];
                count--;

                if (count == 0)
                {
                    totals.Remove(item);
                }

                else
                {
                    totals[item] = count;
                }
                return true;
            }

            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
