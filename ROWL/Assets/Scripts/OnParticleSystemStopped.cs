using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class StoppedScript : MonoBehaviour
{

    void Start()
    {
        var main = GetComponent<ParticleSystem>().main;

        // StopAction‚ÍCallback‚Éİ’è‚µ‚Ä‚¢‚é•K—v‚ª‚ ‚é
        main.stopAction = ParticleSystemStopAction.Callback;
    }

    void OnParticleSystemStopped()
    {
        Debug.Log("System has stopped!");
    }

}