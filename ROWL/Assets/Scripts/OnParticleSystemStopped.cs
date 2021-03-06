using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class StoppedScript : MonoBehaviour
{

    void Start()
    {
        var main = GetComponent<ParticleSystem>().main;

        // StopActionはCallbackに設定している必要がある
        main.stopAction = ParticleSystemStopAction.Callback;
    }

    void OnParticleSystemStopped()
    {
        Debug.Log("System has stopped!");
    }

}