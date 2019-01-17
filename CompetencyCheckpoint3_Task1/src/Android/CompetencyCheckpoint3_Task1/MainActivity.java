package Android.CompetencyCheckpoint3_Task1;

import Android.CompetencyCheckpoint3_Task1.R.string;
import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

public class MainActivity extends Activity
{   

    /**
     *
     */
 

    /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);
    }


    public void DisplayData(View v)
    {
        String value;
       
        value = "Product Name: " + android.os.Build.PRODUCT + "\n" + "The Brand: " + android.os.Build.BRAND + "\n" + "The Device: " + android.os.Build.DEVICE + "\n" + "The Manufacture: " + android.os.Build.MANUFACTURER + "\n" + "The Serial Number: " + android.os.Build.SERIAL;
        TextView text = new TextView(this);
        text.setText(value);
        setContentView(text);
        
    }
}
        
       