using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
    public Transform Cam;

    void Start()
    {
        Cam = gameObject.transform.parent;

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {  
            RaycastHit hit;

            if (Physics.Raycast(Cam.position, Cam.forward, out hit, 500.0f))
            {
            Debug.Log(hit.collider);

                if (hit.transform.tag == "Button")
                {
                hit.transform.gameObject.GetComponent<switcherino>().Hit();
                }
        }}
        //shot.Play(0);
       

    }
}
