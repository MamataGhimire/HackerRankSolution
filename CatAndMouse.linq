<Query Kind="Program" />

void Main()
{
	int q,A,B,C;
	Console.WriteLine("number of queries");
	 q=Convert.ToInt32(Console.ReadLine());
	 
	 for(int i=0;i<q;i++)
	 {
	    List<int>Position=new List<int>();
	    for(int j=0;j<3;j++)
	       {
		      int point=Convert.ToInt32(Console.ReadLine());
	          Position.Add(point);
	       }
		   A=Position[0];
		   B=Position[1];
		   C=Position[2];
		   
		   int catA=A-C;
		    
			if(catA<1)
			{
			  catA=catA*(-1);
			}
		   int catB=B-C;
		   
		     if(catB<1)
			 {
			  catB=catB*(-1);
			 }
			 
			  if(catB<catA)
			 {
			  Console.WriteLine("catB");
			 }
			 
			  if(catB>catA)
			 {
			  Console.WriteLine("catA");
			 }
		   
		    if(catB==catA)
			 {
			  Console.WriteLine("mouseC");
			 }
	   
	 }
}

// You can define other methods, fields, classes and namespaces here