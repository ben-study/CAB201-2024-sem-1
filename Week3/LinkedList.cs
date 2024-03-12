namespace Week3;

/// <summary>
/// Node class for the linked list
/// </summary>
public class Node
{
    public Node Next; // Reference to the next node in the list
    public double Value; // Value of the node

    /// <summary>
    /// Constructor for the Node class that sets the value of the node
    /// </summary>
    /// <param name="value"></param>
    public Node(double value)
    {
        Value = value;
        Next = null;
    }
}

public class LinkedList

{
    public Node First; // Reference to the first node in the list
    private Node last; // Reference to the last node in the list

    /// <summary>
    /// Method to check if the linked list is empty
    /// </summary>
    /// <returns></returns>
    public bool IsEmpty()
    {
        return First == null;
    }

    /// <summary>
    /// Constructor for the LinkedList class that sets the first node to null
    /// because the list is empty
    /// </summary>
    public LinkedList()
    {
        First = null;
    }

    /// <summary>
    /// Method to add a new node to the linked list
    /// </summary>
    /// <param name="data"></param>
    public void Add(double data)
    {
        Node newNode = new Node(data);
        if (IsEmpty()) First = newNode;
        else last.Next = newNode;
        last = newNode;
    }

    /// <summary>
    /// Method to to get the sum of the values in the linked list 
    /// </summary>
    /// <returns></returns>
    public double Sum()
    {
        double sum = 0;
        Node current = First;
        while (current != null)
        {
            sum += current.Value;
            current = current.Next;
        }

        return sum;
    }
}