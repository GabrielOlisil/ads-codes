using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

class Triangulo
{
    int a = 3;
    int b = 4;
    int c = 5;

    public void CalculoArea()
    {
        var perimetro = (a + b + c) / 2;

        var area = Math.Sqrt(perimetro * (perimetro - a) * (perimetro - b) * (perimetro - c));

        Console.WriteLine(area);
    }
}
