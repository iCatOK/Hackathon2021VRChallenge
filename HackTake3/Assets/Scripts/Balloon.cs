using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Balloon : MonoBehaviour
{
    public int timeUntilExplode = 5;
    ParticleSystem m_ParticlesWhenExplode;
    private void Start()
    {
        m_ParticlesWhenExplode = GetComponent<ParticleSystem>();
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
        Debug.Log("Партиклы");
        if (m_ParticlesWhenExplode != null)
        {
            Debug.LogError("<<<<EXPLODE>>>>>>");
            
            m_ParticlesWhenExplode.Play();
        }
            
        gameObject.SetActive(false);
    }
}
