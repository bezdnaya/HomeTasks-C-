Console.WriteLine ("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
int index = 2;
while (index <= N)
{
    Console.Write(index+ " ");
index = index + 2;
}