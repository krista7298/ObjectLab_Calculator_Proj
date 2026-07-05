/*******************************************************************
* Name: Krista Agustin
* Date: 07/05/2026
* Assignment SDC220 Calculator Project Phase #3
*
* Memory class.
* This class stores a single memory value and a collection of up to
* 10 integer values for calculator memory functions.
*/

using System.Collections.Generic;

public class Memory
{
    public double SingleValue { get; private set; }
    public bool HasSingleValue { get; private set; }

    private List<int> values = new List<int>();

    public void StoreSingleValue(double value)
    {
        SingleValue = value;
        HasSingleValue = true;
    }

    public void ClearSingleValue()
    {
        SingleValue = 0;
        HasSingleValue = false;
    }

    public List<int> GetValues()
    {
        return values;
    }

    public bool AddValue(int value)
    {
        if (values.Count < 10)
        {
            values.Add(value);
            return true;
        }

        return false;
    }

    public bool RemoveValue(int value)
    {
        return values.Remove(value);
    }

    public int GetCount()
    {
        return values.Count;
    }

    public int GetSum()
    {
        int total = 0;

        foreach (int value in values)
        {
            total += value;
        }

        return total;
    }

    public double GetAverage()
    {
        if (values.Count == 0)
        {
            return 0;
        }

        return (double)GetSum() / values.Count;
    }

    public int GetDifferenceFirstLast()
    {
        if (values.Count < 2)
        {
            return 0;
        }

        return values[0] - values[values.Count - 1];
    }

    public void ClearValues()
    {
        values.Clear();
    }
}

