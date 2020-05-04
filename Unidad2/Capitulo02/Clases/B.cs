using Clases;
using System;

public class B : A
{
	public B() : base("Instancia de B")
	{
	
	}

	void M4()
    {
		Console.WriteLine("Metodo del hijo invocado");
    }
}
