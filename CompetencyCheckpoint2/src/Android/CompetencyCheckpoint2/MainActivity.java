package Android.CompetencyCheckpoint2;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class MainActivity extends Activity
{
    /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);
        
        
    }
    public void drawCircles (View view){
startActivity(new Intent("Android.CompetencyCheckpoint2.CircleActivity"));
}
    public void drawPaths (View view){
startActivity(new Intent("Android.CompetencyCheckpoint2.PathActivity"));
}
}
    
    
 
