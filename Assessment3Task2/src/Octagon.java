/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Michelle
 */
public class Octagon extends GeometricObject implements Cloneable, Comparable<Octagon> {
    private static double side;
    public Octagon(){
        
    }
    
    public Octagon(double side){
        this.side = side;
        
    }
    
    public double getSide(){
        return side;
    }
    
    public void setSide(double side) {
        this.side = side;
    }
    
    public static double getArea() {
        return (2 + 4/(Math.sqrt(2))) * side * side; 
    }
    
    public static double getPerimeter() {
        return side * 8;
    }
  
    @Override
    public int compareTo(Octagon octagon) {
        if (getArea() > octagon.getArea()) {
            return 1;
            
        } else if (getArea() < octagon.getArea()) {
            return -1;
        } else {
            return 0;
            
        }
    }

    @Override
    public Octagon clone() throws CloneNotSupportedException {
        return new Octagon(this.side);
        
    }

    
    
    public static void main(String[] args) throws CloneNotSupportedException  {
         Octagon octagon1 = new Octagon(5.0); 
         Octagon octagon2 = (Octagon)octagon1.clone();
         
         System.out.println("Octagon1's area is " + getArea() + " and perimeter is " + getPerimeter());
         System.out.println("The compareTo method reads " + (octagon1.compareTo(octagon2) == 0));
    }

    
    public abstract class GeometricObject {

        private String color = "white";
        private boolean filled;

        /**
         * Construct a default geometric object
         */
        protected GeometricObject() {
            
        }

        /**
         * Construct a geometric object with color and filled value
         */
        protected GeometricObject(String color, boolean filled) {

            this.color = color;
            this.filled = filled;
        }

        /**
         * Return color
         */
        public String getColor() {
            return color;
        }

        /**
         * Set a new color
         */
        public void setColor(String color) {
            this.color = color;
        }

        /**
         * Return filled. Since filled is boolean, the get method is named
         * isFilled
         */
        public boolean isFilled() {
            return filled;
        }

        /**
         * Set a new filled
         */
        public void setFilled(boolean filled) {
            this.filled = filled;
        }

        /**Abstract method getArea */
        public abstract double getArea();
        
        /**Abstract method getPerimeter */
        public abstract double getPerimeter();
    }
    
}   
