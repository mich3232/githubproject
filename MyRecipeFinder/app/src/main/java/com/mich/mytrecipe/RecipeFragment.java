package com.mich.mytrecipe;


import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.KeyEvent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.webkit.WebSettings;
import android.webkit.WebView;
import android.webkit.WebViewClient;
import android.widget.Button;

public class RecipeFragment extends Fragment {

    WebView recipes;
    Button refresh;
    private Bundle webViewBundle;

    public RecipeFragment() {

    }

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        webViewBundle = new Bundle();
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_recipe, container, false);



        recipes = (WebView) view.findViewById(R.id.webView);
        if (recipes != null) {
            recipes.setWebViewClient(new WebViewClient());

            if (webViewBundle == null || webViewBundle.isEmpty()) {
                recipes.loadUrl("http://food2fork.com");
            } else {
                recipes.restoreState(webViewBundle);
                webViewBundle.clear();
            }
        }

        WebSettings webSettings = recipes.getSettings();
        webSettings.setJavaScriptEnabled(true);


        refresh = (Button) view.findViewById(R.id.btnRefresh);
        refresh.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                recipes.reload();
            }
        });

       recipes.setOnKeyListener(new View.OnKeyListener() {
            @Override
            public boolean onKey(View v, int keyCode, KeyEvent event) {
                if (event.getAction() == KeyEvent.ACTION_DOWN) {
                    if ((keyCode == KeyEvent.KEYCODE_BACK)) {
                        if(recipes!=null)
                        {
                            if(recipes.canGoBack())
                            {
                                recipes.goBack();
                            }
                        }
                    }
                }
                return true;
            }
        });
        return view;
    }



}






