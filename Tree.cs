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
    public void printTreeInLevelOrder(){
        if (root == null){
            return;
        }
         Queue<Node> visited = new Queue<Node>();
         visited.Enqueue(root);
        while(visited.Count != 0){
            Node node = visited.Dequeue();
            Console.Write(node.data+ " " );
            if(node.leftChild != null){
                visited.Enqueue(node.leftChild);
            }
            if(node.rightChild != null){
                visited.Enqueue(node.rightChild);
            }
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