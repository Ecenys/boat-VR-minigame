using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RudderScript : MonoBehaviour
{
    public PropellerBoats boat;

    // Update is called once per frame
    void Update()
    {
        if (transform.localEulerAngles.x >= 20 && transform.localEulerAngles.x <=60)
            boat.RudderRight();
        if (transform.localEulerAngles.x >= 300 && transform.localEulerAngles.x <= 340)
            boat.RudderLeft();
    }
}
