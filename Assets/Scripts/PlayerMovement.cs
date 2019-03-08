using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
	// Use this for initialization
	void Start () {

        //rb.useGravity = false;
        //rb.AddForce(0,200,500);   //throw the object  
    }
	
	// We marked this as "FixedUpdate" because we 
    // are using it to mess with physics.
	void FixedUpdate ()
    {
        //add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);   //  (-left,+right) ,hight, front

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

		if (rb.position.y < -1f)
		{
			FindObjectOfType<Game_Manager>().GameOver();
		}
    }
}
