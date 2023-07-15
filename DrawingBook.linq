<Query Kind="Program" />

void Main()
{
    //flipping from index page..
	Console.WriteLine("number of pages");
	int TotPages=Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("your page number");
	int Page=Convert.ToInt32(Console.ReadLine());
	int from_front=0;
	
	  for (int i=1;i<=TotPages;i++)
	   {
	     if (i==Page)
	      {
		   break;
	      }
	     if(i%2!=0)
	      {
	       from_front=from_front+1;
	      }
	   }
	
//flipping from last..
	int from_last=0;
	if (TotPages%2==0)
	{
	 for(int i=TotPages;i>=1;i--)
	  {
	  if (i==Page)
	   {
	     break;
	   }
	  if(i%2!=0)
	   {
	   from_last=from_last+1;
	   }
	  }
	}
	
	
	if (TotPages%2!=0)
	{
	 for(int i=TotPages;i>=1;i--)
	{
	 if (i==Page)
	   {
         break;
	   }
	 if(i%2==0)
	   {
	   from_last=from_last+1;
	   }
	  }
	}
	
	if(from_last>from_front) Console.WriteLine("you need to flip"+" "+from_front +" time");
	if(from_last<from_front) Console.WriteLine("you need to flip"+" "+from_last +" time");
	
	
}

// You can define other methods, fields, classes and namespaces here