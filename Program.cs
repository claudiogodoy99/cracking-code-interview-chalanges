using BenchmarkDotNet.Running;
using data_structures;
using Microsoft.Diagnostics.Runtime;
using static data_structures.LinkedListChalange;

//BenchmarkRunner.Run<LabHashTable>();
//LabHashTable.ExempleWithHash();
//LabHashTable.ExempleWithOutHash();


//Console.WriteLine(Strings.IsAllUnic("Godoy"));
//Console.WriteLine(Strings.IsAllUnic("Claudio"));

Console.WriteLine(Strings.IsPermutation("aaaaaa", "bbbbbb"));
Console.WriteLine(Strings.IsPermutation("abc", "cbaa"));
Console.WriteLine(Strings.IsPermutation("god", "dog"));

//Console.WriteLine(Strings.URLReplaceSpaces("o cav   "));

//Strings.IsAReplaceEditOrInsert("pale", "pales");
//Strings.IsAReplaceEditOrInsert("pales", "paled");
//Strings.IsAReplaceEditOrInsert("paled", "pale");
//Strings.IsAReplaceEditOrInsert("one", "other");

//Strings.CompressAZ("twwwwo");

//int[][] matrix = new int[][] {
//    new int[] { 1,1,1, 1 },
//    new int[] { 0,1,1, 0 },
//    new int[] { 0,1,1, 0 },
//    new int[] { 0,1,1, 0 }
//};

//Matrix.Rotate(matrix);

//Matrix.Transform(matrix);

//ArrayChalange.Rotate(new int[] { 1, 2, 3, 4, 5 });

//var first = new node(10);

//first.next = new node(8);
//first.next.next = new node(9);
//first.next.next.next = new node(5);
//first.next.next.next = new node(6);
//first.next.next.next.next = new node(3);
//first.next.next.next.next.next = new node(2);


//first = Particionando(first, 5);

//RemoveDuplicates(first);

//RemoveMidlle(first);

//while (first != null)
//{

//    Console.WriteLine(first.val);

//    first = first.next;
//}


//foreach (var item in link) { 

//    Console.WriteLine(item);
//}

//for (int i = 0; i < matrix.Length; i++)
//{
//    for (int j = 0; j < matrix[0].Length; j++)
//    {
//        Console.Write(matrix[i][j]);
//    }
//    Console.WriteLine("");
//}