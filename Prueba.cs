class Prueba
{
	static void Main()
	{
		int r=Operaciones.ObtenerFactorial(5);
		Consola.EscribeTexto("El factorial de 5 es: ");
		Consola.EscribeNumero(r);  
	}
}

//para referenciar los objetos de la bilioteca
// csc /r:biblioteca.dll Prueba.cs
// Prueba.exe
