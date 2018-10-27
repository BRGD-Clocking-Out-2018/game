using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liftMove : MonoBehaviour {
	public float speed;
    //public parameters visible in unity
    public bool onElevator;
	public GameObject human;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 up = new Vector3(0,1,0); 
    	float j = 1 * speed * Time.deltaTime; 
    	transform.Translate(up * j, Space.World);
	}


    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Human")
        {
            onElevator = true;
        }
    }
    void OnMouseDown()
	{
		if(speed==0){
			speed =2;
        } /* else {
			speed=0;
		} */
        if (onElevator == true)
        {
            Movement mv = human.GetComponent<Movement>();
            mv.xspeed = 0;
        } 
	}

    
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.name == "floor"){
			speed=0;
			Movement mv = human.GetComponent<Movement>();
			mv.xspeed = 1;
		}
        if(other.gameObject.name == "floor1")
        {
            speed = 0;
        }

	} 


	void OnCollisionExit2D(Collision2D other)
	{
			speed = (float) -2;
		
	}

}
