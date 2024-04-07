public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public void InsertSwap(int value) {
        if (value > Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        if(Data == value)
            return true;
        if(value > Data)
            return Right is not null ? Right.Contains(value):false;
        else if (value < Data)
            return Left is not null ? Left.Contains(value):false;
        else 
            return false;
    }

    public int GetHeight() {
        // TODO Start Problem 4
        var leftHeight = 0;
        var rightHeight = 0;
        if(Right is not null)
            rightHeight = Right.GetHeight();
        if(Left is not null)
            leftHeight = Left.GetHeight();
        return Math.Max(leftHeight, rightHeight) + 1; // Replace this line with the correct return statement(s)
    }
}