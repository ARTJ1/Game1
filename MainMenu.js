//MainMenu
var startGame = false;
var ExiteGame = false;
var GameOver = false;
var TextGameOver : GameObject;
var PanelRecord  : GameObject;
var ExiteMenu = false;
var Restart = false;

 if (Input.GetKey(KeyCode.Escape))
 {
    Application.Quit();
 }
   
function OnMouseUp() {
    if (startGame == true) {
         Application.LoadLevel(1);
    }


    if (ExiteGame == true) {
        Application.Quit();
    }
    if (GameOver == true)
    {
    TextGameOver.SetActive(!TextGameOver.activeSelf);
    PanelRecord.SetActive(!PanelRecord.activeSelf);    
    }
    if (ExiteMenu == true)
    {
    Application.LoadLevel(0);
    }
    if (Restart == true)
    {
   Application.LoadLevel(1);
    }
}