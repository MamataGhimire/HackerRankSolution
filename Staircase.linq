<Query Kind="Program" />

void Main()
{
   int n=3;
   for (int i=n;i>0;i--)
   {
     int spaceCount=0;
	 for (int j=0;j<i-1;j++)
	 {
	   Console.Write(" ");
	   spaceCount++;
	 }
	 
	 for(int k=0;k<n-spaceCount;k++)
	 {
	   Console.Write("#");
	 }
	  
	   Console.WriteLine();
	 
   }
}

//   You can define other methods, fields, classes and namespaces here