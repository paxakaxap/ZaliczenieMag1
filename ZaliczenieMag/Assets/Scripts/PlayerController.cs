using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public float speed;
	public float airSpeed;
	public float sensitivity;
	public GameObject pCamera;
	public float clampAngle;
	public float jumpSpeed;
	public float gravity;
	public float sprint;


	private float WS;
	private float AD;
	private Vector3 moveDirection;
	private float rotY;
	private float rotX;
	private Vector3 veloc;

	public delegate void PrimaryAction();
	public static event PrimaryAction OnPrimaryAction;

	void Start()
	{ 
		

		Vector3 rot = transform.localRotation.eulerAngles;
		Vector3 crot = pCamera.transform.localRotation.eulerAngles;
		rotY = rot.y;
		rotX = crot.x;
	}

	void Update() 
	{
		CharacterController controller = GetComponent<CharacterController> ();
		//Movement---------------------------------------------------------
		float WS = Input.GetAxisRaw("Horizontal");
		float AD = Input.GetAxisRaw("Vertical");
		 
		if (controller.isGrounded)
		{
			moveDirection = new Vector3 (WS, - 0.75f,  AD) * speed;

			moveDirection = transform.TransformDirection (moveDirection);

			if (Input.GetButton ("Jump")) 
			{
				moveDirection.y = jumpSpeed;
			}

			veloc = new Vector3 (WS, moveDirection.y, AD);
///
			if (Input.GetButton ("Fire3")) 
			{
				moveDirection *= sprint;
				veloc.x *= sprint;
				veloc.z *= sprint;
			} 
		}

		else
		{
			moveDirection = new Vector3 (veloc.x * speed + WS * airSpeed, moveDirection.y - gravity * Time.deltaTime, veloc.z * speed + AD * airSpeed);

			moveDirection = transform.TransformDirection (moveDirection);
		}


		if (Input.GetButtonDown("Fire1"))
		{
		if (OnPrimaryAction != null)
			OnPrimaryAction();

		}
		
		//Debug.Log (veloc);
		//Debug.Log (moveDirection);
		controller.Move (moveDirection * Time.deltaTime);

		//Mouse look------------------------------------------------
		float mouseY = Input.GetAxis ("Mouse X");
		float mouseX = Input.GetAxis ("Mouse Y");

		rotX += mouseX * sensitivity; 
		rotY += mouseY * sensitivity;
		rotX = Mathf.Clamp (rotX, -clampAngle, clampAngle);

		Quaternion localRotation = Quaternion.Euler (0.0f, rotY, 0.0f);
		transform.rotation = localRotation;

		Quaternion clocalRotation = Quaternion.Euler (-rotX ,rotY, 0.0f);
		pCamera.transform.rotation = clocalRotation;

	
	

	}
}
