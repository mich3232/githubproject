using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkpoint_1_Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {

            int total = 0; //declaring int total

            txtOutput.Text += "Filling the array with user input..." + "\r\n";//printing message
            txtOutput.Text += "The product allocation is as follows:" + "\r\n";//printing message

            string[,] toys = new string[5, 4]; //initialising array 
            for (int week = 0; week <= 3; week++) // loop to go through each index to get each value for week
            {
                for (int day = 0; day <= 4; day++) // loop to go through each index to get each value for day
                {
                    int num = 0; //declaring variable
                    toys[day, week] = Microsoft.VisualBasic.Interaction.InputBox("Please enter value for Day " + Convert.ToString(day + 1) + " in week " + Convert.ToString(week + 1) + ".", "Enter Day"); //Prompt for input value
                    try
                    {
                        while (!(int.TryParse(toys[day, week], out num))) //converts the string to an int and returns a message to tell whether valid input has been entered
                        {
                            MessageBox.Show("Not a valid number. Please enter a number.");
                            toys[day, week] = Microsoft.VisualBasic.Interaction.InputBox("Please enter value for Day " + Convert.ToString(day + 1) + " in week " + Convert.ToString(week + 1) + ".", "Enter Day");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Value entered is not a valid format");//message to be returned if invalid input.
                    }
                }
            }

            txtOutput.Text += "\t" + "Mon" + "\t" + "Tue" + "\t" + "Wed" + "\t" + "Thu" + "\t" + "Fri" + "\t" + "\r\n";// prints out day 

            for (int week = 0; week <= 3; week++)//collects all input and prints out array
            {
                txtOutput.Text += "Week " + (week + 1) + "\t";
                for (int day = 0; day <= 4; day++)
                {
                    txtOutput.Text += toys[day, week];
                    if (day != 4)
                    {
                        txtOutput.Text += "\t"; 
                    }
                }
                txtOutput.Text += "\r\n";
            }
            txtOutput.Text += "\r\nRetrieve products on a specific day"; //prints message
           
            for (int week = 0; week <= 3; week++) //runs through whole array and  sums all totals
            {
                for (int day = 0; day <= 4; day++) 
                {
                   int num = 0;
                   int.TryParse(toys[day, week], out num); //converts to int
                        total += num; //totals values
                }
            }

            
            txtOutput.Text += "\r\nThe sum of all products is " + total; //prins message + sum
            
            
           

                    int num1 = 0;//declares variable
                    int num2 = 0;//declares variable

                     
                    string column  = Microsoft.VisualBasic.Interaction.InputBox("Enter what day Number 1-5", "Enter Day");//prompts for day
                           
                        try
                            {
                            while (!(int.TryParse(column, out num1)))//converts the string to an int and returns a message to tell whether valid input has been entered
                                {
                                    MessageBox.Show("Not a valid number. Please enter a number.");
                                    column = Microsoft.VisualBasic.Interaction.InputBox("Enter what day Number 1-5", "Enter Day");
                                    }
                                }

                                catch (Exception)
                                {
                                    MessageBox.Show("Value entered is not a valid format");//message to be returned if invalid input.
                                }

                    string row = Microsoft.VisualBasic.Interaction.InputBox("Enter what week number 1-4", "Enter Week");//prompts for week
                        
                        try
                            {
                            while (!(int.TryParse(row, out num2)))//converts the string to an int and returns a message to tell whether valid input has been entered
                                {
                                    MessageBox.Show("Not a valid number. Please enter a number.");
                                    row = Microsoft.VisualBasic.Interaction.InputBox("Enter what week number 1-4", "Enter Week");
                                    }
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Value entered is not a valid format");//message to be returned if invalid input.
                                }
                                txtOutput.Text += "\r\nProducts completed on that day are: " + toys[num1, num2];//prints message + value for that day/week
                                }
                            }
                        }
            
                 
            
            
             
          



