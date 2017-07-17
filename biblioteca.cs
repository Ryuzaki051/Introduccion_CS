public class Operaciones
{
	pubic static int ObtenerFactorial(int n){
		int resultado=1;
		for(int i=2;i<n;i++){
			resultado=resultado*1;
		}
		return resultado;
	}
}

public class Consola
{
	public static void EscribeTexto(string texto){
		System.Console.WriteLine(texto);
	}
	public static void EscribeNumero(int numero){
		System.Console.WriteLine(numero);
	}
}

// Para poder interpretar que este archivo es una libreria
// csc /t:library biblioteca.cs => biblioteca.dll