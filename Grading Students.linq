<Query Kind="Program" />

void Main()
{
	Console.WriteLine("your grade");
	int grade=Convert . ToInt32(Console.ReadLine());
	int Multipal=0;
	while(Multipal!<grade)
	{
	  Multipal=Multipal+5;
	  //Console.WriteLine(Multipal);
	}
	
	int FinalGrade=Multipal-grade;
	if(FinalGrade<3)
	{
     FinalGrade=Multipal;
	}
	
	if(grade<38||FinalGrade>=3)
	{
	 FinalGrade=grade;
	}
	Console.WriteLine(FinalGrade);
}

// You can define other methods, fields, classes and namespaces here
//yedi grade ra grade paxi ko 5 ko multipal<then 3 vayo vani grade ==5 ko multipal husnxa yedi grade <38 vayo vani tei hunxa;