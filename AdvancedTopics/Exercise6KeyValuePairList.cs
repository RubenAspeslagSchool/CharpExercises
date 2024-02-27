using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace AdvancedTopics
{

    //		Exercise 6  (Generics, Tuples, Yield)
    //Create your own Generic Class KeyValuePairList who simulates the Dictionary Collection class.
    //Check this URL to know more about Dictionaries: http://bit.ly/38RZ2xh
    //Note: Do not make use of the Dictionary class!

    //Your class consists of these methods:
    // - Add
    // - Clear
    // - Remove
    //And these properties:
    // - Count
    // - Keys
    // - Values



    public class Exercise6KeyValuePairList<T, X>
	{
        
        public int Count
		{
			get { return Keys.Count; }

		}
		public List<T> Keys{ get;} = new List<T>();
		public List<X> Values{ get;} = new List<X>();


     
		public void Add(T key, X value) 
        {
         Keys.Add(key);
         Values.Add(value);   
        }
		public void Clear() 
        {
            Keys.Clear(); 
            Values.Clear();
        }
		public void Remove(T key) 
        {
            int index = Keys.IndexOf(key);
            Keys.RemoveAt(index);
            Keys.Remove(key);
        }

    }
}
