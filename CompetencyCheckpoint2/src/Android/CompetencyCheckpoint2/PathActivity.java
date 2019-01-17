/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package Android.CompetencyCheckpoint2;


import android.app.Activity;
import android.content.Context;
import android.graphics.Canvas;
import android.os.Bundle;
import android.graphics.Color;
import android.graphics.Paint;
import android.graphics.Path;
import android.view.MotionEvent;
import android.view.View;
import android.widget.RelativeLayout;

/**
 *
 * @author Michelle
 */
public class PathActivity extends Activity {

    Path path =  new Path();
    /**
     * Called when the activity is first created.
     */
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
      setContentView(R.layout.main_path);
      
  final RelativeLayout relative = (RelativeLayout)findViewById(R.id.path_view);
  relative.setOnTouchListener(new View.OnTouchListener() {

            public boolean onTouch(View v, MotionEvent event) {
               
                float eventx = event.getX();
                float eventy = event.getY();        
                switch(event.getAction()){
                    
                    case MotionEvent.ACTION_MOVE:
                         path.lineTo(eventx, eventy);
                   
                    case MotionEvent.ACTION_DOWN:
                        path.moveTo(eventx, eventy);
                        
                     break;
                        
                    case MotionEvent.ACTION_UP:
                        relative.addView(new drawPath(relative.getContext()));
                        break;
                        
                    default:
                        break;
                }
                relative.invalidate();
                return true;
            }
        });
  
 }
    
   public class drawPath extends View{

       
       Paint paint = new Paint();
       
        public drawPath(Context context) {
            super(context);
            
            paint.setAntiAlias(true);
            paint.setColor(Color.MAGENTA);
            paint.setStyle(Paint.Style.STROKE);
            paint.setStrokeWidth(3f);
            
        }
       @Override
       public void onDraw(Canvas canvas){
           super.onDraw(canvas );
           canvas.drawPath(path, paint);
       }
       
   }
    
}
