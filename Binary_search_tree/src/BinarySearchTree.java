
/**************************************     Binary Search Tree class 	*********************************************/

public class BinarySearchTree
{

	/****************************************************************************************************************/
											//	Node Class	//
	
	// Node class for Binary Srearch Tree
	private static class BNode
	{

		// Variables of a node
		int data;			// Data in the node.
		BNode left;	// Left Child.
		BNode right; // Right Child.
		BNode parent; // parent
		
		// Default Constructor
		BNode(int x)
		{
			this(x,null,null,null);
		}
		
		// Parameterized Constructor, lt-left Node, rt-right node, pt-parent node.
		BNode(int x, BNode lt, BNode rt, BNode pt)
		{
			data=x;
			left=lt;
			right=rt;
			parent=pt;
		}
		
	}
	
											//	End of Node Class // 
	/***************************************************************************************************************/
	
	/***************************************************************************************************************/
									// 	Variables and constructor of Binary Search Tree //
	
	// root node for BST
	private BNode root;
	
	// default constructor for BST
	public BinarySearchTree()
	{
		root=null;
	}
		
								// 	End of Variables and constructor of Binary Search Tree //
	/*****************************************************************************************************************/
	
	/*****************************************************************************************************************/
												// Functions on BST //
	
	
	// Insert Function
	// parameters - input value and BST instance
	// returns - void
	// Description - inserts given input value into a new node in BST instance provided.
	
	public void insert(int x,BinarySearchTree bst)
	{
		if(bst.root!=null)
		{
			insert(x,bst.root);	// Function call to overridden insert function
		}
		else
		{
			bst.root=new BNode(x); // inserts the value into root node, if root is null.
		}
	}
	
	
	// Insert function (overridden)
	// parameters - input value and Node of BST.
	// returns - void
	// Description - inserts the given input value into the new node in BST instance, we traverse through tree using the 
	//				 root node provided.
	
	private void insert(int x,BNode node)
	{
			if(x<node.data) // compares input value with node data
			{
				if(node.left!=null)
				{
					insert(x,node.left); // recursive call to insert function with the input value and left node as input
				}
				else
				{
					node.left=new BNode(x,null,null,node); // inserts to the left of the node, if left child is null
				}
					
			}
			else if(x>node.data) // compares input value with node data
			{
				if(node.right!=null)
				{
					insert(x,node.right); // recursive call to insert function with the input value and right child as input
				}
				else
				{
					node.right=new BNode(x,null,null,node); // inserts to the right of the node, if ritgh child is null
				}
			}
		
	}
	
	
	// Find min function
	// parameters - BST instance
	// returns - BST Node
	// Description - returns the Node containing min value in the BST instance provided
	public BNode findMin(BinarySearchTree bst)
	{
		return findMin(bst.root);
	}
	
	// Find min function (overridden)
	// parameters - BST Node (root node)
	// returns - BST Node
	// Description - returns the Node containing min value in the BST instance provided, we traverse through tree using
	//				 the root node. we look for the left most node of BST.
	
	private BNode findMin(BNode node)
	{
		if(node.left!=null)
		{
			return findMin(node.left); // recursive call if left child of the node is not null.
		}
		else
		{
			return node; // returns the node if its left child is null.
		}
	}
	
	// Find max function 
	// parameters - BST instance
	// returns - BST Node
	// Description - returns the Node containing max value in the BST instance provided.
	public BNode findMax(BinarySearchTree bst)
	{
		return findMax(bst.root);
	}
	
	// Find max function (overridden)
	// parameters - BST Node (root node)
	// returns - BST Node
	// Description - returns the Node containing max value in the BST instance provided, we traverse through tree using
	//				 the root node. we look for the right most node of BST.
	private BNode findMax(BNode node)
	{
		if(node.right!=null)
		{
			return findMax(node.right); // recursive call if right child is not null.
		}
		else
		{
			return node; // returns the node if the right child of node is null.
		}
	}
	
	// Search Function
	// parameters - input value, BST instance
	// returns - BST node containing the input value.
	// Description - returns the node containing the value we are searching for in the BST instance provided.
	public BNode search(int x, BinarySearchTree bst)
	{
		return search(x,bst.root);
	}
	
