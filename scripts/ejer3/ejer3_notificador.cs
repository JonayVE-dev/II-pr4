using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notificador3 : MonoBehaviour
{
    public delegate void GetCloseToCylinder();
    public event GetCloseToCylinder onGetCloseToCylinder;
    GameObject cylinder;
    float originalDistance;
    float umbral = 0.05f;
    void Start()
    {
        cylinder = GameObject.Find("red_cylinder");
        originalDistance = Vector3.Distance(transform.position, cylinder.transform.position);
    }

    void Update()
    {
        float actualDistance = Vector3.Distance(transform.position, cylinder.transform.position);

        if (originalDistance - actualDistance > umbral)
        {
            if (onGetCloseToCylinder != null) 
            {
                onGetCloseToCylinder();
            }
        }
        originalDistance = actualDistance;

    }
}
