public class Node{

    public int data;
    private Node? leftChild; 
    private Node? rightChild;
    public Node(int theData){
        this.data = theData;
        this.leftChild = null;
        this.rightChild = null;
    }

    public void printFormated( bool last, Node theNode){
        while(last == false){
            Console.WriteLine(data);
            if (theNode.leftChild == null && theNode.rightChild == null){
                
                last = true;
            }
            if (theNode.leftChild != null){
                printFormated(last, theNode.leftChild);
            }
            if(theNode.rightChild != null){
                printFormated(last, theNode.rightChild);
            } 
        }
        
      
    }
    
    public void add(int theData){
        if (data < theData){
            if (leftChild == null){
                leftChild = new Node(theData);
            }
            else{
                leftChild.add(theData);
            }
        }
        if (data > theData){
            if (rightChild == null){
                leftChild = new Node(theData);
            }
            else{
                rightChild.add(theData);
            }
        }
    }
}