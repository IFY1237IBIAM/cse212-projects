public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value < Data)
        {
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data) // only insert if value is not equal
        {
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        // value == Data -> do nothing (prevents duplicates)
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
            if (value == Data)
        {
            return true; // We found the value
        }
        else if (value < Data)
        {
            // Look in the left subtree
            if (Left is null)
                return false; // No more nodes to search
            else
                return Left.Contains(value); // Recursive call
        }
        else // value > Data
        {
            // Look in the right subtree
            if (Right is null)
                return false;
            else
                return Right.Contains(value); // Recursive call
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;
        return 1 + Math.Max(leftHeight, rightHeight); // Replace this line with the correct return statement(s)
    }
}
