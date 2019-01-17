package fonttester;


import java.util.List;
import javafx.application.Application;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.geometry.Insets;
import javafx.geometry.Pos;
import javafx.scene.Scene;
import javafx.scene.control.CheckBox;
import javafx.scene.control.ComboBox;
import javafx.scene.control.Label;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.HBox;
import javafx.scene.layout.Pane;
import javafx.scene.text.Font;
import javafx.scene.text.FontPosture;
import javafx.scene.text.FontWeight;
import javafx.stage.Stage;

public class FontTester extends Application{
  
private Label programingLabel = new Label("Programming is fun");

CheckBox chkBold = new CheckBox("Bold");
CheckBox chkItalic = new CheckBox("Italic");
ObservableList<String>  fontNameOptions = FXCollections.observableArrayList();
final List<String> fontName = javafx.scene.text.Font.getFamilies();
final ComboBox<String> cmbFontName = new ComboBox<> (fontNameOptions);
ObservableList<String>  fontSizeOptions = FXCollections.observableArrayList("8", "12", "16", "24", "30", "36", "42", "48", "56"); 
final ComboBox<String> cmbFontSize = new ComboBox<>(fontSizeOptions);

   
    
    @Override
    public void start(Stage stage){
        BorderPane pane;
        pane = new BorderPane();
      
        Pane paneForText = new Pane();
    
        paneForText.getChildren().add(programingLabel);
       
        pane.setCenter(paneForText);
        
        Scene scene;
        scene = new Scene(pane, 650, 200);
        
        stage.setTitle("Font Tester"); // Set the stage title
        stage.setScene(scene); // Place the scene in the stage
        stage.show(); // Display the stage
    
        cmbFontSize.setValue("12");
        
        for (int i = 0; i < (Math.min(fontName.size(), 10)); i++) {
			fontNameOptions.add(fontName.get(i));
		}
                
        HBox comboHBox = new HBox();
        comboHBox.setAlignment(Pos.CENTER);
        comboHBox.setPadding(new Insets(15, 15, 15, 15));
        comboHBox.setSpacing(20);
        comboHBox.getChildren().addAll(new Label("Font Name"), cmbFontName, new Label("Font Size"), cmbFontSize);
        pane.setTop(comboHBox);
        
        HBox checkHBox = new HBox();
        checkHBox.setAlignment(Pos.CENTER);
        checkHBox.setPadding(new Insets(20, 20, 20, 20));
        checkHBox.setSpacing(20);
        checkHBox.getChildren().addAll(chkBold, chkItalic);
        pane.setBottom(checkHBox);
        
        cmbFontName.setValue(fontNameOptions.get(4));
        
        
        //Sets action event for font choices
        cmbFontName.setOnAction(e -> {
            setTextFontSize();
        });
        
        cmbFontSize.setOnAction(e -> {
            setTextFontSize();
        });

        chkBold.setOnAction(e -> {
            setTextFontSize();
        });

        chkItalic.setOnAction(e -> {
            setTextFontSize();
        });
    } 
     
    private void setTextFontSize(){
    
    FontWeight fontWeight;
    FontPosture fontPosture;
       
       if (chkBold.isSelected())  {
            fontWeight = FontWeight.BOLD;
       } else {
            fontWeight = FontWeight.NORMAL;
        }
        if (chkItalic.isSelected()) {
            fontPosture = FontPosture.ITALIC;
        } else {
            fontPosture = FontPosture.REGULAR;
        }
        programingLabel.setFont(Font.font(cmbFontName.getValue(), fontWeight, fontPosture, Double.parseDouble(cmbFontSize.getValue())));
    }         
        
   public static void main(String[] args) {
        Application.launch(args);
    }
}      
       
    

    
    
    

    
