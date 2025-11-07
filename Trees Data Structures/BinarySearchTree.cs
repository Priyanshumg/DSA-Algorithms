namespace Trees_Data_Structures;

public class BinarySearchTree
{
     private Node RootNode { get; set; }
     public List<string> AcceptedInputList = new List<string>()
     {
          "yes", "y", "true"
     };

     #region Constructors
     public BinarySearchTree(Node node)
     {
          RootNode = node;
     }
     public BinarySearchTree()
     {
          
     }
     #endregion
     public class Node
     {
          public Node(int _value)
          {
               value = _value;
               height = 1;
          }
          int height { get; set; }
          int value { get; set; }
          Node left { get; set; }
          Node right { get; set; }
          public int GetValue() => value;
          public Node GetLeftNode() => left;
          public Node GetRightNode() => right;
          public int GetHeight() => height;
          public void SetLeftNode(Node node) => left = node;
          public void SetRightNode(Node node) => right = node;
          public void SetHeight(int value) => height = value;
     }

     public bool UserContinuationQuestions()
     {
          Console.Write("Do you want to populate data even further? ");
          string input = Console.ReadLine().Trim().ToLower();
          if (!AcceptedInputList.Contains(input))
               return false;
          return true;
     }
     
     
     public void InsertSortedArray(int[] nums)
     {
          InsertSortedArray(nums, 0, nums.Length);
     }
     
     private void InsertSortedArray(int[] nums, int start, int end)
     {
          if (start >= end)
               return;
        
          int mid = (start + end) / 2; 
          Insert(nums[mid]);
          // FOR LHS of ARRAY
          InsertSortedArray(nums, 0, mid);
          // FOR RHS of Array
          InsertSortedArray(nums, start:mid + 1, end: end);
     }
     public void InsertUnSortedArrayInBST(int[] nums)
     {
          foreach (var element in nums)
               Insert(element);
     }

     public void PopulateBST()
     {
          if (RootNode == null)
          {
               Console.WriteLine("Your object does not have a root node");
               Console.Write("Enter RootNode: ");
               int value = Convert.ToInt32(Console.ReadLine());
               RootNode = new Node(value);
               RootNode.SetHeight(1);
          }

          if (UserContinuationQuestions())
          {
               PopulateBST(RootNode);     
          }
     }

     public void Insert(int value)
     {
          RootNode = Insert(RootNode, value);
     }

     public Node Insert(Node node, int value)
     {
          if (node == null)
               node = new Node(value);
          
          if (value < node.GetValue())
               node.SetLeftNode(Insert(node.GetLeftNode(), value));
          else if (value > node.GetValue())
               node.SetRightNode(Insert(node.GetRightNode(), value));
          
          UpdateHeight(node);
          return node;
     }
     
     
     public void PopulateBST(Node node)
     {
          Console.Write("Enter Value: ");
          int value = Convert.ToInt32(Console.ReadLine());
          if (SearchBST(RootNode, value))
          {
               Console.WriteLine("You cannot Enter Duplicate values");
               PopulateBST();
          }
          else
               TraverseBST(RootNode, value);

          UpdateHeight(node);
          Console.WriteLine();
          
          
          PopulateBST();
     }

     public void UpdateHeight(Node node)
     {
          if (node == null)
               return;

          int leftHeight = node.GetLeftNode() != null ? node.GetLeftNode().GetHeight() : 0;
          int rightHeight = node.GetRightNode() != null ? node.GetRightNode().GetHeight() : 0;

          int newHeight = Math.Max(leftHeight, rightHeight) + 1;
          node.SetHeight(newHeight);
     }

     private bool IsBalancedTree()
     {
          return IsBalancedTree(RootNode);
     }

     public bool IsBalancedTree(Node node)
     {
          if (node == null)
               return true;
          return Math.Abs(node.GetLeftNode().GetHeight() - node.GetRightNode().GetHeight()) <= 1 
                 && IsBalancedTree(node.GetLeftNode())
                 && IsBalancedTree(node.GetRightNode());
     }

     public void TraverseBST(Node node, int value)
     {
          if (value < node.GetValue())
          {
               if (node.GetLeftNode() == null)
                    node.SetLeftNode(new Node(value));
               else
                    TraverseBST(node.GetLeftNode(), value);
          }
          else if (value > node.GetValue())
          {
               if (node.GetRightNode() == null)
                    node.SetRightNode(new Node(value));
               else
                    TraverseBST(node.GetRightNode(), value);
          }
     }

     public bool SearchBST(Node node, int value)
     {
          if (node == null)
               return false;
          if (value == node.GetValue())
               return true;
          if (value < node.GetValue())
               return SearchBST(node.GetLeftNode(), value);
          if (value > node.GetValue())
               return SearchBST(node.GetRightNode(), value);
          return false;
     }
     /// <summary>
     /// Defaulter Display Pattern, will Display in PreOrder Traversal
     /// Purpose is to Print BST on Console
     /// Print Pattern: Node -> Left -> Right  
     /// </summary>
     public void DisplayBST()
     {
          if (RootNode != null)
               DisplayBST_PreOrderTraversal(node: RootNode, index: "");
          else
          {
               Console.WriteLine("No Trees found would you like to create one and display? ");
               string input = Console.ReadLine().Trim().ToLower();
               if (AcceptedInputList.Contains(input))
                    PopulateBST();
               DisplayBST();
          }
     }
     /// <summary>
     /// Pre Order Traversal Display, for console printing purposes
     /// Print Pattern: Node -> Left -> Right
     /// </summary>
     /// <param name="node"> Node from which you want to iterate from </param>
     /// <param name="index"> Index for indentation on console</param>
     public void DisplayBST_PreOrderTraversal(Node node, string index)
     {
          if (node == null)
               return;
          Console.WriteLine(index + node.GetValue());
          DisplayBST_PreOrderTraversal(node.GetLeftNode(), index + "\t");
          DisplayBST_PreOrderTraversal(node.GetRightNode(), index + "\t");
     }

     public void DisplayBST_InOrderTRaversal()
     {
          DisplayBST_InOrderTRaversal(RootNode, "");
     }
     /// <summary>
     /// Prints BST in InOrder Traversal Format
     /// Print Pattern - LeftNode -> Node -> RightNode
     /// </summary>
     /// <param name="node"></param>
     /// <param name="index"></param>
     private void DisplayBST_InOrderTRaversal(Node node, string index)
     {
          if (node == null)
               return;
          DisplayBST_InOrderTRaversal(node.GetLeftNode(), "\t");
          Console.WriteLine(index + node.GetValue);
          DisplayBST_InOrderTRaversal(node.GetRightNode(), "\t");
     }

     public void DisplayBST_PostOrderTraversal()
     {
          DisplayBST_PostOrderTraversal(RootNode, "");
     }

     /// <summary>
     /// Prints BST in Post Order Traversal Format
     /// Print Pattern - LeftNode -> RightNode -> Node
     /// </summary>
     /// <param name="node"></param>
     /// <param name="index"></param>
     private void DisplayBST_PostOrderTraversal(Node node, string index)
     {
          if (node == null)
               return;
          DisplayBST_PostOrderTraversal(node.GetLeftNode(), "\t");
          DisplayBST_PostOrderTraversal(node.GetRightNode(), "\t");
          Console.WriteLine(index + node.GetValue);
     }
}