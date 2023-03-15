using System;
using System.Collections;

namespace Array;
public class Array : IEnumerable
{
    // Object
    // Type : Array
    private Object[] _InnerArray; // null
    private int index = 0;
    public int Count => index;  // Dizi kaç eleman var?
    public int Capacity => _InnerArray.Length;


    public Array()
    {
        _InnerArray = new Object[4]; // Block allocation
    }

    public Array(params Object[] init)
    {
        var newArray = new Object[init.Length];
        System.Array.Copy(init, newArray, init.Length);
        _InnerArray = newArray;
    }

    public void Add(Object item)
    {
        if(index==_InnerArray.Length)
        {
            DoubleArray(_InnerArray);
        }
        
        _InnerArray[index] = item;
        index++;
    }

    private void DoubleArray(object[] array)
    {
        var newArray = new Object[array.Length * 2];
        System.Array.Copy(array, newArray, array.Length);
        _InnerArray = newArray;
    }

    /// <summary>
    /// Week 1
    /// </summary>
    /// <param name="position"></param>
    /// <returns>
    ///     Verilen pozisyonda bulunan elemanı geri döndürür.
    ///     Eğer pozisyon sınırlar dışındaysa IndexOutOfRangeException hata fırlatır.
    /// </returns>
    /// <exception cref="NotImplementedException"></exception>
    public Object GetItem(int position)
    {
        // throw new NotImplementedException();
        if (position < 0 || position >= _InnerArray.Length)
            throw new IndexOutOfRangeException();
        return _InnerArray[position];
    }


    /// <summary>
    /// Week 2 - Implematation 1
    /// SetItem içerisinde verilen pozisyon değeri aralık dışarısında ise hata fırlatılmalı.
    /// </summary>
    /// <param name="position"></param>
    /// <param name="item"></param>
    public void SetItem(int position, Object item)
    {
        _InnerArray[position] = item;
    }

    /// <summary>
    /// Week 2 - Implementation 2 
    /// Remove işleminde girilen pozisyondaki eleman çıkarılmalıdır.
    /// Çıkarma işleminden sonra eleman geri döndürülmelidir.
    /// Çıkarılan elemanın yerine diğerleri kaydırılmalıdır.
    /// </summary>
    /// <param name="position"></param>
    /// <exception cref="NotImplementedException"></exception>
    public Object RemoveItem(int position)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    ///  Week - 1 Implementation 2
    /// </summary>
    /// <param name="p1"></param>
    /// <param name="p2"></param>
    public void Swap(int p1, int p2)
    {
        var temp = _InnerArray[p1];
        _InnerArray[p1] = _InnerArray[p2];
        _InnerArray[p2] = temp;
    }

    /// <summary>
    /// Week - 1 Implementation 3
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public int Find(Object item)
    {
        for (int i = 0; i < _InnerArray.Length; i++)
        {
            if (item.Equals(_InnerArray[i]))
            {
                return i;
            }
        }
        return -1;
    }

    /// <summary>
    /// Week 2 - Implementation 3
    /// Verilen değer aralındaki elemanlar kopyalanmalıdır.
    /// Geri dönüş değeri dizidir.
    /// Verilen pozisyon bilgileri kontrol edilmelidir.
    /// </summary>
    /// <returns></returns>


    public IEnumerator GetEnumerator()
    {
        return _InnerArray.GetEnumerator();
    }
}
