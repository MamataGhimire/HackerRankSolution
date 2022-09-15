<Query Kind="Program" />

void Main()
{
	
	int day=256;
	Console.WriteLine("enter the year");
	int year=Convert.ToInt32(Console.ReadLine());
	int leap= year%4;
	
	if (leap==0)
	 {
	   int month=31 + 29 + 31 + 30 + 31 + 30 + 31 + 31;
	   int date=day-month;
	   if(date<10)
	     Console.WriteLine(0+date+"."+"09"+"."+year);
	   else
		  Console.WriteLine(date+"."+"09"+"."+year);
	 }
	 
     else
	   {
	    int month=31 + 28 + 31 + 30 + 31 + 30 + 31 + 31;
	    int date=day-month;
	    Console.WriteLine(date+"."+"09"+"."+year);
	    if(date<10)
	        Console.WriteLine(0+date+"."+"09"+"."+year);
		else
		    Console.WriteLine(date+"."+"09"+"."+year);
	 }
}

// You can define other methods, fields, classes and namespaces here  it has 29 days during a leap year, and 28 days during all other years.
	   // Divisible by 400.
	   // Divisible by 4 and not divisible by 100.
		////september 9 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 = 243 lukamari
	