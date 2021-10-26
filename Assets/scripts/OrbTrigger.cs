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
    public GameObject player;


    private void Start()
    {
        Light1.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("trigger"))
        {
            orb.SetActive(false);
            Debug.Log("is this working?");
            
        }

        if (other.CompareTag("trigger2"))
        {
            orb2.SetActive(false);
            orb3.SetActive(false);
            Light1.SetActive(true);
            Debug.Log("is this working?");

        }
       

    }
    
}
