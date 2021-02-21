using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DATASTRUCTURES
{
    public partial class AddmovieForm : Form
    {
        // Binary Search Class instance
        public Binary_Search_Tree BST;

        public AddmovieForm()
        {
            InitializeComponent();
            // "this" will allow to Binary Search Class to Access AddMovieForm attribute
            // (e:g List Box) in its Insert, Delete, Search & Display Methods.
            BST = new Binary_Search_Tree(this);

        }
        private void Addbutton_Click(object sender, EventArgs e)
        {
            // if check the textbox values either null or not.
            if (movienametext.Text != null && moviecasttext.Text != null && movieyearreleasetext.Text != null
                && moviedurationtext.Text != null && movieratingtext.Text != null)
            {
                try
                {

                    int year = int.Parse(movieyearreleasetext.Text);
                    BST.Insert(movienametext.Text, Cast, year, moviedurationtext.Text, movieratingtext.Text);
                    Cast = null;
                    Cast = new MyStringList();
                    movienametext.Clear();
                    moviecasttext.Clear();
                    movieyearreleasetext.Clear();
                    moviedurationtext.Clear();
                    movieratingtext.Clear();
                    MessageBox.Show("Movie Add!");
                }
                catch
                {
                    MessageBox.Show("Movie Cannot Add.");
                }
            }

            else
            {
                MessageBox.Show("Please insert all values");
            }

        }

        private void InOrderDispaly_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear List Box Previous Values
                AddmovielistBox1.Items.Clear();
                BST.Inorder(BST.root);
            }
            catch
            {
                MessageBox.Show("Movie Cannot Dispaly");
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Delete Movie By Title.
            // Check Text Box values null or not.
            if (movienametext.Text != null)
            {
                try
                {
                    AddmovielistBox1.Items.Clear();
                    BST.deleteMovieByTitle(BST.root, movienametext.Text);
                    MessageBox.Show("Deleted");
                }
                catch
                {
                    MessageBox.Show(" Movie Not Deleted");
                }
            }
            else
            {
                MessageBox.Show("Please enter value in text Box");
            }

        }

        private void Searchbuttonmovie_Click(object sender, EventArgs e)
        {
            // Search Movie By Title.
            // Check Text Box Value Null or Not.
            if (movienametext.Text != null)
            {
                try
                {
                    AddmovielistBox1.Items.Clear();
                    BST.Search_MovieTitle(BST.root, movienametext.Text);
                    movienametext.Clear();// this will clear text box value
                }
                catch
                {
                    MessageBox.Show("Cannot Search");
                }
            }
            else
            {
                MessageBox.Show("Please enter value in text Box");
            }
        }

        private void yearsearch_Click(object sender, EventArgs e)
        {
            // Search Movies By Year Release
            if (movieyearreleasetext.Text != null)
            {
                try
                {
                    AddmovielistBox1.Items.Clear();
                    int year = int.Parse(movieyearreleasetext.Text);
                    BST.Search_Year(BST.root, year);
                    movieyearreleasetext.Clear();// this will clear text box value

                }
                catch
                {
                    MessageBox.Show("Year Cannot Search");
                }
            }
            else
            {
                MessageBox.Show("Please enter value in text Box");
            }
        }

        private void timeperiodsearch_Click(object sender, EventArgs e)
        {
            //Search Movies By TimePeriod(e:g 2010 - 2019)
            if (lowtime.Text != null && highyear.Text != null)
            {
                try
                {
                   
                    Node node = new Node();
                    int low = int.Parse(lowtime.Text);
                    int high = int.Parse(highyear.Text);
                    BST.TimePeriodSearch(BST.root, low, high);
                    lowtime.Clear();// this will clear text box value
                    highyear.Clear();// this will clear text box value
                    AddmovielistBox1.Items.Clear();
                    AddmovielistBox1.Items.Add("Movies Between  [" + low + ", " + high + "] are " + BST.TimePeriodSearch(BST.root, low, high));
                }
                catch
                {
                    MessageBox.Show("TimePeriod Cannot Search");
                }
            }
            else
            {
                MessageBox.Show("Please enter value in text Box");
            }
        }

        private void durationsearch_Click(object sender, EventArgs e)
        {
            // Search movie By Duartion
            if (moviedurationtext.Text != null)
            {
                try
                {
                    AddmovielistBox1.Items.Clear();
                    BST.Search_Duration(BST.root, moviedurationtext.Text);
                    moviedurationtext.Clear();// this will clear text box value
                }
                catch
                {
                    MessageBox.Show("Duration Cannot Search");
                }
            }
            else
            {
                MessageBox.Show("Please enter value in text Box");
            }
        }


        MyStringList Cast = new MyStringList();
        private void addcastbutton1_Click(object sender, EventArgs e)
        {
            //add multiple cast
            if (moviecasttext.Text != null)
            {
                try
                {
                    string Value = moviecasttext.Text;
                    moviecasttext.Clear();
                    Cast.add(Value);
                    MessageBox.Show("Cast Add");
                }
                catch
                {
                    MessageBox.Show("Cannot Add Cast");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Value in Cast TextBox");
            }
           
        }

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            // Exit Application.
            MessageBox.Show("Thank you !");
            Application.Exit();
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            // Again Open form1(Welcome From)
            Form1 open = new Form1();
            open.Show();
            this.Hide();
        }

        private void movieratingsearchbutton_Click(object sender, EventArgs e)
        {
            // Search Movie By Movie  Rating
            if (movieratingtext.Text != null)
            {
                try
                {
                    AddmovielistBox1.Items.Clear();
                    BST.Search_Rating(BST.root, movieratingtext.Text);
                    movieratingtext.Clear();// this will clear text box value
                }
                catch
                {
                    MessageBox.Show("Rating Cannot Search");
                }
            }
            else
            {
                MessageBox.Show("Please enter value in text Box");
            }
        }

        private void castsearch_Click(object sender, EventArgs e)
        {
            //Search Movie By Cast
            if (moviecasttext.Text != null)
            {
                try
                {
                    AddmovielistBox1.Items.Clear();
                    BST.SearchMovie_ByCast(BST.root, moviecasttext.Text);
                    moviecasttext.Clear();
                }
                catch
                {
                    MessageBox.Show("Cannot Search");
                }
            }
        }

    }
}