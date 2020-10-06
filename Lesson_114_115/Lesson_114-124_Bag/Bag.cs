using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_114_124_Bag
{
    public class Bag<T>
    {
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
    }

   
}
