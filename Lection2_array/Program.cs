/* поиск наибольшего функция + массив

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
// index         0  1  2  3  4  5  6   7   8
int[] array1 = { 1, 2, 3, 5, 4, 7, 55, 55, 4 };

int maxFin = Max(
    Max(array1[1], array1[2], array1[3]),
    Max(array1[4], array1[5], array1[6]),
    Max(array1[7], array1[8], array1[0])
);



Console.Write(maxFin);

*/

//-------------------------------------------------------------


// найти первый (мало ли их несколько с таким значением) индекс определённого значения из n элементов массива

/*int[] array = { 1, 5, 4, 8, 76, 5, 2, 1, 76 };
int find = 76;
int n = array.Length;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.Write(index);
        break;
    }
    index++;
}
*/

//метод создающий массив из случайных чисел (arrayFill)
// и метод выводящий этот массив (printArray)

void arrayFill(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(1, 10);
        index++;
    }
}

void printArray(int[] numbers2)
{
    int length = numbers2.Length;
    int position = 0;
    while (position < length)
    {
        Console.WriteLine(numbers2[position]);
        position++;
    }
}

//метод который находит какой індекс у заданного пользователем значенія
int findIndex(int[] numbers, int userNumber)
{
    int count = numbers.Length;
    int index = 0;
    int position = -1;

    while(numbers.Length > index)
    {
        if(numbers[index] == userNumber)
        {
            position = index;
            break;
        }
        index++;    
    }
    return position;
}

int[] array77 = new int[10]; //задаем кол-во эл-ов массива

 arrayFill(array77); //создаём массів функцией аргументом которой является массив
 printArray(array77); //показываем эту функцию на экран


Console.WriteLine("enter numbers");
int userNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int pos = findIndex(array77, userNumber);
Console.WriteLine(pos);
