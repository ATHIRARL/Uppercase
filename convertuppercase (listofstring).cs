using System;
using System.Collections.Generic;	
using System.Linq;
public class Program
{
	public static void Main()
	{
	List<string> g= new List<string>();
		//List<string> c= new List<string>();
		for(int i=0;i<3;i++)
		{
			Console.WriteLine("string");
			string j=Console.ReadLine();
			g.Add(j);
		}
	var c=	stopg(g);
		foreach(var d in c)
		{
		Console.WriteLine(d);
		}
	}
	public static List<string> stopg(List<string> a)
	{
		//List<string> a= new List<string>();
		var b=a.Select(x=>x.ToUpper()).ToList();
		return b;
	}
}