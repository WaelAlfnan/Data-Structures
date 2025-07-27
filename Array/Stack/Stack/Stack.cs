using System;

/// <summary>
/// Stack implementation using an array.
/// </summary>
public class Stack<T>
{
    private T[] _items;
    private int _top;
    private const int DefaultCapacity = 10;

    public Stack(int capacity = DefaultCapacity)
    {
        if (capacity <= 0)
            throw new ArgumentException("Capacity must be greater than zero.");
        _items = new T[capacity];
        _top = -1;
    }

    /// <summary>
    /// Adds an item to the top of the stack.
    /// </summary>
    public void Push(T item)
    {
        if (_top == _items.Length - 1)
            Resize();
        _items[++_top] = item;
    }

    /// <summary>
    /// Removes and returns the item at the top of the stack.
    /// </summary>
    public T Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty.");
        T item = _items[_top];
        _items[_top--] = default(T); // Clear reference
        return item;
    }

    /// <summary>
    /// Returns the item at the top of the stack without removing it.
    /// </summary>
    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty.");
        return _items[_top];
    }

    /// <summary>
    /// Returns true if the stack is empty.
    /// </summary>
    public bool IsEmpty()
    {
        return _top == -1;
    }

    /// <summary>
    /// Returns the number of items in the stack.
    /// </summary>
    public int Size()
    {
        return _top + 1;
    }

    /// <summary>
    /// Doubles the capacity of the internal array.
    /// </summary>
    private void Resize()
    {
        int newCapacity = _items.Length * 2;
        T[] newArray = new T[newCapacity];
        Array.Copy(_items, newArray, _items.Length);
        _items = newArray;
    }
} 