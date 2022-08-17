Console.Clear();
//Console.SetCursorPosition(10,4);
//Console.WriteLine("+");

int xA = 20;
int yA = 10;
int xB = 1;
int yB = 25;
int xC = 40;
int yC = 25;

Console.SetCursorPosition(xA,yA);
Console.WriteLine("-");

Console.SetCursorPosition(xB,yB);
Console.WriteLine("=");

Console.SetCursorPosition(xC,yC);
Console.WriteLine("*");

int x = xA, y=xB;
int count = 0;
while (count<1000)
{
    int n = new Random().Next(0,3); // [0;3) 0 1 2
    if (n == 0)
    {
        x=(x+xA)/2;
        y=(y+yA)/2;
    }

    if (n == 1)
    {
        x=(x+xB)/2;
        y=(y+yB)/2;
    }
    if (n == 2)
    {
        x=(x+xC)/2;
        y=(y+yC)/2;
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count=count+1;
}