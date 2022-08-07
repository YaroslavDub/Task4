// See https://aka.ms/new-console-template for more information
Console.Write("введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i = 2;
if (a > 0) {
    while (i <= a) {
        Console.WriteLine(i);
        i += 2;
    }
}
else if (a < 0 && a % 2 == 0){
    while (a <= i-4) {
        Console.WriteLine (a);
        a += 2;
    }
}
else {
    a += 1;
    while (a <= i-4) {
        Console.WriteLine (a);
        a += 2;
    }
}