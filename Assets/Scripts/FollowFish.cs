using UnityEngine;
using System.Collections;

public class FollowFish : MonoBehaviour {

	public Transform player; // Reference to the player's transform.

	
	// Update is called once per frame
	void Update () 
	{
		transform.position = new Vector3(player.position.x + 6, 0, -10);
	}
}
