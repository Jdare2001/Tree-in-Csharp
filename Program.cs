// See https://aka.ms/new-console-template for more information
public class Program{
static void Main(string[] args)
{
    BinaryTree binaryTree= new BinaryTree();

    binaryTree.addElement(4);
    binaryTree.addElement(3);
    binaryTree.addElement(5);
    binaryTree.addElement(7);
    binaryTree.addElement(2);
    binaryTree.addElement(1);
    Console.WriteLine("In order");
    binaryTree.printTreeInOrder();
    Console.WriteLine("");
    Console.WriteLine("Pre order");
    binaryTree.printTreePreOrder();
}
}