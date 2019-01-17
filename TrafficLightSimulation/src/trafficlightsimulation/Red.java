/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package trafficlightsimulation;

import javafx.scene.paint.Color;
import static trafficlightsimulation.TrafficLightSimulation.greenCircle;
import static trafficlightsimulation.TrafficLightSimulation.redCircle;
import static trafficlightsimulation.TrafficLightSimulation.red1;
/**
 *
 * @author Michelle
 */
public class Red implements Runnable {

    public Red() {
    }
    
        @Override
        public void run() {
            synchronized (this) {

                greenCircle.setFill(Color.WHITE);

                redCircle.setFill(Color.RED);
                try {
                    Thread.sleep(Integer.parseInt(red1.getText())* 1000);
                } catch (InterruptedException e) {
                }

            }

        }

    }




