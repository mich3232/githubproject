package trafficlightsimulation;


import java.util.logging.Level;
import java.util.logging.Logger;
import javafx.application.Application;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.geometry.Insets;
import javafx.geometry.Pos;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.GridPane;
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;
import javafx.scene.shape.Circle;
import javafx.scene.shape.Rectangle;
import javafx.stage.Stage;

public class TrafficLightSimulation extends Application implements Runnable{

    static Circle redCircle;
    static Circle amberCircle;
    static Circle greenCircle;
    Thread thread = new Thread(this);
    Label green = new Label();
    static TextField green1 = new TextField("3");
    Label amber = new Label();
    static TextField amber1  = new TextField("3");
    Label red = new Label();
    static TextField red1  = new TextField("3");
    Button start = new Button("Start");
    Button stop = new Button("Stop");
    
    public static void main(String[] args)  {
        Application.launch(args);
    }   
   
    @Override
    public void start(Stage primaryStage) {
       
        GridPane gridPane = new GridPane();
        
        primaryStage.setTitle("Traffic Light Simulation");
        BorderPane borderPane = new BorderPane();
        Pane pane = new Pane();
        Rectangle rectangle = new Rectangle(220, 10,80, 250);
        rectangle.setFill(Color.BLACK);
        redCircle = new Circle(260, 60, 30);
        amberCircle = new Circle(260, 130, 30);
        greenCircle = new Circle(260, 200, 30);
        redCircle.setFill(Color.WHITE);
        amberCircle.setFill(Color.WHITE);
        greenCircle.setFill(Color.WHITE);
        
        gridPane.add(green, 0,0);
        gridPane.add(green1, 1,0);
        gridPane.add(amber, 0,1);
        gridPane.add(amber1, 1,1);
        gridPane.add(red, 0,2);
        gridPane.add(red1, 1,2);
        gridPane.add(start, 0, 3);
        gridPane.add(stop, 1, 3);
        gridPane.setHgap(5.0);
        gridPane.setVgap(5.0);
        gridPane.setAlignment(Pos.BOTTOM_LEFT);
        gridPane.setPadding( new Insets(10,10,10,10));
        
        pane.getChildren().addAll(rectangle, redCircle, amberCircle, greenCircle, gridPane);
        borderPane.setCenter(pane);
                
        Scene scene = new Scene(borderPane, 400, 400);
        primaryStage.setScene(scene);
        primaryStage.show();
        
        stop.setOnAction(new EventHandler<ActionEvent>() {

            @Override
            public void handle(ActionEvent e) {
                stopTrafficLights();
            }
        });
        
        start.setOnAction(new EventHandler<ActionEvent>() {

            @Override
            public void handle(ActionEvent e) {
              thread.start();
            }
        });
    }
        
    public void stopTrafficLights(){
            if(thread != null){
                thread.stop();
                thread = null;
        }
    }

    @Override
    public void run() {
       
        while (true) {
            Thread goToRed = new Thread((Runnable) new Red());
            goToRed.start();
            synchronized (goToRed) {
                try {
                    goToRed.wait();

                } catch (InterruptedException ex) {

                }
                Thread goToAmber = new Thread((Runnable)new Amber());
                goToAmber.start();
                synchronized (goToAmber) {
                    try {
                        goToAmber.wait();
                    } catch (InterruptedException ex) {

                    }
                    Thread goToGreen = new Thread((Runnable)new Green());
                    goToGreen.start();
                    synchronized (goToGreen) {
                        try {
                            goToGreen.wait();
                        } catch (InterruptedException ex) {

                        }

                    }
                }
            }
        }
    }
}
  
    
    

    

      

          

