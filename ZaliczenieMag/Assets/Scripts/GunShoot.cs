using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
    public Transform Cam;
    public ParticleSystem flarea;
    public AudioSource zap;
    void Start()
    {
        Cam = gameObject.transform.parent;

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            PifPaf();
           
        
        }
        //shot.Play(0);
       

    }
    void PifPaf()
    { 
        flarea.Play();
        RaycastHit hit;

        zap.Play();

        if (Physics.Raycast(Cam.position, Cam.forward, out hit, 500.0f))
        {
            Debug.Log(hit.collider);

            if (hit.transform.tag == "Button")
            {
                hit.transform.gameObject.GetComponent<switcherino>().Hit();
            }
        }
    }
}
