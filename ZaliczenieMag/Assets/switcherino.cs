using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switcherino : MonoBehaviour
{
    public bool On = false;
    public GameObject doors;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void Hit() 
    {
        On = true;

        doors.transform.GetComponent<door>().OpenDoor();

        gameObject.transform.GetComponent<Renderer>().material.SetColor("_EmissiveColor", Color.green * 50f);
        

    }
}
