using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Trees_Data_Structures;

public class BinaryTree
{
    private Node RootNode;
    public class Node
    {
        int value;
        private Node Left;
        private Node Right;
        public Node(int value) => this.value = value;
        public void SetLeftNode(Node node) => Left = node;
        public void SetRightNode(Node node) => Right = node;
        public Node GetLeft() => Left;
        public Node GetRight() => Right;
        public int GetValue() => value;
    }

    public Node GetRootNode()
    {
        return RootNode;
    }
    
    public void Populate()
    {
        Console.Write("Enter the root Node Value: ");
        int value = Convert.ToInt32(Console.ReadLine().Trim());
        RootNode = new Node(value);
        Populate(RootNode);
    }

    public void ValueSetter(bool left, ref Node node)
    {
        Console.Write(left ? "Please Enter Value on Left " : "Please Enter Value on Right ");
        int value = Convert.ToInt32(Console.ReadLine().Trim());
        if (left)
            node.SetLeftNode(new Node(value));
        else
            node.SetRightNode(new Node(value));
    }
    public void Populate(Node node)
    {
        Console.WriteLine($"We are at Node: {node.GetValue()}");
        Console.WriteLine("Do you want to set value? (yes/ y)");
        string input = Console.ReadLine().Trim().ToLower();

        bool insert = (input == "yes" || input == "y" || input == "true");

        if (!insert)
            return;
        
        Console.Write("Do you want to Insert on left? ");

        input = Console.ReadLine().Trim().ToLower();
        bool InsertAtLeft = (input == ("y") || input == "yes" || input == "true");
        if (InsertAtLeft)
            ValueSetter(left:true, ref node);
        
        Console.Write("Do you want to Insert value on right? ");
        input = Console.ReadLine().Trim().ToLower();
        bool InsertAtRight = (input == ("y") || input == "yes" || input == "true");
        if (InsertAtRight)
            ValueSetter(left:false, ref node);

        if (node.GetLeft() != null)
            Populate(node.GetLeft());
        if (node.GetRight() != null)
            Populate(node.GetRight());
    }

    public void DisplayTree()
    {
        DisplayTree(GetRootNode(), "");
    }

    public void DisplayTree(Node node, string Indent)
    {
        if (node == null)
            return;

        Console.WriteLine(Indent + node.GetValue());
        DisplayTree(node.GetLeft(), Indent + "\t");
        DisplayTree(node.GetRight(), Indent + "\t");
    }
}
