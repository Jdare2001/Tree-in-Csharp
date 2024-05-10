public class BinaryTree(){
    Node? root; 
    
    public void printTree(){
        if (root == null){
            Console.WriteLine("No Elements in Tree");
        }
        else{
            root.printFormated(root);
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