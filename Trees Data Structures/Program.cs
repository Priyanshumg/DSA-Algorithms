namespace Trees_Data_Structures;

class Program
{
    static void Main(string[] args)
    {
        #region Binary Tree
        // BinaryTree tree = new BinaryTree();
        // tree.Populate();
        // tree.DisplayTree();
        #endregion

        #region Binary Search Tree

        BinarySearchTree BST = new BinarySearchTree();
        BST.PopulateBST();
        BST.DisplayBST();
        #endregion

    }
}