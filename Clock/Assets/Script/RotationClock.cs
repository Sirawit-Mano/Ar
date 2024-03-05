using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationClock : MonoBehaviour
{
    // Start is called before the first frame update
    public SpawnInArea area;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 10f *Time.deltaTime, 0f, Space.Self);




        /*timer += Time.deltaTime;

        if (timer >= 0.05f)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 0.05f);
            timer
        }
        else
        {
            transform.Translate(Vector3.up * Time.deltaTime * 0.05f);
            timer += Time.deltaTime;
        }*/


    }

}
