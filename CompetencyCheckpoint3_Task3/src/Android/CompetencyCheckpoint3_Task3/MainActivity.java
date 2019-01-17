package Android.CompetencyCheckpoint3_Task3;

import android.app.Activity;

import android.os.Bundle;
import android.content.Intent;
import android.graphics.Bitmap;

import android.net.Uri;
import android.os.Environment;
import android.widget.ImageView;
import android.provider.MediaStore;

import android.view.View;

import android.widget.Button;
import java.io.File;

import java.io.IOException;


public class MainActivity extends Activity {

    ImageView image;
    Button capture;
    Button save;
    Intent intent;
    
    String path;
    Bitmap bmap;
    private static final int RQUEST_CODE = 200;
    int code = 200;
    File dir;
    File file;
    File album;
    File imageFile;
    
    /**
     * Called when the activity is first created.
     */
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);

        image = (ImageView) findViewById(R.id.imgeview);
        capture = (Button) findViewById(R.id.btnTakePic);
        save = (Button) findViewById(R.id.btnSavePic);
        
    }

    public void capturePic(View view) {

        intent = new Intent(MediaStore.ACTION_IMAGE_CAPTURE);
        file = null;
        try {
            file = createFile();
            intent.putExtra(MediaStore.EXTRA_OUTPUT,
                    Uri.fromFile(file));
            path = imageFile.getAbsolutePath();
        
        } catch (IOException e) {
            e.printStackTrace();
        }
    startActivityForResult(intent, RQUEST_CODE);
    }

   
    public void savePic(View view) {
        Intent media = new Intent(Intent.ACTION_MEDIA_SCANNER_SCAN_FILE);
        File file = new File(path);
        Uri u = Uri.fromFile(file);
        media.setData(u);
        this.sendBroadcast(media); 
    }
      
    

    protected void onActivityResult(int requestCode ,int resultCode, Intent data) {

        if (requestCode == RQUEST_CODE) {
           image.setImageURI(Uri.parse(path));
        }
    }

    private File createFile() throws IOException {
        String name = "Img";
        album = getAlbumName();
        imageFile = File.createTempFile(name, ".jpeg",
                album);
       return imageFile;
    }

    private File getAlbumName() {
        dir = new File(Environment.getExternalStoragePublicDirectory(Environment.DIRECTORY_PICTURES),
                "CameraAppPhotos");
        if (!dir.exists()) {
            dir.mkdirs();
        }
        return dir;
    }
}
