
using System;
using System.Collections.Generic;

Console.WriteLine("\n======================\nSimple Queue\n======================");

var queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
// 1, 2, 3
queue.Dequeue();
queue.Dequeue();
// 3
queue.Enqueue(4);
queue.Enqueue(5);
// 3, 4, 5
queue.Dequeue();
// 4, 5
queue.Enqueue(6);
queue.Enqueue(7);
queue.Enqueue(8);
queue.Enqueue(9);
// 4, 5, 6, 7, 8, 9
queue.Dequeue();
queue.Dequeue();
// 6, 7, 8, 9
queue.Enqueue(10);
// 6, 7, 8, 9, 10
queue.Dequeue();
queue.Dequeue();
queue.Dequeue();
// 9, 10
queue.Enqueue(11);
queue.Enqueue(12);
// 9, 10, 11, 12
queue.Dequeue();
queue.Dequeue();
queue.Dequeue();
// 12
queue.Enqueue(13);
queue.Enqueue(14);
queue.Enqueue(15);
queue.Enqueue(16);
// 12, 13, 14, 15, 16
queue.Dequeue();
queue.Dequeue();
queue.Dequeue();
// 15, 16
queue.Enqueue(17);
queue.Enqueue(18);
// 15, 16, 17, 18
queue.Dequeue();
// 16, 17, 18
queue.Enqueue(19);
queue.Enqueue(20);
// 16, 17, 18, 19, 20
queue.Dequeue();
queue.Dequeue();
// 18, 19, 20

Console.WriteLine("Final contents:");
Console.WriteLine(String.Join(", ", queue.ToArray()));