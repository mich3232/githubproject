/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package assessment2task2;

import static java.awt.geom.Point2D.distance;

/**
 *
 * @author Michelle
 */
public class Circle2D {

    //declare variables
    double radius;
    double area;
    double x, y;

    //no args constructor   
    public Circle2D() {
        x = 0;
        y = 0;
        radius = 3.0;
    }

    //Constructor with three arguments

    private Circle2D(double x, double y, double radius) {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }

    //method that caculates area of a given circe 

    public double getArea() {
        double area = Math.PI * Math.pow(radius, 2);
        return area;
    }

    //method that calculates perimeter of a given circle    

    public double getPerimeter() {
        double perimeter = 2 * Math.PI * radius;
        return Math.round(perimeter * 100) / 100;
    }

    //method that gers x

    public double getX() {
        return x;
    }

    //method that gers y

    public double getY() {
        return y;
    }

    //method that gers radius

    public double getRadius() {
        return radius;
    }

    //method that checks if 1 circle contains coordinates
    public boolean containsCoordinates(double x, double y) {
       return Math.sqrt(Math.pow( x - this.x  , 2) + Math.pow(y - this.y, 2)) < radius;
        }
    
    //method that checks if 1 circle contains another circle
    public boolean containsCircle(Circle2D circle) {
       return Math.sqrt(Math.pow(x - this.getX(), 2) + y - Math.pow(this.getY(), 2))+ circle.radius <= Math.abs(this.getRadius());
    }

    //method that checks if 2 circles over lap
    public boolean overlaps(Circle2D circle) {
       return Math.sqrt(Math.pow( x - this.getX(), 2) + Math.pow( y -this.getY() , 2)) <= Math.pow(circle.radius + this.getRadius(), 2);
    }

    public static void main(String[] args) {

        // create new circle object and prints out area perimeter and true or false on the contain and overlap methods
        Circle2D circle1 = new Circle2D(2, 2, 2.5);

        System.out.println("Circle 1 area = " + circle1.getArea() + " perimeter = " + circle1.getPerimeter());
        System.out.println("Does circle 1 contain coordinates 3, 3 ? " + circle1.containsCoordinates(3, 3));
        System.out.println("Does circle 1 contain circle 3? " + circle1.containsCircle(new Circle2D(4, 5, 8.5)));
        System.out.println("Does circle 1 overlap circle 4? " + circle1.overlaps(new Circle2D(3, 5, 0.3)));
    }

}
