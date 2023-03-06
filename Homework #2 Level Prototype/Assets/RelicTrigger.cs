using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class RelicTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject Relic1;
    [SerializeField] CinemachineVirtualCamera SpecialCam;
    bool islifted = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entercollision");
        if (!islifted)
        {
            islifted = true;
            Relic1.transform.position += new Vector3(0, -12, 0);
            SpecialCam.m_Priority = 11;
        }
            
        else if (islifted)
        {
            islifted = false;
            Relic1.transform.position += new Vector3(0, 12, 0);
            SpecialCam.m_Priority = 9;
        }
    }
}
