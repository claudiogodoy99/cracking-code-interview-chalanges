using BenchmarkDotNet.Running;
using data_structures;
using Microsoft.Diagnostics.Runtime;
using Microsoft.Diagnostics.Tracing.Parsers.Clr;
using static data_structures.LinkedListChalange;

//BenchmarkRunner.Run<LabHashTable>();
//LabHashTable.ExempleWithHash();
//LabHashTable.ExempleWithOutHash();


//Console.WriteLine(Strings.IsAllUnic("Godoy"));
//Console.WriteLine(Strings.IsAllUnic("Claudio"));




//Strings.IsAReplaceEditOrInsert("pale", "pales");
//Strings.IsAReplaceEditOrInsert("pales", "paled");
//Strings.IsAReplaceEditOrInsert("paled", "pale");
//Strings.IsAReplaceEditOrInsert("one", "other");

//Strings.CompressAZ("twwwwo");

//Matrix.Transform(matrix);

//ArrayChalange.Rotate(new int[] { 1, 2, 3, 4, 5 });


//first = Particionando(first, 5);



//RemoveMidlle(first);



//foreach (var item in link) { 

//    Console.WriteLine(item);
//}


//Console.WriteLine(Strings.URLReplaceSpaces("o cav s "));

//RunRotateMatrix();

//LinkedLists();

//Permutation();

//TBinarySearh();

//LongCommonString();

//FirstElementKTime();

sort012s();

void sort012s(){

    int[] ins= new int[5] {0,1,1,0,2 };

    ArrayChalange.Sort012s(ins);

    for (int i = 0; i < ins.Length; i++)
    {
        Console.WriteLine(ins[i]);
    }
    
}

void FirstElementKTime() {
    int[] ints = { 1, 7, 4, 3, 4, 8, 7 };
    int k = 2;

    Console.WriteLine(BinarySeach.firstElementKTime(ints,ints.Length, k));
}

void LongCommonString()
{
    string[] strings = new string[] { "geeksforgeeks", "geezer", "d", "geeks", "geek" };

    var returnd = BinarySeach.longestCommonPrefix(strings, strings.Length);

    Console.WriteLine(returnd);
}

void TBinarySearh()
{
    int[] arr = new int[] { 1, 2, 6, 8, 9 };
    //long[] b = new long[] { 1, 2, 6, 8, 9 };

    var index = BinarySeach.Search(arr, 5, 6);
    Console.WriteLine(index);
    Console.WriteLine(arr[index]);

    //Console.Write(BinarySeach.check(b, arr, arr.Length) );
}

void Permutation() {
    Console.WriteLine(Strings.IsPermutation("aaaaaa", "bbbbbb"));
    Console.WriteLine(Strings.IsPermutation("abc", "cbaa"));
    Console.WriteLine(Strings.IsPermutation("god", "dog"));
}

void LinkedLists() {

    var first = new node(10);

    first.next = new node(8);
    first.next.next = new node(9);
    first.next.next.next = new node(5);
    first.next.next.next = new node(5);
    first.next.next.next.next = new node(3);
    first.next.next.next.next.next = new node(10);

    RemoveDuplicates(first);


    while (first != null)
    {

        Console.WriteLine(first.val);

        first = first.next;
    }

}

void RunRotateMatrix() {

    int[][] matrix = new int[][] {
        new int[] { 1,1,1, 1 },
        new int[] { 0,0,0, 0 },
        new int[] { 0,0,0, 0 },
        new int[] { 0,0,0, 0 }
    };

    Matrix.Rotate(matrix);

    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = 0; j < matrix[0].Length; j++)
        {
            Console.Write(matrix[i][j]);
        }
        Console.WriteLine("");
    }
}