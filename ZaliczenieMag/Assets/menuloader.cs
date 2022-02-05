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
        Cursor.lockState = CursorLockMode.None;
    }


    void Update()
    {
        if (Input.GetButton("Cancel"))
        {
            ExitGame();
        }
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
