using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour {

	public bool MouseLock;
	public int TargetFPS = 60;


	void Start () 
	{
		if (MouseLock == true)
		{
			Cursor.lockState = CursorLockMode.Locked;
		} else
		{
			Cursor.lockState = CursorLockMode.None;
		}
			
	}
	void Update()
	{
        if(Input.GetButtonDown("Cancel"))
		{
			SceneManager.LoadScene("Menu");
		}
		Application.targetFrameRate = TargetFPS;
	}
	
}
