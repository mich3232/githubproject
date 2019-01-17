using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkpoint_1_Task_1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            Movie[] moviesArray = new Movie[4];
            moviesArray[0] = new Movie() { Title = "Lucky One", Genre = "Romantic", ReleaseDate = new DateTime(2012, 4, 2), Rank = 1 };
            moviesArray[1] = new Movie() { Title = "The Raid", Genre = "Thriller", ReleaseDate = new DateTime(2012, 5, 6), Rank = 2 };
            moviesArray[2] = new Movie() { Title = "The Divide", Genre = "Science Fiction", ReleaseDate = new DateTime(2012, 1, 13), Rank = 3 };
            moviesArray[3] = new Movie() { Title = "Friends with Kids", Genre = "Comedy", ReleaseDate = new DateTime(2012, 3, 9), Rank = 4 };

            foreach (Movie movie in moviesArray)
               {
                if (movie != null)
                    {
                        txtOutput.Text += "Movie: " + movie.Title + "\r\n";
                        txtOutput.Text += "Genre: " + movie.Genre + "\r\n";
                        txtOutput.Text += "Release Date: " + movie.ReleaseDate.ToShortDateString() + "\r\n";
                        txtOutput.Text += "Rank: " + movie.Rank.ToString() + "\r\n" + "\r\n";
                       
                    Array.Clear(moviesArray, 0, moviesArray.Length);
                    }
                else
                {
                    txtOutput.Text += "Null \r\n";
                           
                }
                }
            }
        }
    }


