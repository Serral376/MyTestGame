using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class script_buttom : MonoBehaviour
{
    public void Start_game()
    {
        SceneManager.LoadScene(1);
        

        
    }
    public void Exit_game()
    {
        Application.Quit();

    }
}
