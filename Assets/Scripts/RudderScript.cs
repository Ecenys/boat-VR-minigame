using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class RudderScript : MonoBehaviour
{
    public PropellerBoats boat;

    // Update is called once per frame
    void Update()
    {
        // if (transform.localEulerAngles.x >= 20 && transform.localEulerAngles.x <=60)
            // boat.RudderRight();
        // if (transform.localEulerAngles.x >= 300 && transform.localEulerAngles.x <= 340)
            // boat.RudderLeft();
		if (GetComponent<LinearMapping>().value <= 0.1f)
			boat.RudderLeft();
		if (GetComponent<LinearMapping>().value > 0.1f && GetComponent<LinearMapping>().value <= 0.3f)
			boat.LessRudderLeft();
		if (GetComponent<LinearMapping>().value < 0.9f && GetComponent<LinearMapping>().value >= 0.7f)
			boat.LessRudderRight();
		if (GetComponent<LinearMapping>().value >= 0.9f)
			boat.RudderRight();
    }
}
