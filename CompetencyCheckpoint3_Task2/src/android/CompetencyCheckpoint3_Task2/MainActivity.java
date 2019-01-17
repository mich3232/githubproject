package android.CompetencyCheckpoint3_Task2;

import android.app.Activity;
import android.os.Bundle;
import android.app.Activity;
import android.os.Bundle;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import org.apache.http.impl.client.DefaultHttpClient;
import org.apache.http.client.HttpClient;
import org.apache.http.client.ClientProtocolException;
import org.apache.http.HttpResponse;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.HttpEntity;
import org.json.JSONObject;
import org.json.JSONArray;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;


public class MainActivity extends Activity
{
        EditText north; 
        EditText east; 
        EditText west; 
        EditText south; 
        TextView earthquake; 
        String latitude;
        String longitude;
        String magnitude;
        String datetime;
        String country = "Country:";
        
        
        /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);
        north = (EditText) findViewById(R.id.northText);
        east = (EditText) findViewById(R.id.eastText);
        west = (EditText) findViewById(R.id.westText);
        south = (EditText) findViewById(R.id.southText); 
        earthquake = (TextView) findViewById(R.id.earthquakeText);
        
    }
    public void ViewInformation(View view) {
        String url
                = "http://api.geonames.org/earthquakesJSON?north=" + north.getText() + "&south=" + south.getText() + "&east=" + east.getText() + "&west=" + west.getText() + "&maxRows=1&username=newuser";

        HttpClient client = new DefaultHttpClient();
        HttpGet get = new HttpGet(url);

        StringBuilder builder = new StringBuilder();

        try {
            HttpResponse response = client.execute(get);
            HttpEntity entity = response.getEntity();
            InputStream inputStream = entity.getContent();
            BufferedReader reader = new BufferedReader(new InputStreamReader(inputStream));

            String line;
            while ((line = reader.readLine()) != null) {
                builder.append(line);

            }
            String result = builder.toString();
            this.DisplayInformation(result);
        } catch (ClientProtocolException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
        String url1
                = "http://api.geonames.org/findNearbyPlaceNameJSON?lat=" + latitude.toString() + "&lng=" + longitude.toString() + "&username=newuser";
        HttpClient client1 = new DefaultHttpClient();
        HttpGet get1 = new HttpGet(url1);
        StringBuilder builder1 = new StringBuilder();
        try {
            HttpResponse response1 = client.execute(get1);
            HttpEntity entity1 = response1.getEntity();
            InputStream inputStream1 = entity1.getContent();
            BufferedReader reader1 = new BufferedReader(new InputStreamReader(inputStream1));
            String line1;
            while ((line1 = reader1.readLine()) != null) {
                builder1.append(line1);
            }
            String result1 = builder1.toString();
            this.DisplayCountryInformation(result1);
        } catch (ClientProtocolException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
    

    private void DisplayInformation(String result) {
        try {
            JSONObject jsonObject = new JSONObject(result);
            JSONArray arr = new JSONArray(jsonObject.getString("earthquakes"));

            for (int a = 0; a < arr.length(); a++) {
                JSONObject element = arr.getJSONObject(a);
                longitude = element.getString("lng");
                latitude = element.getString("lat");
                magnitude = element.getString("magnitude");
                datetime =  element.getString("datetime");            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private void DisplayCountryInformation(String result) {
        try {
            JSONObject jsonObject1 = new JSONObject(result);
            JSONArray arr1 = new JSONArray(jsonObject1.getString("geonames"));

            for (int b = 0; b < arr1.length(); b++) {
                JSONObject element1 = arr1.getJSONObject(b);
                earthquake.setText("Country: " + element1.getString("countryName") + ("\n") + ("Magnitude: " + magnitude.toString()) + ("\n") + ("Date and Time: " + datetime.toString()));
            }
        } catch (Exception e) {
            e.printStackTrace();
        }

    }

    public void ResetInformation(View view) {
        north.setText("");
        east.setText("");
        west.setText("");
        south.setText("");
        earthquake.setText("");

    }
}
