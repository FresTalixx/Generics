using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class MathOperations<T> where T : struct, INumber<T>
{
    public static T MaxFromThree(T num1, T num2, T num3)
    {
        T max = num1;
        if (max < num2) max = num2;
        if (max < num3) max = num3;

        return max;
    }

    public static T MinFromThree(T num1, T num2, T num3)
    {
        T min = num1;
        if (min > num2) min = num2;
        if (min > num3) min = num3;

        return min;
    }

    public static T SumOfArray(T[] arr)
    {
        T sum = T.Zero;

        foreach (T item in arr)
        {
            sum += item;
        }
        return sum;
    }
}



//Створіть generic-клас Стека. Реалізуйте стандартні методи та властивості для роботи стеку:
//pop;
//push;
//peek;
//count.



class GenericStack<T> where T: struct, INumber<T>
{
    public T[] stack = Array.Empty<T>();

    public void Push(T item)
    {
        stack = stack.Append(item).ToArray();
    }

    public T Pop()
    {
        T poppedElement = stack[stack.Length - 1];
        stack = stack.Take(stack.Count() - 1).ToArray();
        return poppedElement;
    }

    public T Peek()
    {
        return stack[stack.Length - 1];
    }

    public int Count()
    {
        return stack.Length;
    }
}


public class Alphabet : IEnumerable<char>
{
    char[] alphabet = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];
    public IEnumerator<char> GetEnumerator()
    {
        foreach (char c in alphabet)
        {
            yield return c;
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}


public static class ListSort<T> where T: struct
{
    public static List<T> FilterByTwoCriteria(List<T> list, Predicate<T> predicate1,
        Predicate<T> predicate2)
    {
        List<T> result = new List<T>();

        foreach (T item in list)
        {
            if (predicate1(item) && predicate2(item))
            {
                result.Add(item);
            }
        }
        return result;
    }
}

public class Resident
{
    public required string Name { get; set; }
    public required int Age { get; set; }
    public required string Job { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Job: {Job}";
    }
}


public class Apartment : IEnumerable<string>
{
    public required Resident[] Residents { get; set; }

    public IEnumerator<string> GetEnumerator()
    {
        foreach (var resident in Residents)
        {
            yield return resident.ToString();
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public override string ToString()
    {
        string finalString = "";
        foreach (var resident in Residents)
        {
            finalString += resident.ToString() + " ";
        }
        return finalString;
    }
}



public class Building : IEnumerable<string>
{

    public required Apartment[] Apartments { get; set; }

    public IEnumerator<string> GetEnumerator()
    {
        for (int i = 0; i < Apartments.Length; ++i)
        {
            yield return  $"Apartment {i + 1}: {Apartments[i].ToString()}";
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}


public interface IBook
{
    public string ReleaseDate { get; set; }
    public string Author { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
}


public class EBook : IBook
{
    public string ReleaseDate { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;

    public int FontSize { get; set; }

    public override string ToString()
    {
        return $"Author: {Author}, Release Date: {ReleaseDate}, Title: {Title}, Genre: {Genre}, Font Size: {FontSize}";
    }
}

public class PrintedBook : IBook
{
    public string ReleaseDate { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public bool isNew { get; set; }

    public override string ToString()
    {
        return $"Author: {Author}, Release Date: {ReleaseDate}, Title: {Title}, Genre: {Genre}, Is New: {isNew}";
    }
}

public class Library<T> : IEnumerable<T> where T: class, IBook
{
    public List<T> bookList = new List<T>();

    public void AddBook(T book)
    {
        bookList.Add(book);
    }

    public void RemoveBook(T book)
    {
        bookList.Remove(book);
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var book in bookList)
        {
            yield return book;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public List<T> SortBooksByCriteria(Predicate<T> criteria)
    {
        List<T> newBookList = new List<T>();

        foreach (var book in bookList)
        {
            if (criteria(book)) newBookList.Add(book);
        }

        return newBookList;
    }


}
