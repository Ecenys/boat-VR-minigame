using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColectionableScript : MonoBehaviour
{
	public GameObject teleportpoint;
	void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.tag == "collectable")
        {
            col.gameObject.transform.position = teleportpoint.transform.position;
        }
    }
}
