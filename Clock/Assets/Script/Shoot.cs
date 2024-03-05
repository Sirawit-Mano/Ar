using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject arCamera;
    public GameObject explode;

    public void ShootIt()
    {
        RaycastHit hit;

        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if (hit.transform.tag == "AlarmClock")
            {
                Destroy(hit.transform.gameObject);
                Instantiate(explode, hit.point, Quaternion.LookRotation(hit.normal));
                
            }
        }

    }
}
