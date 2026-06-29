public class Node
{
    public int Val;
    public Node Next;

    public Node(int val)
    {
        Val = val;
        Next = null;
    }
}

public class LinkedList
{
    private Node head;
    private Node tail;

    public LinkedList()
    {
        head = null;
        tail = null;
    }

    public int Get(int index)
    {
        Node cur = head;
        int i = 0;

        while (cur != null)
        {
            if (i == index)
                return cur.Val;

            cur = cur.Next;
            i++;
        }

        return -1;
    }

    public void InsertHead(int val)
    {
        Node node = new Node(val);

        node.Next = head;
        head = node;

        if (tail == null)
            tail = node;
    }

    public void InsertTail(int val)
    {
        Node node = new Node(val);

        if (head == null)
        {
            head = node;
            tail = node;
            return;
        }

        tail.Next = node;
        tail = node;
    }

    public bool Remove(int index)
    {
        if (head == null)
            return false;

        if (index == 0)
        {
            if (head == tail)
                tail = null;

            head = head.Next;
            return true;
        }

        Node cur = head;
        int i = 0;

        while (cur != null && i < index - 1)
        {
            cur = cur.Next;
            i++;
        }

        if (cur == null || cur.Next == null)
            return false;

        if (cur.Next == tail)
            tail = cur;

        cur.Next = cur.Next.Next;

        return true;
    }

    public List<int> GetValues()
    {
        List<int> result = new();

        Node cur = head;

        while (cur != null)
        {
            result.Add(cur.Val);
            cur = cur.Next;
        }

        return result;
    }
}