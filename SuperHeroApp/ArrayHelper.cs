using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroApp
{
    public static class ArrayHelper
    {

        public static T[] Append<T>(this T[] array, T item)
        {
            List<T> list = new List<T>(array);
            list.Add(item);

            return list.ToArray();
        }


        public static T[] RemoveAtPosition<T>(this T[] array, int position)
        {
            List<T> list = new List<T>(array);
            list.RemoveAt(position);

            return list.ToArray();
        }

        public static string[] RemoveByName( string[] array, string position) 
        { List<string> list = new List<string>(array); 
            list.Remove(position); 
            return list.ToArray(); 
        }

    }

 
}
