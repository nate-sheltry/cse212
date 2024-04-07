using System.Collections;
using Microsoft.VisualBasic;

public class BinarySearchTree : IEnumerable<int> {
    private Node? _root;

    /// <summary>
    /// Insert a new node in the BST.
    /// </summary>
    public void Insert(int value) {
        // Create new node
        Node newNode = new Node(value);
        // If the list is empty, then point both head and tail to the new node.
        if (_root is null)
            _root = newNode;
        // If the list is not empty, then only head will be affected.
        else if(!_root.Contains(value))
            _root.Insert(value);
    }
    public void InsertSwap(int value) {
        // Create new node
        Node newNode = new Node(value);
        // If the list is empty, then point both head and tail to the new node.
        if (_root is null)
            _root = newNode;
        // If the list is not empty, then only head will be affected.
        else if(!_root.Contains(value))
            _root.InsertSwap(value);
    }

    /// <summary>
    /// Check to see if the tree contains a certain value
    /// </summary>
    /// <param name="value">The value to look for</param>
    /// <returns>true if found, otherwise false</returns>
    public bool Contains(int value) {
        return _root != null && _root.Contains(value);
    }

    /// <summary>
    /// Yields all values in the tree
    /// </summary>
    IEnumerator IEnumerable.GetEnumerator() {
        // call the generic version of the method
        return GetEnumerator();
    }

    /// <summary>
    /// Iterate forward through the BST
    /// </summary>
    public IEnumerator<int> GetEnumerator() {
        var numbers = new List<int>();
        TraverseForward(_root, numbers);
        foreach (var number in numbers) {
            yield return number;
        }
    }

    private void TraverseForward(Node? node, List<int> values) {
        if (node is not null) {
            TraverseForward(node.Left, values);
            values.Add(node.Data);
            TraverseForward(node.Right, values);
        }
    }

    /// <summary>
    /// Iterate backward through the BST.
    /// </summary>
    public IEnumerable Reverse() {
        var numbers = new List<int>();
        TraverseBackward(_root, numbers);
        foreach (var number in numbers) {
            yield return number;
        }
    }

    private void TraverseBackward(Node? node, List<int> values) {
        // TODO Problem 3
        if(node is not null){
            TraverseBackward(node.Right, values);
            values.Add(node.Data);
            TraverseBackward(node.Left, values);
        }
    }

    /// <summary>
    /// Get the height of the tree
    /// </summary>
    public int GetHeight() {
        if (_root is null)
            return 0;
        return _root.GetHeight();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public bool? VerifyTree(){
        if(_root is null)
            return true;
        var sortedValues = new List<int>();
        foreach (int value in Reverse()) {
            sortedValues.Add(value); // 10, 7, 6, 5, 4, 3, 1
        }

        return VerifyTreeProcess(_root, sortedValues[sortedValues.Count-1], sortedValues[0]);
    } 
    private bool? VerifyTreeProcess(Node? node, int minValue, int maxValue){
        if(node is null){
            return true;
        }
        if(node.Data > maxValue || node.Data < minValue)
            return false;
        
        bool? isValidLeft = null;
        bool? isValidRight = null;

        isValidLeft = VerifyTreeProcess(node.Left, minValue, node.Data);
        isValidRight = VerifyTreeProcess(node.Right, node.Data, maxValue);
        
        return (isValidLeft is true && isValidRight is true);
    }

    public override string ToString() {
        return "<Bst>{" + string.Join(", ", this) + "}";
    }
}