using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class menuloader : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void LoadOne()
    {
        SceneManager.LoadScene("Level_one");
    }
    public void LoadTwo()
    {
        SceneManager.LoadScene("Level_two");
    }
    public void ExitGame()
    {
        Application.Quit();
    }

}
