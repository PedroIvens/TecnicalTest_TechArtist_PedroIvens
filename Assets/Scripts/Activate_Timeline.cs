using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class Activate_TL : MonoBehaviour
{
    public PlayableDirector directorTL;

    public void ActivateTL()
        {
        directorTL.Play();
        Debug.Log("Timeline_Activated!");
        }
}
