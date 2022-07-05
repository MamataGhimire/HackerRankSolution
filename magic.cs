void Main()
{
	
	Console.WriteLine("a    b    c    d    e");
	Console.WriteLine("f    g    h     i     j");
	Console.WriteLine("k     l    m    n    o");
	Console.WriteLine("p    q    r    s    t");
	Console.WriteLine("u    v    w    x    y");
	Console.WriteLine("z");
	
	
	List<List<char>>letter=new List<List<char>>
	{
    new List<char>{'a','b','c','d','e'},
	new List<char>{'f','g','h','i','j'},
	new List<char>{'k','l','m','n','o'},
	new List<char>{'p','q','r','s','t'},
	new List<char>{'u','v','w','x','y'},
	new List<char>{'z'}
	
	};
	
	
	string word="";
	Console.WriteLine(" how manyletter you have in your word");
	int num=Convert. ToInt32 (Console.ReadLine());
	Console.WriteLine("enter you letter location");
	for(int i=0;i<num;i++)
	{
	int ans=Convert. ToInt32 (Console.ReadLine());
	word=word+letter[ans];
	
	}
	Console.WriteLine("is your word ="+word.ToString());
	string isCorrect=Console.ReadLine();
	if(isCorrect=="yes")
	Console.WriteLine("thanks for trying");
	else
	Console.WriteLine("given input is wrong Try again");
	
	
	
	
	
}

// You can define other methods, fields, classes and namespaces here
