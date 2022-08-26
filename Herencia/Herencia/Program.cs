using Herencia;

Persona p = new Persona("Silvi", 38);
p.Saludar();

Empleado e = new Empleado("John", 29, "Ventas", 10000);
e.Saludar();
e.Trabajar();
Console.WriteLine(e);

Console.WriteLine("\nReto:");

Estudiante estudiante = new Estudiante("Mike", 18, 15.20, "Quinto");
estudiante.Saludar();
estudiante.IrAClase();
estudiante.Estudiar();
Console.WriteLine(estudiante);