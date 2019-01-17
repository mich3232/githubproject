package Android.CompetencyCheckpoint4_Task1;
 
import android.content.ContentValues;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.database.SQLException;
import android.content.Context;
import android.database.Cursor;

/**
 *
 * @author Michelle
 */
public class DBaseHelper extends SQLiteOpenHelper {

    static final int DATABASE_VERSION = 2;
    static final String DATABASE_NAME = "Travel_Itinerary";
    static final String TABLE_NAME = "Itinerary";
    static final String TABLE_KEY = "id";
    static final String PLACE_NAME = "pName";
    static final String COUNTRY_NAME = "countryName";
    static final String TRAVEL_YEAR = "travelYear";
     
    SQLiteDatabase db;
    
    static final String TABLE_CREATE = " create table " + TABLE_NAME + "(" + TABLE_KEY + " integer primary key, " + PLACE_NAME + " text not null, " + COUNTRY_NAME + " text not null, " + TRAVEL_YEAR + " text not null " + ");";

public DBaseHelper(Context c)
{
    super(c, DATABASE_NAME, null, DATABASE_VERSION);
      
}    

@Override
 public void onCreate(SQLiteDatabase db)
 {
     db.execSQL(TABLE_CREATE);
 }
    
@Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("Drop table if exists itinerary");
        onCreate(db);
    }
//create or open existing db

    public void open() throws SQLException {
        db = this.getWritableDatabase();
    }
//close db

    public void close() {
        db.close();
    }
    //insert values
public long insertValues(String id, String pname, String country, String travelyear)
{
        db = this.getWritableDatabase();
        ContentValues value = new ContentValues();
        value.put(TABLE_KEY, id);
        value.put(PLACE_NAME, pname);
        value.put(COUNTRY_NAME, country);
        value.put(TRAVEL_YEAR, travelyear);
        long in = db.insert(TABLE_NAME, null, value);
        return in;
    }
public int deleteValues(String id)
    {
        int value = db.delete(TABLE_NAME, TABLE_KEY + "=" + id, null);
        return value;
    }
//update values
public int updateValues(String id, String pname, String country, String year) {
        ContentValues value = new ContentValues();
        value.put(PLACE_NAME, pname);
        value.put(PLACE_NAME, country);
        value.put(TRAVEL_YEAR, year);
        int upValue = db.update(TABLE_NAME, value, TABLE_KEY + "=" + id,
                null);
        return upValue;
    }
//retrieve from database
public Cursor retrieveValues(String id) {
   
        Cursor c = db.rawQuery(" SELECT * FROM " + TABLE_NAME + " WHERE " + TABLE_KEY + " = " + id, null);
            
            return c;
            }
                
        
    }


