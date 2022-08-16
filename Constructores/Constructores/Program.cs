using Constructores;

// METODOS DE INSTANCIA --------------------------
CuentaBancaria cuenta1 = new CuentaBancaria("001", "Juan Perez", 100);
CuentaBancaria cuenta2 = new CuentaBancaria("002", "Lila Perez", 200);

// Llamando a los metodos depositar y retirar
Console.WriteLine("Depositar $70 en cuenta1");
cuenta1.Depositar(70);
Console.WriteLine(cuenta1.ToString());

Console.WriteLine("Retirar $20 en cuenta2");
cuenta2.Depositar(20);
Console.WriteLine(cuenta2);


// PROPIEDADES -------------------------
//CuentaBancaria cuenta = new CuentaBancaria();

//cuenta.Saldo = -5;
//Console.WriteLine("Saldo despues de primera asignacion: {0}", cuenta.Saldo);

//cuenta.Saldo = 10;
//Console.WriteLine("Saldo despues de segunda asignacion: {0}", cuenta.Saldo);