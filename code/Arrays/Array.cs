using System.Text;

namespace Arrays;

using SystemArray =  System.Array;

/// <summary>
/// Managed array as exercice per Mode Algos and Structure course.
/// It shall follow the course being an array of int
/// Extra challenge could be to use generics to have it compatible with any type. (But let's focus on ints for now)
/// </summary>
public class Array
{
    private int[] array;
    /// <summary>
    /// As we can allocate ahead for a certain length,
    /// insert method shall now the index to which it corresponds.
    /// 0 is an acceptable value and thus cannot be used to check if a slot has been valued already
    /// </summary>
    private int insertCounter = 0;

    public int Size => array.Length;

    /// <summary>
    /// Create a new array and allocate slots for a few items
    /// </summary>
    /// <param name="length"></param>
    public Array(int length = 0)
    {
        array = new int[length];
    }

    /// <summary>
    /// Inserts a value in the table sequentially
    /// Can resize the internal array to insert new elements when all allocated slots have been valued
    /// </summary>
    /// <param name="item"></param>
    public void Insert(int item)
    {
        if (insertCounter < array.Length)
        {
            array[insertCounter] = item;
        }
        else
        {
            ResizeAndInsert(item);
        }

        insertCounter++;
    }

    private void ResizeAndInsert(int item)
    {
        int newSize = array.Length + 1;
        SystemArray.Resize(ref array, newSize);
        array[newSize-1] = item;
    }

    public void RemoveAt(int index)
    {
        for (int i = index; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        
        SystemArray.Resize(ref array, array.Length - 1);
    }

    public int IndexOf(int item)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == item) return i;
        }
        
        // -1 means it wasn't found in the array
        return -1; 
    }

    /// <summary>
    /// Represents the array values comma separated
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        if (array.Length == 0) return string.Empty;
        
        StringBuilder sb = new StringBuilder();
        
        for (int i = 0; i < array.Length;i++)
        {
            if (i>0) sb.Append(", ");
            sb.Append(array[i]);
        }
        
        return sb.ToString();
    }

}