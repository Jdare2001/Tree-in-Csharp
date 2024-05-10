public class BinaryTree(){
    Node? root; 
    
    public void printTreeInOrder(){
        if (root == null){
            Console.WriteLine("No Elements in Tree");
        }
        else{
            root.printFormatedInOrder(root);
        } 
    }
    public void printTreePreOrder(){
        if (root == null){
            Console.WriteLine("No Elements in Tree");
        }
        else{
            root.printFormatedPreOrder(root);
        } 
    }
    public void addElement(int theData){
        if (root==null){
            root = new Node(theData);  
        }
        else {
           root.add(theData);
        }
    }
}