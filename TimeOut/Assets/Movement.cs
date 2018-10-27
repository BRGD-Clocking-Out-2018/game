using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public float xspeed;
	public float yspeed;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 forward = new Vector3(1,0,0); //assumes increasing the x position moves forward
		Vector3 up = new Vector3(0,1,0);
    	float i = 1 * xspeed * Time.deltaTime; //assumes there's some global float called speed
		float y = 1 * yspeed * Time.deltaTime;
    	transform.Translate(forward * i, Space.World);
		transform.Translate(up*y,Space.World);
	}

	/*
	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.name == "lift"){
			xspeed = 0;
			
		}
	}
    */
}
