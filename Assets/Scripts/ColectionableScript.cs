using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColectionableScript : MonoBehaviour
{
	public GameObject teleportpoint;
	void OnCollisionEnter (Collision col)
    {
		Debug.Log(col.gameObject.tag);
        if(col.gameObject.tag == "Collectable")
        {
            col.gameObject.transform.position = teleportpoint.transform.position;
        }
    }
}
