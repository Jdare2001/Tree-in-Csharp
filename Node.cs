public class Node{

    
    public int data;
    public Node? leftChild; 
    public Node? rightChild;
    public Node(int theData){
        this.data = theData;
        this.leftChild = null;
        this.rightChild = null;
    }

    public void printFormatedInOrder( Node theNode){
       if (theNode == null){
        return;
       }
       //null referance is handled in recersion 
       printFormatedInOrder(theNode.leftChild);
       Console.Write(theNode.data + " ");

       printFormatedInOrder(theNode.rightChild);
        
      
    }
    public void printFormatedPreOrder( Node theNode){
       if (theNode == null){
        return;
       }
       Console.Write(theNode.data + " ");
       //null referance is handled in recersion 
       printFormatedInOrder(theNode.leftChild);
       

       printFormatedInOrder(theNode.rightChild);
        
      
    }
    
    
    public void add(int theData){
        if (data > theData){
            if (leftChild == null){
                leftChild = new Node(theData);
            }
            else{
                leftChild.add(theData);
            }
        }
        if (data < theData){
            if (rightChild == null){
                rightChild = new Node(theData);
            }
            else{
                rightChild.add(theData);
            }
        }
    }
}