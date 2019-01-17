package com.mich.mytrecipe;

import android.support.v4.app.Fragment;
import android.support.v4.app.FragmentManager;
import android.support.v4.app.FragmentPagerAdapter;


public class TabPagerAdapter extends FragmentPagerAdapter {

    int tabCount;

    public TabPagerAdapter(FragmentManager fm, int numberOfTabs) {
        super(fm);
        this.tabCount = numberOfTabs;
    }

    @Override
    public Fragment getItem(int position) {
        switch (position) {
            case 0:
                RecipeFragment recipeFragment = new RecipeFragment();
                return recipeFragment;
            case 1:
                FavouritesFragment favouriteFragment = new FavouritesFragment();
                return favouriteFragment;
            case 2:
                CookbookFragment cookbookFragment = new CookbookFragment();
                return cookbookFragment;
            default:
                return null;
        }
    }


    @Override
    public int getCount() {
        return tabCount;
    }
}
