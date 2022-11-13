void Main()
{
	List<int>num=new List<int>(){1,2,3,4,5};
	int max=num[0];
	int mini=num[0];
	int a=0;
	int b=0;
	for(int i=0;i<num.Count;i++)
	{
	   if(max<num[i])
	     max=num[i];
	  
	   if(mini>num[i])
	   mini=num[i];
	   
	}
	
	for(int i=0;i<num.Count;i++ )
	{
	  if(num[i]!=max)
	  {
	   a=a+num[i];
	  }
	   if(num[i]!=mini)
	  {
	   b=b+num[i];
	  }
	}
	Console.WriteLine("maxium="+" "+b+" "+"minimum="+" "+ a);
}
