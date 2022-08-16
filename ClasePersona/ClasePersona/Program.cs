using ClasePersona;

Persona persona1 = new Persona("Juan", "Perez", 28);
Persona persona2 = new Persona("Luis", "Pereira", 26);

persona1.Saludar();
persona2.Saludar();

//Comprobar la validacion de la edad:
persona1.Edad = -10;
Console.WriteLine(persona1);