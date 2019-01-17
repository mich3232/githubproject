using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkpoint1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float MINLENGTH = 5.0F;
        float MAXLENGTH = 50.0F;
        float MINWIDTH = 2.0F;
        float MAXWIDTH = 20.0F;
        float MINAVGDEPTH = 2.0F;
        float MAXAVGDEPTH = 4.0F;
        bool ValidLength = false;
        bool ValidWidth = false;
        bool ValidAvgDepth = false;
        float Length = 0.0F;
        float Width = 0.0F;
        float AvgDepth = 0.0F;
        float PoolVolume = 0.0F;
        float AvgTemp = 5.0F;
        float HeatingCost = 0.0F;
        

       //Method that calculates the surface area of the pool
        void SurfaceAreaCalculate()
        {
            txtSurfaceArea.Text = (float.Parse(txtLength.Text) *
                float.Parse(txtWidth.Text)).ToString();
        }
        //Metod that calculates the volume of the pool
         void VolumeCalculate()   
         {   
             txtVolume.Text = (float.Parse(txtLength.Text) * float.Parse(txtWidth.Text) * float.Parse(txtAvgDepth.Text) * 1000).ToString();
         }
        // Method for calculating the the category of the pool depending on the volume amount   
        void CategoryCalculate()
        {
        String Output = "";
            if (PoolVolume < 500000)
            {
                Output += "Pool Category: Small";
            }
            else if (PoolVolume < 1500000)
            {
                Output += "Pool Category: Medium";
            }
            else
            {
                Output += "Pool Category: Large";
            }

            PoolVolume = float.Parse(txtVolume.Text);
            lblCategory.Text = Output;
        }
        


        //This click event handler tells the exit button to close the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //This click event handler tels the calculate button to call methods to test the length, width, and depth for validity and then to calculate the pools heating cost using the average temperature incremented by 1.5 while <= 23 and the pool volume formula 
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            testLength(Length);
            testWidth(Width);
            testAvgDepth(AvgDepth);


            for (AvgTemp = 5.0F; AvgTemp <= 23; AvgTemp += 1.5F)
            {
                HeatingCost = (25 - AvgTemp) * PoolVolume / 32500;
                txtTableAvgTemp.Text += "\n\r" + AvgTemp + "\n\r";
                txtHeatingCost.Text += "\n\r" + HeatingCost + "\n\r";
                
            }
        }
        
          
        //Method that checks if length is valid an if not shows a message box and if it is valid it calls SurfaceAreaCalculate method, VolumeCalculate and Categorycalculate to run the program. 
       void testLength(float Length)
        {
            Length = float.Parse(txtLength.Text);

            if (Length >= MINLENGTH && Length <= MAXLENGTH)
            {
            ValidLength = true;
            SurfaceAreaCalculate();
            VolumeCalculate();
            CategoryCalculate();
            
            }
            else
            {
                
            DialogResult Result;

            Result = MessageBox.Show("Length measurement invalid" + "\r\n" + "Please enter a value between 5 and 50", "Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (Result == DialogResult.OK)
            {
                Application.Exit();
                ValidLength = false;
            } 
        }
    }
       //Method that checks if width is valid an if not shows a message box and if it is valid it calls SurfaceAreaCalculate method, VolumeCalculate and Categorycalculate to run the program.
        void testWidth(float Width)
        {
            Width = float.Parse(txtWidth.Text);

            if (Width >= MINWIDTH && Width <= MAXWIDTH)
            {
                ValidWidth = true;
                SurfaceAreaCalculate();
                VolumeCalculate();
                CategoryCalculate();
            
            }
            else
            {
                 DialogResult Result1;

            Result1 = MessageBox.Show("Width measurement invalid" + "\r\n" + "Please enter a value between 2 and 20", "Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (Result1 == DialogResult.OK)
            {
                Application.Exit();
                ValidLength = false;
            }
        }
    }
        //Method that checks if Avgdepth is valid an if not shows a message box and if it is valid it calls SurfaceAreaCalculate method, VolumeCalculate and Categorycalculate to run the program.
        void testAvgDepth(float AvgDepth)
        {
            AvgDepth = float.Parse(txtAvgDepth.Text);

            if (AvgDepth >= MINAVGDEPTH && AvgDepth <= MAXAVGDEPTH)
            {
                ValidAvgDepth = true;
                SurfaceAreaCalculate();
                VolumeCalculate();
                CategoryCalculate();
                
            }
            else
            {
             DialogResult Result2;

             Result2 = MessageBox.Show("Avgdepth measurement invalid" + "\r\n" + "Please enter a value between 2 and 4", "Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (Result2 == DialogResult.OK)
            {
                Application.Exit();
                ValidAvgDepth = false;
            }
           
               
            
                    
                }
            }
        }
    }
                
       
       

