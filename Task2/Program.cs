const int Coefficient = 0;
const int Constant = 1;
const int X = 0;
const int Y = 0;
const int Line1 = 1;
const int Line2 = 2;
double[] lineData1 = InputLineData(Line1);
double[] lineData2 = InputLineData(Line2);
if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений
    y = {lineData1[Coefficient]}*x + {lineData1[Constant]} и 
    y = {lineData2[Coefficient]}*x + {lineData2[Constant]}");
    Console.Write($"имеет координаты ({coord[X]}, {coord[Y]}");
}

double Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    double resutl = Convert.ToDouble(value);
    return result
}

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[Coefficient] = Prompt($"Введите коэффициент для {numberOfLine} прямой >");
    lineData[Constant] = Prompt($"Введите коэффициент для {numberOfLine} прямой >");
    return lineData;
}
double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X] = (lineData1[Constant] - lineData2[Constant]) / (lineData2[Coefficient] - lineData1[Coefficient]);
    coord[Y] = (lineData1[Constant] - lineData2[Constant]) / (lineData2[Coefficient] - lineData1[Coefficient]);
    return coord;
}
bool ValidateLine(double[] lineData1, double[] lineData2)
{
    if (lineData1[Coefficient] == lineData2[Coefficient])
    {
        if (lineData1[Constant] == lineData2[Constant])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые не совпадают");
            return false;
        }
    }
    return true;
}