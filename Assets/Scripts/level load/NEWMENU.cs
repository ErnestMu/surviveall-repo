using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NEWMENU : MonoBehaviour
{
  
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);// this can load the scene number 1 (game)//SceneManager.GetActiveScene().buildIndex +1

    }

}