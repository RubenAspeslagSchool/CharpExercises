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
        private Dictionary<T, X> _dict = new Dictionary<T, X>();
        public int Count
		{
			get { return _dict.Count; }

		}
		public List<T> Keys
		{
			get { return _dict.Keys.ToList(); }
		}
		public List<X> Values
		{
			get { return _dict.Values.ToList(); }
		}


        // I use _dict (private field) in methods even if it's a bad practice, because IDK if there is an alternative in this case
        // Is there a better way to solve this?
		public void Add(T key, X value) { _dict.Add(key, value); }
		public void Clear() { _dict.Clear(); }
		public void Remove(T key) { _dict.Remove(key);}

    }
}
