using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject gun;
    public GameObject crosshair;
    public GameObject mesh;
    public Transform meshT;
    private float rotateFloat = 0f;
    public AudioClip soundB;

    void Start()
    {
        //gun = GameObject.FindWithTag("GunA");
        meshT = mesh.GetComponent<Transform>();
    }

    void Update()
    {

        meshT.rotation = Quaternion.Euler(0, rotateFloat, 0);
        rotateFloat += 30f * Time.deltaTime;

    }
    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(soundB, gameObject.transform.position);
        gun.SetActive(true);
        crosshair.SetActive(true);
        Destroy(gameObject);
    }
}
