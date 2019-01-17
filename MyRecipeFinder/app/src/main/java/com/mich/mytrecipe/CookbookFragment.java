package com.mich.mytrecipe;


import android.database.Cursor;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;


public class  CookbookFragment extends Fragment {

    private static final int GALLERY_PICTURE = 1000;
private static final int REQUEST_READ_WRITE_ACCESS = 1;



    EditText recipeId, recipeName, ingredientName, steps;
    Button addRecipe, deleteRecipe, updateRecipe, viewOne;

    DBHelper dbHelper;

    public CookbookFragment() {
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_cookbook, container, false);

        recipeId = (EditText) view.findViewById(R.id.recipe_id);
        recipeName = (EditText) view.findViewById(R.id.recipe_name);
        ingredientName = (EditText)view.findViewById(R.id.ingredients_name);
        steps = (EditText) view.findViewById(R.id.steps);

        dbHelper = new DBHelper(getActivity());

        addRecipe = (Button) view.findViewById(R.id.add);
        addRecipe.setOnClickListener(new View.OnClickListener() {

            public void onClick(View view) {

                dbHelper.open();
                long insert = dbHelper.insertValues(
                        recipeId.getText().toString(),
                        recipeName.getText().toString(),
                        ingredientName.getText().toString(),
                        steps.getText().toString());
                dbHelper.close();
                if (insert > 0) {
                    Toast.makeText(getActivity().getApplicationContext(),
                            "Recipe " + insert + " inserted successfully",
                            Toast.LENGTH_LONG).show();
                } else {
                    Toast.makeText(getActivity().getApplicationContext(),
                            "No records were inserted",
                            Toast.LENGTH_LONG).show();
                }
                recipeId.setText("");
                recipeName.setText("");
                ingredientName.setText("");
                steps.setText("");
            }
        });

        deleteRecipe = (Button) view.findViewById(R.id.delete);
        deleteRecipe.setOnClickListener(new View.OnClickListener() {

            public void onClick(View view) {
                dbHelper.open();
                int delete = dbHelper.deleteValues(recipeId.getText().toString());
                dbHelper.close();

                recipeId.setText("");
                recipeName.setText("");
                ingredientName.setText("");
                steps.setText("");

                if (delete > 0) {
                    Toast.makeText(getActivity().getApplicationContext(),
                            "Recipe " + delete + " deleted successfully",
                            Toast.LENGTH_LONG).show();
                } else {
                    Toast.makeText(getActivity().getApplicationContext(),
                            "No records were deleted",
                            Toast.LENGTH_LONG).show();
                }
            }

        });


        updateRecipe = (Button) view.findViewById(R.id.update);
        updateRecipe.setOnClickListener(new View.OnClickListener() {

            public void onClick(View view) {
                dbHelper.open();

                int update = dbHelper.updateValues(
                        recipeId.getText().toString(),
                        recipeName.getText().toString(),
                        ingredientName.getText().toString(),
                        steps.getText().toString());
                dbHelper.close();

                recipeId.setText("");
                recipeName.setText("");
                ingredientName.setText("");
                steps.setText("");

                if (update > 0) {
                    Toast.makeText(getActivity().getApplicationContext(), "Recipe " + update + " updated successfully",
                            Toast.LENGTH_LONG).show();
                } else {
                    Toast.makeText(getActivity().getApplicationContext(), "No records were updated",
                            Toast.LENGTH_LONG).show();
                }
            }
        });

        viewOne = (Button) view.findViewById(R.id.viewOne);
        viewOne.setOnClickListener(new View.OnClickListener() {

            public void onClick(View view) {
                dbHelper.open();
                Cursor cursor = dbHelper.retrieveValuesOne(recipeId.getText().toString());

                    cursor.moveToFirst();
                    do {
                        String name = cursor.getString(1);
                        String ingredients = cursor.getString(2);
                        String steps1 = cursor.getString(3);

                        recipeName.setText(name);
                        ingredientName.setText(ingredients);
                        steps.setText(steps1);

                } while (cursor.moveToNext()) ;
                cursor.close();
                dbHelper.close();

            }
        });

        return view;
    }
}


