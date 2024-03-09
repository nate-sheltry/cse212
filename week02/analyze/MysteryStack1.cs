public static class MysteryStack1 {
    public static string Run(string text) {
        var stack = new Stack<char>();
        foreach (var letter in text)
            stack.Push(letter); //fill the stack with the characters of the string

        var result = "";
        while (stack.Count > 0)
            result += stack.Pop(); // fill the result variable with the stack of characters

        return result; // return the result string.
    }
    //Returns should be the same as the inputs.
    // racecar: racecar
    // stressed: stressed
    // 
}