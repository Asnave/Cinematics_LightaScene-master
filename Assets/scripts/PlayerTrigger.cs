using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayerTrigger : MonoBehaviour
{
    public PlayableDirector timeline;

    public bool OneTimeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        timeline.Play();
        OneTimeTrigger = true;

         if (OneTimeTrigger == true)
         {
             Destroy(this.gameObject);
         }
    }


}
