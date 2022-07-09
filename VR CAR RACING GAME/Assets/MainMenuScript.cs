using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
   public void playTheGame(){
    SceneManager.LoadScene("Game");
   } 
   public void quitTheGame(){
    Debug.Log("QUIT THE GAME");
    Application.Quit();
   }
}
