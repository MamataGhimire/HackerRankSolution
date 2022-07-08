<Query Kind="Program" />

void Main()
{
	 Console.WriteLine("number of Candels");
	 int number=Convert.ToInt32(Console.ReadLine());
	 Console.WriteLine("heights of Candels");
	 List<int>candles=new List<int>();
	 for(int i=0;i<number;i++)
	 { 
	   int height=Convert.ToInt32(Console.ReadLine());
	   candles.Add(height);
	 }
	 int highest=candles[0];
	
	 for(int i=0;i<number;i++)
	 {
	  if(highest<candles[i])
	 {
	  highest=candles[i];
	 }
	 }
	 int Count=0;
	 for(int j=0;j<number;j++)
	 {
	  if(highest==candles[j])
	  Count=Count+1;
	 }
	 
	 Console.WriteLine(Count);
	 
}

