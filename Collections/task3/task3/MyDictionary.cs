using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class MyDictionary<TKey, TValue> : IEnumerable
    {
        private List<TKey> key;
        private List<TValue> value;

        public int Length { get; private set; }

        public MyDictionary()
        {
            key = new List<TKey>();
            value = new List<TValue>();
        }
        public TValue this[TKey i]
        {
            get
            {
                if (key.Contains(i))
                    return value[key.IndexOf(i)];
                else return default(TValue);
            }
            set
            {
                if (key.Contains(i))
                    this.value[key.IndexOf(i)] = value;
            }
        }
        public void Add(TKey k, TValue v)
        {
            if (!key.Contains(k))
            {
                key.Add(k);
                value.Add(v);
                Length++;
            }
        }
        public void Remove(TKey k)
        {
            if (key.Contains(k))
            {
                value.RemoveAt(key.IndexOf(k));
                key.Remove(k);
                Length--;
            }
        }
        public void RemoveAt(int i)
        {
            if (i < Length && i >= 0)
            {
                key.RemoveAt(i);
                value.RemoveAt(i);
                Length--;
            }
        }


        public IEnumerator GetEnumerator()
        {
            foreach (var item in value)
            {
                yield return item;
            }
        }

    }
}
