using DSA_Practices.DSA.Implementations;
using DSA_Practices.LeetCode.Implementations;

var test = new Array_Day1(3);

test.arr = [1,2, 3];

test.IterateArray();

Console.WriteLine($"Size Method: {test.Size()}");

Console.WriteLine($"IsEmpty Method: {test.IsEmpty()}");

Console.WriteLine($"IndexOf Method: {test.IndexOf(3)}");

Console.WriteLine($"Contains Method: {test.Contains(4)}");

Console.WriteLine($"Add Method: {test.Add(4)}");

test.IterateArray();

test.RemoveAt(3);

test.IterateArray();

Console.WriteLine($"Remove Method: {test.Remove(0)}");

test.IterateArray();

var testConcatArray = new ConcatentationArray();
testConcatArray.arr = [1, 2, 1];
int[] result = testConcatArray.GetConcatenation(testConcatArray.arr);

for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}