using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class BoatScript : MonoBehaviour
{
    public PropellerBoats boat;
    public GameObject button;

	void Start(){
	}
	
    void Update()
    {
        //Debug.Log(button.GetComponent<LinearMapping>().value);
        if (button.GetComponent<LinearMapping>().value < 0.25f)
            boat.ThrottleUp();
		if (button.GetComponent<LinearMapping>().value <= 0.25f || button.GetComponent<LinearMapping>().value < 0.4f)
            boat.LittleThrottleUp();
        if (button.GetComponent<LinearMapping>().value > 0.75f){
			boat.ThrottleDown();
			boat.Brake();
		}
    }
}
