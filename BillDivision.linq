<Query Kind="Program" />

void Main()
{
   //for 4 items....
   List<int>bill=new List<int>();
   Console.WriteLine("price of item");
   for(int i=0;i<4;i++)
   {
     int price=Convert .ToInt32(Console.ReadLine());
	 bill.Add(price);
   }
  
   Console.WriteLine("index of the item Anna doesn't eat ");
    int decline=Convert .ToInt32(Console.ReadLine());
	
   Console.WriteLine("the amount of money that Anna contributed to the bill");
    int amount=Convert .ToInt32(Console.ReadLine());
	
	int total=0;
	
	for(int i=0;i<bill.Count;i++)
	{
	  if(i!=decline)
	  {
	     total=bill[i]+total;
	  }
	}
	int anna_pay=total/2;
	if (anna_pay==amount)
	{
	  Console.WriteLine("correct");
	}
	else
	{
	  int back=bill[decline]/2;
	  Console.WriteLine(back);
	}
}

// You can define other methods, fields, classes and namespaces here