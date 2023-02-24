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
		
	int[] CountNum = new int[num];
	   
		for (int i=0;i<num;i++)
		{
		   CountNum[types[i]]++;
		}
		
	int Btype=0;
	int highest=CountNum[0];
	  
	    for(int i=0;i<num;i++)
	    {
	      if(highest<CountNum[i])
	     {
	       highest=CountNum[i];
	       Btype=i;
	     }
	    }
	 
	 for(int i=0;i<num;i++)
	   {
	     if(highest==CountNum[i])
	       {
	          if(Btype>i)Console.WriteLine("id="+i);
		
		     if(Btype<i)Console.WriteLine("id="+Btype); 
			}
			break;
	    }
		
		Console.WriteLine("id="+Btype);
	
	
}

// You can define other methods, fields, classes and namespaces here