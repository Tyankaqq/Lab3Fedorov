
int r = 546;

int a = r / 100;

int b = r / 10 % 10;

int c = r % 10;

int res = b * 100 + a * 10 + c;

Console.WriteLine($"Число x равняется: {res}");