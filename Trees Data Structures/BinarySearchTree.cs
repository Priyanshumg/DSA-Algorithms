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
          }
          int height { get; set; }
          int value { get; set; }
          Node left { get; set; }
          Node right { get; set; }
          public int GetValue() => value;
          public Node GetLeft() => left;
          public Node GetRight() => right;
          public int GetHeight() => height;
          public void SetLeftNode(Node node) => left = node;
          public void SetRightNode(Node node) => right = node;
     }

     public bool UserContinuationQuestions()
     {
          Console.Write("Do you want to populate data even further? ");
          string input = Console.ReadLine().Trim().ToLower();
          if (!AcceptedInputList.Contains(input))
               return false;
          return true;
     }
     
     public void PopulateBST()
     {
          if (RootNode == null)
          {
               Console.WriteLine("Your object does not have a root node");
               Console.Write("Enter RootNode: ");
               int value = Convert.ToInt32(Console.ReadLine());
               RootNode = new Node(value);
          }

          if (UserContinuationQuestions())
          {
               PopulateBST(RootNode);     
          }
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

          Console.WriteLine();
          PopulateBST();
     }

     public void TraverseBST(Node node, int value)
     {
          if (value < node.GetValue())
          {
               if (node.GetLeft() == null)
                    node.SetLeftNode(new Node(value));
               else
                    TraverseBST(node.GetLeft(), value);
          }
          else if (value > node.GetValue())
          {
               if (node.GetRight() == null)
                    node.SetRightNode(new Node(value));
               else
                    TraverseBST(node.GetRight(), value);
          }
     }

     public bool SearchBST(Node node, int value)
     {
          if (node == null)
               return false;
          if (value == node.GetValue())
               return true;
          if (value < node.GetValue())
               return SearchBST(node.GetLeft(), value);
          if (value > node.GetValue())
               return SearchBST(node.GetRight(), value);
          return false;
     }

     public void DisplayBST()
     {
          if (RootNode != null)
               DisplayBST(node: RootNode, index: "");
          else
          {
               Console.WriteLine("No Trees found would you like to create one and display? ");
               string input = Console.ReadLine().Trim().ToLower();
               if (AcceptedInputList.Contains(input))
                    PopulateBST();
               DisplayBST();
          }
     }
     
     public void DisplayBST(Node node, string index)
     {
          if (node == null)
               return;
          Console.WriteLine(index + node.GetValue());
          DisplayBST(node.GetLeft(), index + "\t");
          DisplayBST(node.GetRight(), index + "\t");
     }
}