public class Node{

    public int data;
    private Node? leftChild; 
    private Node? rightChild;
    public Node(int theData){
        this.data = theData;
        this.leftChild = null;
        this.rightChild = null;
    }

    public void printFormated(string theIndent, bool last, Node theNode){
        while(last == false){
            if (theNode.leftChild == null && theNode.rightChild == null){
                last = true;
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