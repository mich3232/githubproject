using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Checkpoint2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        //Declares arraylist ActorsarrayList
        ArrayList ActorArrayList = new ArrayList();
        //Reads file and populates arraylist 
        TextReader tr;
        void LoadArrayList()
        {
            try
                {
                    tr = File.OpenText("C:\\Actor.txt");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening file!");
                }
                string Actor;
                while (true)
                {
                    Actor = tr.ReadLine();

                    if (Actor == null)
                    {
                        break;
                    }
                    ActorArrayList.Add(Actor);
                }
                tr.Close();
                }
         //Writes The array list back to file 
        void WriteArrayList()
        {
            TextWriter tw;
            savTextFile.ShowDialog();
            if (savTextFile.FileName != "")
                try
                {

                    tw = File.CreateText("C:\\Actor.txt");
                    foreach (string line in ActorArrayList)
                    {
                        tw.WriteLine(line);
                    }
                    tw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error writing array");
                }
        }// sends array list to the combobox
        void PopulateActors()
        {
            cboActor.Items.Clear();
            foreach (string line in ActorArrayList)
            {
                cboActor.Items.Add(line);
            }
        }
        //Inserts a new object into Array list and checks if actor name and position are entered
        void InsertIntoArrayList()
        {if (String.IsNullOrEmpty(txtPosition.Text))
            {
                MessageBox.Show("Please enter a position number");
                Application.Exit();
            }
            if (String.IsNullOrEmpty(txtActorName.Text))
            {
                MessageBox.Show("Please enter an actor name");
                Application.Exit();
            }
            string Actor;
            int PosNum;
            Actor = txtActorName.Text;
                if (!int.TryParse(txtPosition.Text, out PosNum))
            {
                // show message
                return;
            }
                else if (PosNum < 0 || PosNum > ActorArrayList.Count)
            {
                // show message
                return;
            }

            ActorArrayList.Insert(PosNum, Actor);
        }
        //Deletes an object from the array list and checks that position is entered
        void DeleteFromArrayList()
        {
            if (String.IsNullOrEmpty(txtPosition.Text))
            {
                MessageBox.Show("Please enter a position number");
                Application.Exit();
            }
                int PosNum;
                if (!int.TryParse(txtPosition.Text, out PosNum))
                {
                    // show message
                    return;
                }
                    ActorArrayList.RemoveAt(PosNum);
            }
    //Calls to methods load array list and populate Actors from a menu item
        private void mnuRead_Click(object sender, EventArgs e)
        {
            LoadArrayList();
            PopulateActors();
        }
        //calls method Write arry list from an menu item
        private void mnuWrite_Click(object sender, EventArgs e)
        {
            WriteArrayList();
        }
        //calls methods insert into array list and populate actors on a button click
        private void btnInsert_Click(object sender, EventArgs e)
         {
                InsertIntoArrayList();
                PopulateActors();

         }
        //calls methods delete from array list and populate actors on a button click
        private void btnDelete_Click(object sender, EventArgs e)
        {

                DeleteFromArrayList();
                PopulateActors();
        }
        //This exits the application when selected from a menu item
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

