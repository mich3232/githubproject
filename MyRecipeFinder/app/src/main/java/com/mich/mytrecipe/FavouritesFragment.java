package com.mich.mytrecipe;

import android.database.Cursor;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.ListAdapter;
import android.widget.ListView;

public class FavouritesFragment extends Fragment {

    DBHelper dbHelper;
    ListView recipeDisplayer;
    ListAdapter simpleCursorAdapter;

    Button viewAll;

    public FavouritesFragment() {
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {

        View view = inflater.inflate(R.layout.fragment_favourites, container, false);
        recipeDisplayer = (ListView) view.findViewById(R.id.custom_listview);

        dbHelper = new DBHelper(getActivity());

        viewAll = (Button) view.findViewById(R.id.viewAll);
        viewAll.setOnClickListener(new View.OnClickListener() {

            @Override
            public void onClick(View view) {
                dbHelper.open();
                displayRecipeList();
                dbHelper.close();
            }
        });
        return view;

    }

    public void displayRecipeList(){
        Cursor cursor = dbHelper.retrieveValuesAll();
        if(cursor.getCount()== 0){
            return;

        }

        String [] columns = new String[]
                {DBHelper.COLUMN_ID,
                 DBHelper.RECIPE_NAME,
                 DBHelper.RECIPE_INGREDIENTS,
                 DBHelper.RECIPE_STEPS};

        int[] boundTo = new int[]{R.id.recipe_id,
                R.id.recipe_name,
                R.id.ingredients_name,
                R.id.recipe_details};

        simpleCursorAdapter = new CustomListAdapter(getActivity(),
                R.layout.custom_listview_row,
                cursor,
                columns,
                boundTo,
                0);
        recipeDisplayer.setAdapter(simpleCursorAdapter);
        }
    }



