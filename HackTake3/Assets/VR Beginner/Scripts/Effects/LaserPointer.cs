using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace VRBeginer
{
    public class LaserPointer : MonoBehaviour
    {
        LineRenderer m_LineRenderer;
        
        Balloon lastBalloon;
        
        void Start()
        {
            m_LineRenderer = GetComponent<LineRenderer>();
        }

        void Update()
        {
            RaycastHit info;
            if (Physics.Raycast(transform.position, transform.up, out info, 100.0f, 7, QueryTriggerInteraction.Ignore))
            {
                Balloon newBalloon = info.collider.gameObject.GetComponent<Balloon>();

                if (newBalloon != null)
                {
                    if (newBalloon != lastBalloon)
                    {
                        if (lastBalloon != null)
                            lastBalloon.OnLaserEnd();
                        lastBalloon = newBalloon;
                    }

                    lastBalloon.OnLaserStart();
                }
                else
                {
                    if (lastBalloon != null)
                        lastBalloon.OnLaserEnd();
                }

                m_LineRenderer.SetPosition(1, new Vector3(0, info.distance, 0));
            }
            else
            {
                m_LineRenderer.SetPosition(1, new Vector3(0, 100.0f, 0));
                if (lastBalloon != null)
                {
                    lastBalloon.OnLaserEnd();
                    lastBalloon = null;
                }
            }
        }

        public void UntoggleLaser()
        {
            if (lastBalloon != null)
            {
                lastBalloon.OnLaserEnd();
            }
        }
    }
}

