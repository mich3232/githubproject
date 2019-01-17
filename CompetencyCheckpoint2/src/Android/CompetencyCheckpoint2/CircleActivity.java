/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package Android.CompetencyCheckpoint2;


import android.app.Activity;
import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;

import android.os.Bundle;
import android.view.MotionEvent;
import android.view.View;
import android.widget.RelativeLayout;


/**
 *
 * @author Michelle
 */
public class CircleActivity extends Activity {

    /**
     * Called when the activity is first created.
     */
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main_circle);

        final RelativeLayout relative = (RelativeLayout)findViewById(R.id.circle_view);
        
        relative.setOnTouchListener(new View.OnTouchListener() {
       
        public boolean onTouch(View view, MotionEvent event) {
                
                switch(event.getAction()){

                    case MotionEvent.ACTION_MOVE:

                    case MotionEvent.ACTION_DOWN:
                        float x = event.getX();
                        float y = event.getY();
                        
                        relative.addView(new drawCircle(relative.getContext(),x, y, 15));
                        break;
                        
                    case MotionEvent.ACTION_UP:
                        break;
                        
                    default:
                        break;
                }
                relative.invalidate();
                return true;
            }
        });
       
    }
    public class drawCircle extends View{

       float x, y;
       int radius;
       Paint paint = new Paint();
       
        public drawCircle(Context context, float x, float y, int radius) {
            super(context);
           
            paint.setAntiAlias(true);
            paint.setColor(Color.CYAN);
            paint.setStyle(Paint.Style.STROKE);
            paint.setStrokeWidth(3f);
            this.x = x;
            this.y = y;
            this.radius = 15;
        }
       @Override
       public void onDraw(Canvas canvas){
           super.onDraw(canvas );
           canvas.drawCircle(x, y, radius, paint);
       }
       
   }
    
}
                   
    