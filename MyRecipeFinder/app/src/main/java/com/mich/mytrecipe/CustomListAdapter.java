package com.mich.mytrecipe;


import android.content.Context;
import android.database.Cursor;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.SimpleCursorAdapter;
import android.widget.TextView;

public class CustomListAdapter extends SimpleCursorAdapter {
    public CustomListAdapter(Context context,int layout, Cursor c, String [] from, int [] to, int flags) {
        super(context, layout, c, from, to, flags);
    }

    @Override
    public View newView(Context context, Cursor cursor, ViewGroup viewGroup)
    {
        return LayoutInflater.from(context).inflate(R.layout.custom_listview_row, viewGroup, false);
    }

    @Override
    public void bindView(View view, Context context, Cursor cursor) {
        TextView recipeId = (TextView) view.findViewById(R.id.recipe_id);
        TextView recipeName = (TextView) view.findViewById(R.id.recipe_name);
        TextView recipeIngredients = (TextView) view.findViewById(R.id.recipe_ingredients);
        TextView recipeDetails = (TextView) view.findViewById(R.id.recipe_details);

        String stringRecipeId = cursor.getString(cursor.getColumnIndexOrThrow(DBHelper.COLUMN_ID));
        String stringRecipeName = cursor.getString(cursor.getColumnIndexOrThrow(DBHelper.RECIPE_NAME));
        String stringRecipeIngredients = cursor.getString(cursor.getColumnIndexOrThrow(DBHelper.RECIPE_INGREDIENTS));
        String stringRecipeDetails = cursor.getString(cursor.getColumnIndexOrThrow(DBHelper.RECIPE_STEPS));

        recipeId.setText(stringRecipeId);
        recipeName.setText(stringRecipeName);
        recipeIngredients.setText(stringRecipeIngredients);
        recipeDetails.setText(stringRecipeDetails);
    }

}
