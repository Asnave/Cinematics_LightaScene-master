using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbTrigger : MonoBehaviour
{
    public GameObject orb;
    public GameObject orb2;
    public GameObject orb3;
    public GameObject orb4;
    public GameObject Light1;
    public GameObject Light2;
    public GameObject player;
    public AudioSource soundToPlay;
    public bool OneTimeTrigger = false;

    private void Start()
    {
        Light1.SetActive(false);
        Light2.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("trigger"))
        {
            orb.SetActive(false);
            Light2.SetActive(true);
            Debug.Log("is this working?");
          

        }

        if (other.CompareTag("trigger2"))
        {
            orb2.SetActive(false);
            orb3.SetActive(false);
            Light1.SetActive(true);
            soundToPlay.Play();
            Debug.Log("is this working?");
           

        }
       

    }
    
}
