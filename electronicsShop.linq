<Query Kind="Program" />

void Main()
{
	int b=60;
	List<int> keyboards=new List<int> {40,50,60};
	List<int> drives=new List<int> {5,8,12};
	int max=0;
	for(int i=0;i<keyboards.Count;i++)
	{
	  for(int j=0;j<drives.Count;j++)
	  {
	   int add=keyboards[i]+drives[j];
	    if(add<=b)
		{
		  if(max<add) max=add;
		} 
	  }
	}
	
	
	if(max==0)
	Console.WriteLine(-1);
	else
	Console.WriteLine(max);
	
	
	
	
}

// You can define other methods, fields, classes and namespaces here
 