	// Search Function (overridden)
	// parameters - input value, BST node
	// returns - BST node containing the input value.
	// Description - returns the node containing the value we are searching for. we traverse through the tree using the root node.
	private BNode search(int x,BNode node)
	{
		if(x<node.data) // compare input value with the node data.
		{
			if(node.left!=null) // checks for left child if value is less than node value
			{
				return search(x,node.left); // recursive call to search function with input value and left child as parameters
			}
			else
			{
				return null; // returns null if value is not present
			}
		}
		else if(x>node.data) // compare input value with the node data
		{
			if(node.right!=null) // checks for the right child if the value is greater than node value
			{
				return search(x,node.right); // recursive call to search function with input value and right child as parameters
			}
			else
			{
				return null; // returns null if value is not present
			}
		}
		else
		{
			return node; // returns the node if value is equal to the node data.
		}
			
	}
	
	// Remove Function
	// parameters - input value and BST instance.
	// returns - void
	// Description - removes the node containing the input value in the BST instance provided.
	public void remove(int x,BinarySearchTree bst)
	{
		BNode rNode;
		rNode=search(x,bst.root); // Searching for the node to be removed
		if(rNode!=null)
		{
			remove(rNode); // function call to remove the node found
		}
		else
		{
			System.out.println(x+" is not present in BST");
		}
	}
	
	// Remove Function (overridden)
	// parameters - input value and BST Node to be removed.
	// returns - void
	// Description - removes the node containing the input value in the BST instance provided.
	private void remove(BNode node)
	{
		// Following code reconstructs tree as the removing the node changes the structure of the tree
		if(node.right!=null)
		{
			BNode lNode;
			lNode=findMin(node.right);
				
			if(lNode.right!=null)
			{
				lNode.right.parent=lNode.parent;
				lNode.parent.left=lNode.right;
			}
			else
			{
				lNode.parent.left=null;
			}
				
			node.data=lNode.data;
				
			lNode.parent=null;
			lNode.right=null;
			lNode.left=null;
			
			
		}
		else
		{
			if(node.parent.right.data==node.data)
			{
				if(node.left!=null)
				{
					node.parent.right=node.left;
					node.left.parent=node.parent;
				}
				else
				{
					node.parent.right=null;
				}
			}
			else
			{
				if(node.left!=null)
				{
					node.parent.left=node.left;
					node.left.parent=node.parent;
				}
				else
				{
					node.parent.left=null;
				}
			}
		}
	}
		
		
	
	// Display function
	// parameters - BST instance
	// returns - void
	// Description - display's the nodes of the tree.
	public void display(BinarySearchTree bst)
	{
		display(bst.root);
	}
	
	// Display function (overridden)
	// parameters - BST Node
	// returns - void
	// Description - Displays the nodes of the tree.
	private void display(BNode node)
	{
		if(node!=null)
		{
			System.out.println(node.data);
		}
		if(node.left!=null)
		{
			display(node.left);
		}
		if(node.right!=null)
		{
			display(node.right);
		}
	}
	
													// End of Functions //
	/******************************************************************************************************************/
	
	/******************************************************************************************************************/
													// Main Function //
	public static void main(String args[])
	{
		BinarySearchTree bst=new BinarySearchTree();
		bst.insert(4, bst);
		bst.insert(2, bst);
		bst.insert(3, bst);
		bst.insert(1, bst);
		bst.insert(6, bst);
		bst.insert(5, bst);
		bst.insert(9, bst);
		bst.insert(7, bst);
		bst.insert(8, bst);
		bst.insert(10, bst);
		bst.display(bst);		
		System.out.println("\n"+bst.findMin(bst).data+"\n");
		System.out.println(bst.findMax(bst).data+"\n");
		
		BNode sNode=bst.search(8, bst);
		if(sNode!=null)
		{
			System.out.println(sNode.data+"\n");
		}
		else
		{
			System.out.println("data not present");
		}
		
		bst.remove(6, bst);
		
		bst.display(bst);
		
		System.out.println("\n"+bst.findMin(bst).data+"\n");
		System.out.println("\n"+bst.findMax(bst).data+"\n");
		bst.remove(10, bst);
		System.out.println("\n"+bst.findMax(bst).data+"\n");
		bst.remove(7, bst);
		bst.display(bst);
	}
	
										// End of Main Function //
	/******************************************************************************************************************/
}
										// End of Program //
/***********************************************************************************************************************/
