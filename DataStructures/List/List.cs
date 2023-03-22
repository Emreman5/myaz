using System.Collections;

namespace List
{
    public class List<T> : IEnumerable<T>
    {
        private T[] _list;

        private int index = 0;

        public int Capacity => _list.Length;

        public int Count => index;

        public List()
        {
            _list = new T[4];
        }

        /// <summary>
        /// Week 3 - Listenin sonuna eleman ekler.
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void DoubleList(T[] list)
        {
            var newList = new T[list.Length * 2];
            System.Array.Copy(list, newList, _list.Length);
            _list = newList;
        }

        /// <summary>
        /// Week 3 - Listenin sonuna verilen elemanları ekler.
        /// </summary>
        /// <param name="collection"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void AddRange(IEnumerable<T> collection)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Week 3 - Listeden verilen eleman çıkartılır.
        /// Eğer eleman listede bulunursa True değeri döndürülür.
        /// Eleman listede yoksa False geri döndürülür.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void HalfList(T[] list)
        {
            var newList = new T[list.Length / 2];
            System.Array.Copy(list, newList, newList.Length);
            _list = newList;
        }

        /// <summary>
        /// Week 3 - Verilen indeksdeki eleman çıkartılır.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Week 3 - Verilen dizi ile kesişim değerlerini geri döndürür.
        /// </summary>
        /// <param name="collection"></param>
        /// <exception cref="NotImplementedException"></exception>
        public T[] InterSect(IEnumerable<T> collection)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Week 3 - Verilen dizi ile birleşimleri geri döndürür.
        /// </summary>
        /// <param name="collection"></param>
        /// <exception cref="NotImplementedException"></exception>
        public T[] Union(IEnumerable<T> collection)
        { 
            throw new NotImplementedException();
            
        }

        /// <summary>
        /// Week 3 - Verilen liste elemanlarının hariç olanları geri döndürür.
        /// </summary>
        /// <param name="collection"></param>
        /// <exception cref="NotImplementedException"></exception>
        public T[] Except(IEnumerable<T> collection)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.Take(index).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}