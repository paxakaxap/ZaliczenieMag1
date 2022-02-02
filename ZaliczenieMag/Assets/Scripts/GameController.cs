using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
		Application.targetFrameRate = TargetFPS;
	}
	
}
