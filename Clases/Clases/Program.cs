using Clases;

//crear objeto de tipo rectangulo
Rectangulo rect = new Rectangulo();

rect.Base = 10;
rect.Altura = 5;

int area = rect.CalcularArea();
Console.WriteLine("rect: {0} x {1} = {2}", rect.Base, rect.Altura, area);

//sintaxis de inicializacion
Rectangulo rect2 = new Rectangulo { Base = 3, Altura = 8 };
int area2 = rect2.CalcularArea();
Console.WriteLine("rect2: {0} x {1} = {2}", rect2.Base, rect2.Altura, area2);