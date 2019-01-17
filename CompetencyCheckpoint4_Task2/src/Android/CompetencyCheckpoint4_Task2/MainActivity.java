package Android.CompetencyCheckpoint4_Task2;

import android.app.Activity;
import android.content.Intent;

import android.os.Bundle;
import android.text.method.HideReturnsTransformationMethod;
import android.text.method.PasswordTransformationMethod;
import android.view.View;
import android.widget.CheckBox;
import android.widget.EditText;

import android.widget.CompoundButton;
import android.widget.CompoundButton.OnCheckedChangeListener;
import android.widget.TextView;

import java.io.BufferedReader;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;

public class MainActivity extends Activity
{
    TextView message;
    EditText pword;
    EditText uname;
    CheckBox spword;
    String input; 
    String input1; 
    /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);
        
        
        pword = (EditText) findViewById(R.id.etPassword);
        spword = (CheckBox) findViewById(R.id.cbShowPwd);
        uname = (EditText) findViewById(R.id.etUsername);
        spword.setOnCheckedChangeListener(new OnCheckedChangeListener() {

            public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
                if (!isChecked) {
                    // show password
                    pword.setTransformationMethod(PasswordTransformationMethod.getInstance());
                } else {
                    // hide password
                    pword.setTransformationMethod(HideReturnsTransformationMethod.getInstance());
                }
            }
         });
    }
    public void saveLogin(View view) throws FileNotFoundException, IOException {
    input = uname.getText().toString() + pword.getText().toString();
        
        try {
            FileOutputStream output = openFileOutput("logindetails.txt", MODE_PRIVATE);
            output.write(input.getBytes());
            output.close();
            uname.setText("");
            pword.setText("");
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
     public void Logon(View view)  throws FileNotFoundException, IOException{
        
         String compare;
         message = (TextView)findViewById(R.id.txtMessage);
        
         try {
            FileInputStream instream
                    = openFileInput("logindetails.txt");
            InputStreamReader reader = new InputStreamReader(instream);
            BufferedReader buff = new BufferedReader(reader);
            
            String str;
            compare = uname.getText().toString()+ pword.getText().toString();
            
            while ((str = buff.readLine()) != null) {
                
               if(str.equals(compare)){
                   Intent intent = new Intent(this, LoginActivity.class);
                   startActivity(intent);
               }else{
                  message.setText("Sorry wrong logon details. Try again");
               }
            }
               reader.close();
               }
            catch(IOException e)
            {
            e.printStackTrace();
            }
        }

       
}


         
         
         
         
       

    
 

