using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColectionableScript : MonoBehaviour
{
	public GameObject teleportpoint;
	private void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.gameObject.tag);
        if(col.gameObject.tag == "Collectable")
        {
			Debug.Log("pene");
            col.gameObject.transform.position = teleportpoint.transform.position;
        }
    }
	void OnCollisionEnter (Collision col)
    {
		Debug.Log(col.gameObject.tag);
        if(col.gameObject.tag == "Collectable")
        {
			Debug.Log("pene");
            col.gameObject.transform.position = teleportpoint.transform.position;
        }
    }
}
