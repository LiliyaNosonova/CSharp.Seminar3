//1. 2. Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// ввод данных с клавиатуры
// ax, bx, ay, by
// найти расстояние

int GetValue (string text)// метод получения данных
{    
    Console.WriteLine($"{text}; ");
    string getvalueStr = Console.ReadLine()!;
    int value = Convert.ToInt32(getvalueStr);
    return value;     
}

double Pifagor (int ax, int ay, int bx, int by) //метод рассчета расстояния по теореме Пифагорa
{
    return Math.Sqrt((bx - ax) * (bx - ax) + 
            Math.Pow(by - ay, 2));
}

int Ax = GetValue("Ax");
int Ay = GetValue("Ay");
int Bx = GetValue("Bx");
int By = GetValue("By");

double result = Pifagor (Ax, Ay, Bx, By);
System.Console.WriteLine(result);

