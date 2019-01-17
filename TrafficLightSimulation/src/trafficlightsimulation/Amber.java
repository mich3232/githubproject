/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package trafficlightsimulation;

import javafx.scene.paint.Color;
import static trafficlightsimulation.TrafficLightSimulation.amberCircle;
import static trafficlightsimulation.TrafficLightSimulation.redCircle;
import static trafficlightsimulation.TrafficLightSimulation.amber1;

public class Amber implements Runnable {

    public Amber() {
    }

    @Override
    public void run() {
        synchronized (this) {

            redCircle.setFill(Color.WHITE);
            amberCircle.setFill(Color.YELLOW);

            try {
                Thread.sleep(Integer.parseInt(amber1.getText())* 1000);
            } catch (InterruptedException ex) {

            }

        }

    }
}
