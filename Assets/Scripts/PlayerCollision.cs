using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
	//public Game_Manager gameMng;
	void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstacle")
        {
            //Debug.Log("wtf");
            movement.enabled  = false;
			FindObjectOfType<Game_Manager>().GameOver();
        }
    }
}
