using System;
using System.Collections.Generic;

public class StackOfStrings
{
    private List<string> data;

    public StackOfStrings()
    {
        this.data = new List<string>();
    }

    public void Push(string item)
    {
        this.data.Add(item);
    }

    public string Pop()
    {
        string result = data[data.Count - 1];

        this.data.RemoveAt(data.Count - 1);

        return result;
    }

    public string Peek()
    {
        return data[data.Count - 1];
    }

    public bool IsEmpty()
    {
        if (this.data.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string ToString()
    {
        return $"{string.Join(" ", this.data)}";
    }
}

