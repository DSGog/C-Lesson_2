// int n = 10;
int[] arr = { 4, 3, 5, 6, 1, 2, 8, 7, 9, 10 };
int i = 0;

while (i < arr.Length)
{
     if (arr[i] % 2 == 0)
    {
        System.Console.Write($"{arr[i]} ");
    }
    i = i + 1;
}
   