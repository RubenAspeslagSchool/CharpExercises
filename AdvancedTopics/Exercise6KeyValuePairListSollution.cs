using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopics
{
    internal class Exercise6KeyValuePairListSollution<T, U> : IEnumerable
    {
        private readonly List<(T key, U value)> _dictionary;

        #region Public properties
        public int Count => _dictionary.Count;
        public T[] Keys => _dictionary
                            .Select(d => d.key)
                            .ToArray();
        public U[] Values => _dictionary
                            .Select(d => d.value)
                            .ToArray();
        #endregion

        public Exercise6KeyValuePairListSollution()
        {
            _dictionary = new List<(T, U)>();
        }

        #region Methods
        public void Add(T key, U value)
        {
            _dictionary.Add((key, value));
        }

        public void Remove(T keyToRemove)
        {
            _dictionary.Remove(_dictionary.Find(d => d.key.Equals(keyToRemove)));
        }

        public void Clear()
        {
            _dictionary.Clear();
        }
        #endregion

        public IEnumerator GetEnumerator()
        {
            foreach ((T key, U value) in _dictionary)
            {
                yield return (key, value);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
