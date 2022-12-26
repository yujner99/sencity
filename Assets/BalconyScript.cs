using BNG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class BalconyScript : MonoBehaviour
{
    public Grabbable KnobToDisable;
    public PlayableDirector AfterBalconyIncidentTimeline;

    private void OnTriggerEnter(Collider other)
    {
        Head trackedDevice = other.GetComponent<Head>();
        
        if (trackedDevice)
        {
            KnobToDisable.enabled = false;
            if (AfterBalconyIncidentTimeline)
            {
                AfterBalconyIncidentTimeline.Play();
            }

        }
    }
}
