using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Balloon : MonoBehaviour
{
    public int m_Score = 5;

    internal void OnLaserStart()
    {
        Invoke("Explode", 2);
    }

    internal void OnLaserEnd()
    {
        CancelInvoke("Explode");

    }

    void Explode()
    {
        gameObject.SetActive(false);
    }
}
