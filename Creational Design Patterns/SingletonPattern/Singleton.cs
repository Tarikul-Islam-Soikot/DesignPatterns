using System;

public sealed class Singleton
{

	private readonly Singleton _instance;
	private static readonly object _lock = new object();

	private Singleton()
	{

	}

	public static Singleton Instance
	{
		get 
		{ 
			if(_instance == null)
			{
				if(_lock)
				{
					if(_instance ==  null)
					{
                        _instance = new Singleton();

                    }
				}

			}
		}
	}
}
