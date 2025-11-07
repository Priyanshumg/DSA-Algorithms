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

        int[] UnsortedArray = new int[6]
        {
            5, 3, 6, 2, 1, 8
        };
        
        BinarySearchTree BST = new BinarySearchTree();
        BST.InsertUnSortedArrayInBST(UnsortedArray);
        BST.DisplayBST();

        Console.WriteLine(new string('=', 30));
        
        BST.InsertSortedArray(UnsortedArray.OrderBy(i => i).ToArray());
        BST.DisplayBST();
        #endregion
    }
}