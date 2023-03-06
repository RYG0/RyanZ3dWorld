using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public GameObject Light;
    void Start()
    {
        Light.GetComponent<Light>().enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        Light.GetComponent<Light>().enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Light.GetComponent<Light>().enabled = false;
    }
}
