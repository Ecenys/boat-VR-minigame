using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CageScript : MonoBehaviour
{
	public float limit;
	public float velocity;
	public GameObject point;
	
	private bool caido;
	private float tiempo;
	private Quaternion origin2;
    // Start is called before the first frame update
    void Start()
    {
		origin2 = transform.rotation;
		tiempo = 0;
        caido =  false;
    }

    // Update is called once per frame
    void Update()
    {
		Debug.Log(origin2);
		if (caido)
			tiempo += Time.deltaTime;
		if (tiempo >= limit){
			transform.position = Vector3.MoveTowards(transform.position, point.transform.position, velocity);
			GetComponent<Rigidbody>().isKinematic = true;
			}
		if(transform.position == point.transform.position){
			caido = false;
			tiempo = 0;
			transform.Rotate(Vector3.zero);
		}
        
    }
	
	public void caer(){
		GetComponent<Rigidbody>().isKinematic = false;
		caido = true;
	}
}
