using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
   public void PlayGame()
   {
       if(SceneManager.GetActiveScene().buildIndex == 2)
       {
           SceneManager.LoadScene(1);
       }
       else
       {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       }
       
   }

   public void QuitGame()
   {
       
       UnityEditor.EditorApplication.isPlaying = false; //Simulates Close in unity system
       Application.Quit();
   }
}
