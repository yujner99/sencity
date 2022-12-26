using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class Insider : MonoBehaviour
{
    public AudioSource ai_gotobalcony;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            ai_gotobalcony.Play();
            ai_gotobalcony.loop = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "player")
        {
            ai_gotobalcony.Stop();
            ai_gotobalcony.loop = false;
        }
    }
}

