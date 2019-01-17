package com.mich.mytrecipe;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.SQLException;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

public class DBHelper extends SQLiteOpenHelper {
    static final int DATABASE_VERSION = 3;
    static final String DATABASE_NAME = "recipe_manager.db";
    static final String TABLE_NAME = "recipes";
    static final String COLUMN_ID = "_id";
    static final String RECIPE_NAME = "name";
    static final String RECIPE_INGREDIENTS = "ingredients";
    static final String RECIPE_STEPS = "steps";

    SQLiteDatabase database;

    static final String TABLE_CREATE = " create table " + TABLE_NAME +
            "(" + COLUMN_ID + " integer primary key, "
            + RECIPE_NAME+ " text not null, "
            + RECIPE_INGREDIENTS + " text not null, "
            + RECIPE_STEPS + " text not null " + ");";


    public DBHelper(Context context) {
        super(context, DATABASE_NAME, null, DATABASE_VERSION);
    }

    @Override
    public void onCreate(SQLiteDatabase database) {
        database.execSQL(TABLE_CREATE);
    }

    @Override
    public void onUpgrade(SQLiteDatabase database, int oldVersion, int newVersion) {
        database.execSQL("DROP TABLE IF EXISTS " + TABLE_NAME);
        onCreate(database);
    }

    public void open() throws SQLException {
        database = this.getWritableDatabase();
    }

    public void close() {
        database.close();
    }


    public long insertValues(String id, String name, String ingredients,
                             String step) {

        database = this.getWritableDatabase();
        ContentValues contentValues = new ContentValues();
        contentValues.put(COLUMN_ID, id);
        contentValues.put(RECIPE_NAME, name);
        contentValues.put(RECIPE_INGREDIENTS, ingredients);
        contentValues.put(RECIPE_STEPS, step);
        long insert = database.insert(TABLE_NAME, null, contentValues);
        return insert;
    }


    public int updateValues(String id, String name, String ingredients,
                            String step) {
        ContentValues contentValues = new ContentValues();

        contentValues.put(RECIPE_NAME, name);
        contentValues.put(RECIPE_INGREDIENTS, ingredients);
        contentValues.put(RECIPE_STEPS, step);
        int update = database.update(TABLE_NAME, contentValues, COLUMN_ID +
                "=" + id, null);
        return update;
    }


    public int deleteValues(String id) {

     int delete = database.delete(TABLE_NAME, COLUMN_ID + "=" + id, null);
        return delete;
    }

    public Cursor retrieveValuesOne(String id) {
        database = this.getReadableDatabase();

        Cursor cursor = database.rawQuery(" SELECT * FROM " + TABLE_NAME + " WHERE " + COLUMN_ID + " = " + id, null);
        return cursor;
        }


    public Cursor retrieveValuesAll() {

        database = this.getReadableDatabase();

        Cursor cursor = database.rawQuery("SELECT * FROM " + TABLE_NAME, null);
            return cursor;
        }

    }

