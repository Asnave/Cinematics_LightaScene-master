using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbTrigger : MonoBehaviour
{
    public GameObject orb;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("trigger"))
        {
            orb.SetActive(false);
            Debug.Log("is this working?");
            
        }

        
    }
    
}
