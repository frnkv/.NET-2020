using System;
using Clases;

public class B : Clases.A
{
	public B() : base("Instancia de B")
	{
	
	}

	void M4()
    {
		Console.WriteLine("Metodo del hijo invocado");
    }
}
