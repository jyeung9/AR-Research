using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private float time = 0.0f;
    public float waitTime;  // length of pause

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        GameObject aiCar = GameObject.FindWithTag("car");
        var go = aiCar.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>();
        go.m_Topspeed = (float)0.0;
        //print(time);
    }

    private void OnTriggerStay(Collider other)
    {
        time = time + Time.deltaTime;

        if(time >= 5)
        {
            GameObject aiCar = GameObject.FindWithTag("car");
            var go = aiCar.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>();
            go.m_Topspeed = (float) 25.0;
        }
    }
}
