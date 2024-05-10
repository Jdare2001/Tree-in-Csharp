public class BinaryTree(){
    Node root; 
    
    public void printTree(){
        if (root == null){
            Console.WriteLine("No Elements in Tree");
        }
        
    }
    public void addElement(int theData){
        if (root==null){
            root = new Node(theData);  
        }
        else {
           root.addElement(theData);
        }
    }
}