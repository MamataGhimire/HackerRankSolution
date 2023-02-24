<Query Kind="Program" />

void Main()
{
	Console.WriteLine("number of bird");
	int num=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the types of birds");
		List<int>types=new List<int>();
		for(int i=0;i<num;i++)
		{
		  int ty=Convert.ToInt32(Console.ReadLine());
		  types.Add(ty);
		}
		
		int max=types[0];
		
		for(int i=0;i<num;i++)
		{
		   if(max<types[i])
		   {
		     max=types[i];
		   }
		}
		    
	int[] CountNum = new int[num];
	    for (int i=0;i<num;i++)
		{
		  CountNum[types[i]]= CountNum[types[i]]++;
		  Console.WriteLine(CountNum[types[i]]);
		}
		
		int highest=CountNum[0];
	
	 for(int i=0;i<num;i++)
	 {
	  if(highest<CountNum[i])
	 {
	  highest=CountNum[i];
	 }
	 }
	 
	 for(int i=0;i<num;i++)
	 {
	  if(highest==CountNum[i])
	  {
	    if(highest>types[i])   Console.WriteLine("id="+types[i]);
		
		else Console.WriteLine("id="+highest);
	  }
	 }
	
	
}

// You can define other methods, fields, classes and namespaces here