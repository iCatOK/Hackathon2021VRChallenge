using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Balloon : MonoBehaviour
{
    public int timeUntilExplode = 5;
    public ParticleSystem particles;
    //public UnityEvent OnBalloonExplode;

    private void Awake()
    {
        particles.gameObject.SetActive(false);
    }

    internal void OnLaserStart()
    {
        Invoke("Explode", timeUntilExplode);
    }

    internal void OnLaserEnd()
    {
        CancelInvoke("Explode");
    }

    void Explode()
    {
        Debug.LogError("<<<<EXPLODE>>>>>>");
        gameObject.SetActive(false);
        particles.gameObject.SetActive(true);
        particles.Play();
        
    }
}
