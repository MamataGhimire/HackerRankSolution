<Query Kind="Program" />

void Main()
{
  var workTime=hours();
  Payment(workTime);
 
}
List<float> hours()
	{
	      Console.WriteLine("how many worker you have");
		  int worker=GetIntIntput();
	      Console.WriteLine("enter the time that you'r worker have work respectively");
		 List<float>workTime=new  List<float>();
	  for (int i=0;i<worker;i++)
	  {
	 
	  float time=GetFloatIntput();
	 // List<float>workTime=new  List<float>();
	     workTime.Add(time);
	   }
		 
		 return workTime;
	  
	}
	
	float GetFloatIntput()
	{
	 // float time=float.passe(Console.ReadLine());
	 float time= float.Parse(Console.ReadLine());
	  return time;
	}
	int GetIntIntput()
	{
	 
	 int worker=Convert.ToInt32(Console.ReadLine());
	  return worker;
	}
	
	
	
	void Payment(List<float> workTime,int worker)
	{
	    float time=40;
		float rate=12;
		for (int i=0;i<worker;i++)
	   {
	     if (workTime[i]>time)
		 {
		  float OverTime=workTime[i]-time;
		  float rupees= OverTime*rate;
		  
		   Console.WriteLine((i+1)+"   worker payment = rs"+rupees);
		  
		 }
		 else
		  Console.WriteLine((i+1)+ " worker haven't work overtime");
		 
	   }
	}
	
	

// You can define other methods, fields, classes and namespaces here