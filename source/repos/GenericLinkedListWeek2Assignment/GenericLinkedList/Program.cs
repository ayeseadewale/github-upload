namespace GenericLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList<string> list = new LinkedList<string>();
            list.AddToTail("Lagos");
            list.AddToTail("Ondo");
            list.AddToTail("Ogun");
            
          
          
            Console.WriteLine(list.Index("mike"));
            
            Console.WriteLine(list.Remove("kelvin"));

            list.Print();

        }
    }
}