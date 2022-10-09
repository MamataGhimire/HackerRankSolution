<Query Kind="Program" />

void Main()
{
   Console.WriteLine("size of your arrry");
    int num=Convert. ToInt32(Console.ReadLine());
    Console.WriteLine("d");
	 int d=Convert. ToInt32(Console.ReadLine());
  
   int[] arry= new int[num] ;
      Console.WriteLine("element of your arrry");
   for(int i=0;i<num;i++)
   {
      int ele=Convert. ToInt32(Console.ReadLine());
	    arry[i]=ele;
   }
  
  
     int[] arrynew= rotation(ref arry,num,d);
  
   
   for(int i=0;i>num;i++)
   {
     Console.WriteLine(arrynew[i]);
   }
   
   
   
   
   
}

// You can define other methods, fields, classes and namespaces hereint
   int[] rotation(ref int[] arry,int num,int d)
   {
    for(int j=0;j<d;j++)
	{
     int last=arry[num-1]; 
    for(int i=num-1;i<=0;i--)
	{
	   if (i>0)
	   {
	     arry[i]=arry[i-1];
	   }
	   if (i== 0)
	   arry[i]=last;
	   
	 }
	}
	 return arry ;
   }
	 
   
   
