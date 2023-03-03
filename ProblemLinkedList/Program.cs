namespace ProblemLinkedList;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Linked List Problem!");
        LinkedList list = new LinkedList();
        list.Add(50);
        list.Add(70);
        list.Add(30);
        list.Display();
        int a = list.Search(30);
        list.InsertAtParticularPosition(a + 1, 40);
        list.Display();
        list.DeleteNodeAtParticularPosition(2);
        list.Size();
        list.Display();
    }
}