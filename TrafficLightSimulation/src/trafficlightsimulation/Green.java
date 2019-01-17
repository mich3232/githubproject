/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package trafficlightsimulation;

import javafx.scene.paint.Color;
import static trafficlightsimulation.TrafficLightSimulation.amberCircle;
import static trafficlightsimulation.TrafficLightSimulation.green1;
import static trafficlightsimulation.TrafficLightSimulation.greenCircle;

/**
 *
 * @author Michelle
 */
public class Green implements Runnable {

    public Green() {
    }
    
    @Override
        public void run() {
             synchronized(this) {

      amberCircle.setFill(Color.WHITE) ;
      greenCircle.setFill(Color.GREEN) ;

      try { 
          Thread.sleep(Integer.parseInt(green1.getText())* 1000);
      } catch(InterruptedException e) {}

      }

        }
    }

  

