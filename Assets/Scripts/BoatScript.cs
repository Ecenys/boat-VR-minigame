using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatScript : MonoBehaviour
{
    public PropellerBoats boat;
    public GameObject velocity;

    void Update()
    {
        
        Debug.Log(velocity.transform.localPosition.y);
        if (velocity.transform.localPosition.z >= -0.25f)
            boat.ThrottleUp();
        if (velocity.transform.localPosition.z <= -0.10f)
            boat.ThrottleDown();
    }
}
