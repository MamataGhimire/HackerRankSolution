<Query Kind="Program" />

void Main()
{
	List<int>PointOfHouse=new List<int>();
	List<int>PointOfTree=new List<int>();
	List<int>NoOfFruits=new List<int>();
	List<int>DistanceOfApple=new List<int>();
	List<int>DistanceOfOrange=new List<int>();
	
	Console.WriteLine("Enter the value of start and end point of house");
	for (int i=0;i<2;i++)
	{
	  int d=Convert.ToInt32(Console.ReadLine());
	  PointOfHouse.Add(d);
	}
	
	Console.WriteLine("Enter the  point of apple and orange tree");
	for (int i=0;i<2;i++)
	{
	  int p=Convert.ToInt32(Console.ReadLine());
	  PointOfTree.Add(p);
	}
	
	Console.WriteLine("how many apple and orange are fall down");
	for (int i=0;i<2;i++)
	{
	  int f=Convert.ToInt32(Console.ReadLine());
	  NoOfFruits.Add(f);
	}
	
	Console.WriteLine("Enter distance of falling apple");
	for (int i=0;i<NoOfFruits[0];i++)
	{
	  int z=Convert.ToInt32(Console.ReadLine());
	  DistanceOfApple.Add(z);
	}
	
	Console.WriteLine("Enter distance of falling orange");
	for (int i=0;i<NoOfFruits[1];i++)
	{
	  int o=Convert.ToInt32(Console.ReadLine());
	  DistanceOfOrange.Add(o);
	}
	int Apple=0;
	for (int i=0;i<NoOfFruits[0];i++)
	{
	 int Distance=DistanceOfApple[i]+PointOfTree[0];
	 
	 if(Distance>=PointOfHouse[0]&&Distance<=PointOfHouse[1])
	 {
	   Apple=Apple+1;
	 }
	}
	
	int Orange=0;
	for (int i=0;i<NoOfFruits[1];i++)
	{
	 int Distance=DistanceOfOrange[i]+PointOfTree[1];
	 
	 if(Distance<=PointOfHouse[1]&&Distance>=PointOfHouse[0])
	 {
	   Orange=Orange+1;
	 }
	}
	
	Console.WriteLine(Apple);
	Console.WriteLine(Orange);
	
	
}

// You can define other methods, fields, classes and namespaces here