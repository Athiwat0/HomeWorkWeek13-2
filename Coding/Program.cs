class Program
{
    static void Main(string[] args)
    {
        Queue<char> Push = new Queue<char>();
        Queue<int> Pull = new Queue<int>();

        while(true)
        {
            Console.Write("Input Size (L,M,S) : ");
            char Input_size = char.Parse(Console.ReadLine());
            if(Input_size != 'L' && Input_size != 'M' && Input_size != 'S')
            {
                break;
            }
            else
            {
                Push.Push(Input_size);
            }
        }

        while(true)
        {
            char GetSize = Push.Pop();
            if(GetSize == 'L')
            {
                Push.Push('M');
                Push.Push('M');
                Pull.Push(1);
            }
            else if (GetSize == 'M')
            {
                Push.Push('S');
                Push.Push('S');
                Push.Push('S');
                Pull.Push(2);
            }
            else if (GetSize == 'S')
            {
                Pull.Push(3);
            }
            if(Push.GetLength() == 0)
            {
                break;
            }
        }

        Console.WriteLine("========================================");
        for (int i = 0 ; i < Pull.GetLength() ; i++)
        {
            Console.Write(Pull.Get(i));
        }
        Console.ReadKey();
    }      
}