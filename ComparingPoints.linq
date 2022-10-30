<Query Kind="Program" />

void Main()
{
	List<int>Alice=new List <int>{5,3,9};
	List<int>Bob=new List <int>{9,3,5};
	int A=0;
	int B=0;
	for(int i=0;i<Alice.Count;i++)
	{
	 if(Alice[i]<Bob[i])
	 {
	   B=B+1;
	 }
	  if(Alice[i]>Bob[i])
	 {
	   A=A+1;
	 }
	 if(Alice[i]==Bob[i])
	 {
	   A=A+0;
	   B=B+0;
	 }
	 
	}
	
	Console.Write(A+" "+B);
}

// You can define other methods, fields, classes and namespaces here