using UnityEngine;
using System.Collections;

public class MainCharacterController : MonoBehaviour {

	public float maxSpeed = 10f;
	ScoreScript score;
	float currentScore;


	// Use this for initialization
	void Start () 
	{
		score = GameObject.Find ("Main Camera").GetComponent<ScoreScript> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		GetComponent<Rigidbody2D>().velocity = new Vector2(3, (Input.acceleration.y * maxSpeed));

		currentScore = score.playerScore;

		if (currentScore > 50.0) 
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(5, (Input.acceleration.y * maxSpeed));
		}

	}


}
