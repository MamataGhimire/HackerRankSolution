<Query Kind="Program" />

 void Main()
{  
    Console.WriteLine("Enter the no.of bar of chocolate");
	int L=Convert .ToInt32(Console.ReadLine());
	Console.WriteLine("the numbers on each of the squares of chocolate");
	List<int>s=new List<int>();
	for(int i=0;i<L;i++)
	{
	
	  int integer=Convert.ToInt32(Console.ReadLine());
	  s.Add(integer);
	}
	
	 Console.WriteLine("month of birth");
	int M=Convert .ToInt32(Console.ReadLine());
	 Console.WriteLine("date of birth");
	int D=Convert.ToInt32(Console.ReadLine());
	int result=salina(s,M,D);
	Console.WriteLine(result);
	
	
}

// You can define other methods, fields, classes and namespaces here
int count(List<int>s,int M,int D)
	{
	int ways=0;
	  int sum=0;
	for (int i=0;i<=s.Count-M;i++)
	{
	  
	  for (int j=i;j<i+M;j++) // yo line
	  {
	      sum= sum+s[j];
		 
	  }
	  
	  if( sum==D)
	  ways=ways+1;
	  
	 sum=0;
	}
	
	return ways;
	}
	