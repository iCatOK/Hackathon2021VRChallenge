using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{

    [SerializeField] private int soapVelocity;
    
    public void OnSoapEnter(string poisonType)
    {
        if(poisonType == "Soap")
        {
            Debug.Log("Скорость пошла " + soapVelocity);
            gameObject.GetComponent<Rigidbody>().AddRelativeForce(transform.forward * soapVelocity*10.0f);
        }
    }
}
