using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class StoppedScript : MonoBehaviour
{

    void Start()
    {
        var main = GetComponent<ParticleSystem>().main;

        // StopAction��Callback�ɐݒ肵�Ă���K�v������
        main.stopAction = ParticleSystemStopAction.Callback;
    }

    void OnParticleSystemStopped()
    {
        Debug.Log("System has stopped!");
    }

}