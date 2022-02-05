using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public float lerper;
    public bool open = false;
    void Start()
    {
        
    }


    void Update()
    {
        if (open == true)
        {
            gameObject.transform.localPosition = Vector3.Lerp(transform.localPosition, new Vector3(transform.localPosition.x, transform.localPosition.y, 2), lerper);
            lerper += 0.01f * Time.deltaTime;
        }
      
    }
    public void OpenDoor()
    {
        open = true;
    }
}
