using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class loader : MonoBehaviour
{
    public string NextLevel;
    //public Scene nextlevel;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            Debug.Log("Loading " + NextLevel);
            SceneManager.LoadScene(NextLevel);
        }
    }
}
