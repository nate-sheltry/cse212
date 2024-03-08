
using System;
using System.Collections.Generic;

Console.WriteLine("\n======================\nSimple Stack\n======================");

var stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
// 1, 2, 3
stack.Pop();
stack.Pop();
// 1
stack.Push(4);
stack.Push(5);
// 1, 4, 5
stack.Pop();
// 1, 4
stack.Push(6);
stack.Push(7);
stack.Push(8);
stack.Push(9);
// 1, 4, 6, 7, 8, 9
stack.Pop();
stack.Pop();
// 1, 4, 6, 7
stack.Push(10);
stack.Pop();
stack.Pop();
stack.Pop();
// 1, 4
stack.Push(11);
stack.Push(12);
// 1, 4, 11, 12
stack.Pop();
stack.Pop();
stack.Pop();
// 1
stack.Push(13);
stack.Push(14);
stack.Push(15);
stack.Push(16);
// 1, 13, 14, 15, 16
stack.Pop();
stack.Pop();
stack.Pop();
// 1, 13
stack.Push(17);
stack.Push(18);
// 1, 13, 17, 18
stack.Pop();
stack.Push(19);
stack.Push(20);
// 1, 13, 17, 19, 20
stack.Pop();
stack.Pop();
// 1, 13, 17

Console.WriteLine("Final contents:");
Console.WriteLine(String.Join(", ", stack.ToArray()));