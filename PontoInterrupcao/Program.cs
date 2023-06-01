using System.Diagnostics;

int result = Fibonacci(6);
Console.Write(result);


static int Fibonacci(int num){
    Debug.WriteLine($"Entering {nameof(Fibonacci)} method.");
    Debug.WriteLine($"We are looking for the {num}th number");
    var n1 = 0;
    var n2 = 1;
    int sum;

    for(int cont = 2; cont <= num; cont++){
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
        Debug.WriteLineIf(sum == 1, $"sum is 1, n1 is {n1} and n2 is {n2}");
    }
    Debug.Assert(n2 == 5, "${The return value is not 5 and it should be.}");
    return num == 0 ? n1 : n2;
}