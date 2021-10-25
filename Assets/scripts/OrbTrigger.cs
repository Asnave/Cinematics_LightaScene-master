using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbTrigger : MonoBehaviour
{
    public GameObject orb;
    public GameObject player;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "trigger")
        {
            orb.SetActive(false);
            Debug.Log("is this working?");
            
        }

        
    }
    
}
