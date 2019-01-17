/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package assessment1task2;

import java.util.Scanner;

/**
 *
 * @author Michelle
 */
public class Assessment1Task2 {

    /**
     * @param args the command line arguments
     */
    
    public static void main(String[] args) {
        //Prpgram to calculate tax rates
       //Taxrate constant variables for filing statuses 0 to 3
       final double TAXRATE1 = 0.10;
       final double TAXRATE2 = 0.15; 
       final double TAXRATE3 = 0.25;
       final double TAXRATE4 = 0.28;        
       final double TAXRATE5 = 0.33;      
       final double TAXRATE6 = 0.35;
       
       //variables
       int fStatus;
       double tIncome = 0.0; 
       double totalTax = 0.0;
      
       Scanner input = new Scanner(System.in);
       System.out.println("Sample: ");
           
       System.out.print("Enter the filing status, 0 for single filers, 1 for married filing jointly, 2 for married filing separately, and 3 for head of household: "); 
       fStatus = input.nextInt();
       System.out.print("Enter the taxable income: "); 
       tIncome = input.nextDouble();
     
           if(fStatus == 0 ) { // Calculating tax for filing status 0
               if(tIncome > 0 && tIncome  <= 8350.0){
                   totalTax = TAXRATE1 * tIncome; }
               else if (tIncome >= 8351.00 && tIncome <= 33950.0){
                   totalTax = TAXRATE2 * tIncome;}
               else if(tIncome >= 33951.0 && tIncome <= 82250.0){
                   totalTax = TAXRATE3 * tIncome;}
               else if(tIncome >= 82251.0 && tIncome <= 171550.0){
                   totalTax = TAXRATE4 * tIncome;}
               else if(tIncome >= 171551.0 && tIncome <= 372950.0){
                   totalTax = TAXRATE5 * tIncome;}
               else if(tIncome >= 372951.0){
                   totalTax = TAXRATE6 * tIncome;}
               System.out.println("Tax is $" + totalTax); //printing tax
           }
           else if(fStatus == 1 ) {// Calculating tax for filing status 1
               if(tIncome > 0 && tIncome  <= 16700.0){
                   totalTax = TAXRATE1 * tIncome; }
               else if (tIncome >= 16701.00 && tIncome <= 67900.0){
                   totalTax = TAXRATE2 * tIncome;}
               else if(tIncome >= 67901.0 && tIncome <= 137050.0){
                   totalTax = TAXRATE3 * tIncome;}
               else if(tIncome >= 137051.0 && tIncome <= 208850.0){
                   totalTax = TAXRATE4 * tIncome;}
               else if(tIncome >= 208851.0 && tIncome <= 372950.0){
                   totalTax = TAXRATE5 * tIncome;}
               else if(tIncome >= 372951.0){
                   totalTax = TAXRATE6 * tIncome;}
               System.out.println("Tax is $" + totalTax); //printing tax
           }
          else if(fStatus == 2 ) {// Calculating tax for filing status 2
               if(tIncome > 0 && tIncome  <= 8350.0){
                   totalTax = TAXRATE1 * tIncome; }
               else if (tIncome >= 8351.00 && tIncome <= 33950.0){
                   totalTax = TAXRATE2 * tIncome;}
               else if(tIncome >= 33951.0 && tIncome <= 68525.0){
                   totalTax = TAXRATE3 * tIncome;}
               else if(tIncome >= 68526.0 && tIncome <= 104425.0){
                   totalTax = TAXRATE4 * tIncome;}
               else if(tIncome >= 104426.0 && tIncome <= 186475.0){
                   totalTax = TAXRATE5 * tIncome;}
               else if(tIncome >= 186476.0){
                   totalTax = TAXRATE6 * tIncome;}
               System.out.println("Tax is $" + totalTax); //printing tax  
           }
          else if(fStatus == 3 ) {// Calculating tax for filing status 3
               if(tIncome > 0 && tIncome  <= 11950.0){
                   totalTax = TAXRATE1 * tIncome; }
               else if (tIncome >= 11951.00 && tIncome <= 45500.0){
                   totalTax = TAXRATE2 * tIncome;}
               else if(tIncome >= 45501.0 && tIncome <= 117450.0){
                   totalTax = TAXRATE3 * tIncome;}
               else if(tIncome >= 117451.0 && tIncome <= 190200.0){
                   totalTax = TAXRATE4 * tIncome;}
               else if(tIncome >= 190201.0 && tIncome <= 372950.0){
                   totalTax = TAXRATE5 * tIncome;}
               else if(tIncome >= 372951.0){
                   totalTax = TAXRATE6 * tIncome;}
               System.out.println("Tax is $" + totalTax); //printing tax
           }
           else {
               System.out.println("Error: wrong status"); //Error message printout
               System.exit(0);//exit 
            }
        }
    }  

