public static class MysteryStack2 {
    private static bool IsFloat(string text) {
        return float.TryParse(text, out _); //parse string as float.
    }

    public static float Run(string text) {
        var stack = new Stack<float>();
        foreach (var item in text.Split(' ')) { //traverse array of the words in the string.
            if (item == "+" || item == "-" || item == "*" || item == "/") { //determine if the item is a arithmetic operator.
                if (stack.Count < 2) //If there are only two items in the stack, throw an error.
                    throw new ApplicationException("Invalid Case 1!");

                var op2 = stack.Pop(); // get the latest item
                var op1 = stack.Pop(); // then get the item before it.
                float res; //result variable
                if (item == "+") {
                    res = op1 + op2; //add the two items
                }
                else if (item == "-") {
                    res = op1 - op2; //subtract the two items
                }
                else if (item == "*") {
                    res = op1 * op2; // multiply them.
                }
                else {
                    if (op2 == 0)
                        throw new ApplicationException("Invalid Case 2!");

                    res = op1 / op2;
                }

                stack.Push(res); //push the result to the stack.
            }
            else if (IsFloat(item)) {
                stack.Push(float.Parse(item)); //add float to stack
            }
            else if (item == "") { //if its nothing do nothing
            }
            else {
                throw new ApplicationException("Invalid Case 3!");
            }
        }

        if (stack.Count != 1) // if the math could not be performed
            throw new ApplicationException("Invalid Case 4!");

        return stack.Pop(); //return the stack's single item.
    }
    //5 3 7 + *: 50
    //6 2 + 5 3 - /: 4
    //1 + 2 -: invalid case 1
    //1 0 /: invalid case 2
    //5 l: invalid case 3
    //1 1 1: invalid case 4
}