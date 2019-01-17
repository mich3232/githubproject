package Android.CompetencyCheckpoint4_Task1;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.database.Cursor;

import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;




public class MainActivity extends Activity {

    EditText Id;
    EditText pName;
    EditText Country;
    EditText Year;
    Button add;
    Button view;
    Button delete;
    Button update;
    final DBaseHelper db = new DBaseHelper(this);

    /**
     * Called when the activity is first created.
     */
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);
        Id = (EditText) findViewById(R.id.txtId);
        pName = (EditText) findViewById(R.id.txtPlace);
        Country = (EditText) findViewById(R.id.txtCountry);
        Year = (EditText) findViewById(R.id.txtYear);

        db.open();
        db.close();

        this.add = (Button) findViewById(R.id.btnAdd);

        add.setOnClickListener(new OnClickListener() {

            public void onClick(View v) {
                db.open();
                long in = db.insertValues(Id.getText().toString(), pName.getText().toString(), Country.getText().toString(), Year.getText().toString());
                db.close();
                
                Toast.makeText(MainActivity.this, "Id: " + in + " successfully inserted", Toast.LENGTH_LONG).show();
                Id.setText("");
                pName.setText("");
                Country.setText("");
                Year.setText("");
                }
        });

        this.view = (Button) findViewById(R.id.btnView);

        view.setOnClickListener(new OnClickListener() {

            public void onClick(View v) {
                db.open();
                Cursor cursor = db.retrieveValues(Id.getText().toString());

                cursor.moveToFirst();
                do {
                    
                    String place = cursor.getString(1);
                    String country = cursor.getString(2);
                    String year = cursor.getString(3);
                    
                    pName.setText(place);
                    Country.setText(country);
                    Year.setText(year);
                     
                    
                } while (cursor.moveToNext());
                cursor.close();
                db.close();
                
            }
        });

        this.update = (Button) findViewById(R.id.btnUpdate);

        update.setOnClickListener(new OnClickListener() {

            public void onClick(View v) {
                db.open();
                int upValue = db.updateValues(Id.getText().toString(), pName.getText().toString(), Country.getText().toString(), Year.getText().toString());
                db.close();
                Id.setText("");
                pName.setText("");
                Country.setText("");
                Year.setText("");
                if (upValue > 0) {
                    Toast.makeText(MainActivity.this, "Record updated!",
                            Toast.LENGTH_LONG).show();
                } else {
                    Toast.makeText(MainActivity.this, "No records were updated",
                            Toast.LENGTH_LONG).show();
                    
                }
            }
        });

        this.delete = (Button) findViewById(R.id.btnDelete);

        delete.setOnClickListener(new OnClickListener() {

            public void onClick(View v) {
                db.open();
                int value = db.deleteValues(Id.getText().toString());
                db.close();
                Id.setText("");
                if (value > 0) {
                    Toast.makeText(MainActivity.this, "Record deleted!",
                            Toast.LENGTH_LONG).show();
                } else {
                    Toast.makeText(MainActivity.this, "No records were deleted",
                            Toast.LENGTH_LONG).show();
                   
                
                }
            }
        });
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
        db.close();

    }

}
