using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{

    [SerializeField] private int soapVelocity;
    public bool isLeftAxis = false;
    
    public void OnSoapEnter(string poisonType)
    {
        if(poisonType == "Soap")
        {
            Vector3 forward = isLeftAxis ? -transform.up : transform.forward;
            
            Debug.Log("Скорость пошла " + soapVelocity);
            gameObject.GetComponent<Rigidbody>().AddRelativeForce(forward * soapVelocity*10.0f);
        }
    }
}
