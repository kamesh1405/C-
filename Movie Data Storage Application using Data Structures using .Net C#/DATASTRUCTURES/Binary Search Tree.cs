using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;// add windows form Library

namespace DATASTRUCTURES
{
    // A public Node Class of Binary Search Tree
    public class Node
    {
        public Node RightChild;
        public Node LeftChild;
        public string Movie_Title;
        public MyStringList Cast;
        public int Movie_Year;
        public string Movie_Duration;
        public string Movie_Rating;
    }
    //A Public Binary Search Tree Class
    public class Binary_Search_Tree
    {
        AddmovieForm mainForm;
       public Node root;

        // Binary Search Tree class constructor to access the attributes(e:g ListBox) of AddmovieForm
        public Binary_Search_Tree(AddmovieForm form1)
        {
           // store the Form1 object reference
            mainForm = form1;
        }
        public Binary_Search_Tree()
        {
            root = null;
        }

        // ==================== Insertion in a Tree
        public void Insert(string Movie_Title,MyStringList cast, int Movie_Year, string Movie_Duration, string Movie_Rating)
        {
           
            Node newnode = new Node();
            newnode.Movie_Title = Movie_Title;
            newnode.Cast = cast;
            newnode.Movie_Year = Movie_Year;
            newnode.Movie_Duration = Movie_Duration;
            newnode.Movie_Rating = Movie_Rating;

            if (root == null)
            {
                root = newnode;
            }
            else
            {
                Node current = root;
                Node parent;

                while (true)
                {
                    parent = current;
                    if (Movie_Title.CompareTo(current.Movie_Title) < 0)
                    {
                        current = current.LeftChild;
                        if (current == null)
                        {
                            parent.LeftChild = newnode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.RightChild;
                        if (current == null)
                        {
                            parent.RightChild = newnode;
                            break;
                        }
                    }
                }

            }
        }

        //==================== Inorder Display
        public void Inorder(Node p)
        {
            if (p == null)
                return;

                Inorder(p.LeftChild);
                mainForm.AddmovielistBox1.Items.Add(" Movie Title  =  " + p.Movie_Title);
                mainForm.AddmovielistBox1.Items.Add(" Movie Cast = " + p.Cast.Display());
                mainForm.AddmovielistBox1.Items.Add("Year Release =  " + p.Movie_Year);
                mainForm.AddmovielistBox1.Items.Add("Movie Duration  = " + p.Movie_Duration);
                mainForm.AddmovielistBox1.Items.Add("Movie Rating  =  " + p.Movie_Rating);
                mainForm.AddmovielistBox1.Items.Add("\n");
                mainForm.AddmovielistBox1.Items.Add("**********************************");
                mainForm.AddmovielistBox1.Items.Add("\n");
                Inorder(p.RightChild);
            
        }


        // ======================= Search by Movie Title
      public void Search_MovieTitle(Node root, string searchMovieTitle)
        {
            Node parentNode;
            Node foundNode = null;
            Node tree = parentNode = root;
            if (tree == null)
            {
                MessageBox.Show("Binary Search Tree is Empty");
            }
            else
            {
                while (tree != null)
                {
                    if (searchMovieTitle.CompareTo(tree.Movie_Title) == 0)
                    {
                        foundNode = tree;
                        break;
                    }

                    else if (searchMovieTitle.CompareTo(tree.Movie_Title) < 0)
                    {
                        parentNode = tree;
                        tree = tree.LeftChild;
                    }
                    else if (searchMovieTitle.CompareTo(tree.Movie_Title) > 0)
                    {
                        parentNode = tree;
                        tree = tree.RightChild;
                    }
                }
            }
            if (foundNode == null)
            {
                MessageBox.Show("Node not found in binary tree");
            }
            else
            {
                mainForm.AddmovielistBox1.Items.Add(" Movie Title  =  " + tree.Movie_Title);
                mainForm.AddmovielistBox1.Items.Add(" Movie Cast = " +tree.Cast.Display());
                mainForm.AddmovielistBox1.Items.Add("Year Release =  " + tree.Movie_Year);
                mainForm.AddmovielistBox1.Items.Add("Movie Duration  = " + tree.Movie_Duration);
                mainForm.AddmovielistBox1.Items.Add("Movie Rating  =  " + tree.Movie_Rating);
                mainForm.AddmovielistBox1.Items.Add("\n");
                mainForm.AddmovielistBox1.Items.Add("**********************************");
                mainForm.AddmovielistBox1.Items.Add("\n");
                
               }
        }
        // ===================== Search  By Movie Year Release
        public int Search_Year(Node node, int year)
        {
            // Base Case  
            if (node == null)
            {
                return 0;
            }

            // If current node is in range, then   
            // include it in count and recur for   
            // left and right children of it  
            if (node.Movie_Year == year)
            {
                mainForm.AddmovielistBox1.Items.Add(" Movie Title  =  " + node.Movie_Title);
                mainForm.AddmovielistBox1.Items.Add(" Movie Cast = " + node.Cast.Display());
                mainForm.AddmovielistBox1.Items.Add("Year Release =  " + node.Movie_Year);
                mainForm.AddmovielistBox1.Items.Add("Movie Duration  = " + node.Movie_Duration);
                mainForm.AddmovielistBox1.Items.Add("Movie Rating  =  " + node.Movie_Rating);
                mainForm.AddmovielistBox1.Items.Add("\n");
                mainForm.AddmovielistBox1.Items.Add("**********************************");
                mainForm.AddmovielistBox1.Items.Add("\n");
                return this.Search_Year(node.LeftChild, year) + this.Search_Year(node.RightChild, year);
            }

            // If current node is smaller than low,   
            // then recur for right child  
            else if (node.Movie_Year < year)
            {
                return this.Search_Year(node.RightChild, year) + this.Search_Year(node.LeftChild, year);
            }

            // Else recur for left child  
            else 
            {
                return this.Search_Year(node.LeftChild, year) + this.Search_Year(node.RightChild, year);
            }
           

        }
        //==================== Search Movie By Time Period(e:g 1980 - 1999)

        public int TimePeriodSearch(Node node, int low, int high)
        {
            // Base Case  
            if (node == null)
            {
                return 0;
            }

            // If current node is in range, then   
            // include it in count and recur for   
            // left and right children of it  
            if (node.Movie_Year >= low && node.Movie_Year <= high)
            {
      
                 mainForm.AddmovielistBox1.Items.Add(" Movie Title  =  " + node.Movie_Title);
                 mainForm.AddmovielistBox1.Items.Add(" Movie Cast = " + node.Cast.Display());
                 mainForm.AddmovielistBox1.Items.Add("Year Release =  " + node.Movie_Year);
                 mainForm.AddmovielistBox1.Items.Add("Movie Duration  = " + node.Movie_Duration);
                 mainForm.AddmovielistBox1.Items.Add("Movie Rating  =  " + node.Movie_Rating); 
                mainForm.AddmovielistBox1.Items.Add("\n");
                mainForm.AddmovielistBox1.Items.Add("**********************************");
                mainForm.AddmovielistBox1.Items.Add("\n");
                return +1 + this.TimePeriodSearch(node.LeftChild, low, high) + this.TimePeriodSearch(node.RightChild, low, high);
            }

            // If current node is smaller than low,   
            // then recur for right child  
            else if (node.Movie_Year < low)
            {
                return this.TimePeriodSearch(node.RightChild, low, high);
            }

            // Else recur for left child  
            else
            {
                return this.TimePeriodSearch(node.LeftChild, low, high);
            }
        }
        // ========================== Search Movie By Duration
       public string Search_Duration(Node node, string duration)
        {
            // Base Case  
            if (node == null)
            {
                return "Binary Search Tree is Empty";
            }

            // If current node is in range, then   
            // include it in count and recur for   
            // left and right children of it  
            if (node.Movie_Duration == duration)
         //   if (duration.CompareTo(node.Movie_Duration) == 0)
            {
                mainForm.AddmovielistBox1.Items.Add(" Movie Title  =  " + node.Movie_Title);
                mainForm.AddmovielistBox1.Items.Add(" Movie Cast = " + node.Cast.Display());
                mainForm.AddmovielistBox1.Items.Add("Year Release =  " + node.Movie_Year);
                mainForm.AddmovielistBox1.Items.Add("Movie Duration  = " + node.Movie_Duration);
                mainForm.AddmovielistBox1.Items.Add("Movie Rating  =  " + node.Movie_Rating);
                mainForm.AddmovielistBox1.Items.Add("\n");
                mainForm.AddmovielistBox1.Items.Add("**********************************");
                mainForm.AddmovielistBox1.Items.Add("\n");
                return this.Search_Duration(node.LeftChild, duration) + this.Search_Duration(node.RightChild, duration);
            }

            // If current node is smaller than low,   
            // then recur for right child  

            else if (duration.CompareTo(node.Movie_Duration) > 0)
            {
                return this.Search_Duration(node.RightChild, duration) + this.Search_Duration(node.LeftChild, duration);
            }

            // Else recur for left child  
            else
            {
                return this.Search_Duration(node.LeftChild, duration) + this.Search_Duration(node.RightChild, duration);
            }
            
        }
        public string Search_Rating(Node node, string Rating)
        {
            // Base Case  
            if (node == null)
            {
                return "Binary Search Tree is Empty";
            }

            // If current node is in range, then   
            // include it in count and recur for   
            // left and right children of it  
            //if (node.Movie_Duration == duration)
            if (Rating.CompareTo(node.Movie_Rating) == 0)
            {
               mainForm.AddmovielistBox1.Items.Add(" Movie Title  =  " + node.Movie_Title);
               mainForm.AddmovielistBox1.Items.Add(" Movie Cast = " + node.Cast.Display());
               mainForm.AddmovielistBox1.Items.Add("Year Release =  " + node.Movie_Year);
               mainForm.AddmovielistBox1.Items.Add("Movie Duration  = " + node.Movie_Duration);
               mainForm.AddmovielistBox1.Items.Add("Movie Rating  =  " + node.Movie_Rating);
                mainForm.AddmovielistBox1.Items.Add("\n");
                mainForm.AddmovielistBox1.Items.Add("**********************************");
                mainForm.AddmovielistBox1.Items.Add("\n");
                return this.Search_Rating(node.LeftChild, Rating) + this.Search_Rating(node.RightChild, Rating);
            }

            // If current node is smaller than low,   
            // then recur for right child  

            else if (Rating.CompareTo(node.Movie_Rating) > 0)
            {
                return this.Search_Rating(node.RightChild, Rating) + this.Search_Rating(node.LeftChild, Rating);
            }

            // Else recur for left child  
            else
            {
                return this.Search_Rating(node.LeftChild, Rating) + this.Search_Rating(node.RightChild, Rating);
            }
        }
        //=============Delete Movie  by Movie Title

        /* A recursive function to insert a new key in BST */
     public Node deleteMovieByTitle(Node root, string key)
        {
            /* Base Case: If the tree is empty */
            if (root == null)
            {
                MessageBox.Show("Binary Search Tree is Empty");
                return root;
            }
            /* Otherwise, recur down the tree */
            if (key.CompareTo(root.Movie_Title) < 0)
                root.LeftChild = deleteMovieByTitle(root.LeftChild, key);
            else if (key.CompareTo(root.Movie_Title) > 0)
                root.RightChild = deleteMovieByTitle(root.RightChild, key);

            // if key is same as root's key, then This is the node  
            // to be deleted  
            else
            {
                // node with only one child or no child  
                if (root.LeftChild == null)
                    return root.RightChild;
                else if (root.RightChild == null)
                    return root.LeftChild;

                // node with two children: Get the 
                // inorder successor (smallest  
                // in the right subtree)  
                root.Movie_Title = minValue(root.RightChild);

                // Delete the inorder successor  
                root.RightChild = deleteMovieByTitle(root.RightChild, root.Movie_Title);
            }
            return root;
        }
        //Find Minimum value for deletion of root node to check in its right(left) part most minimum value
        string minValue(Node root)
        {
            string minv = root.Movie_Title;
            while (root.LeftChild != null)
            {
                minv = root.LeftChild.Movie_Title;
                root = root.LeftChild;
            }
            return minv;
        }
        public string SearchMovie_ByCast(Node node,string Cast)
        {
            // Base Case  
            if (node == null)
            {
                return "Binary Search Tree is Empty";
            }

            // If current node is in range, then   
            // include it in count and recur for   
            // left and right children of it  
            //if (node.Movie_Duration == duration)
            if (Cast.CompareTo(node.Cast.Search(Cast))== 0)
            {
                mainForm.AddmovielistBox1.Items.Add(" Movie Title  =  " + node.Movie_Title);
                mainForm.AddmovielistBox1.Items.Add(" Movie Cast = " + node.Cast.Display());
                mainForm.AddmovielistBox1.Items.Add("Year Release =  " + node.Movie_Year);
                mainForm.AddmovielistBox1.Items.Add("Movie Duration  = " + node.Movie_Duration);
                mainForm.AddmovielistBox1.Items.Add("Movie Rating  =  " + node.Movie_Rating);
                mainForm.AddmovielistBox1.Items.Add("\n");
                mainForm.AddmovielistBox1.Items.Add("**********************************");
                mainForm.AddmovielistBox1.Items.Add("\n");
                return this.SearchMovie_ByCast(node.LeftChild, Cast) + this.SearchMovie_ByCast(node.RightChild, Cast);
            }

            // If current node is smaller than low,   
            // then recur for right child  

            else if (Cast.CompareTo(node.Cast.Search(Cast)) > 0)
            {
                return this.SearchMovie_ByCast(node.RightChild, Cast) + this.SearchMovie_ByCast(node.LeftChild, Cast);
            }

            // Else recur for left child  
            else
            {
                return this.SearchMovie_ByCast(node.LeftChild, Cast) + this.SearchMovie_ByCast(node.RightChild, Cast);
            }
        }
    }
   
}




