using UnityEngine;
using System.Collections;

public class KillScript : MonoBehaviour 
{
	ScoreScript score;
	float scoreOnDeath;
	float highScore;

	void Start()
	{
		score = GameObject.Find ("Main Camera").GetComponent<ScoreScript> ();
		highScore = PlayerPrefs.GetFloat ("highScore");
	}

	void Update()
	{
		scoreOnDeath = score.playerScore;

	}

	void OnTriggerEnter2D(Collider2D other)
	{

		
		if (other.tag == "Player")
		{
			PlayerPrefs.SetFloat("deathScore", scoreOnDeath);

			if(scoreOnDeath > highScore)
			{
				highScore = scoreOnDeath;
				PlayerPrefs.SetFloat("highScore", highScore);
			}

			// Go to death scene
			Application.LoadLevel("DeathScene");
		}

	}
}
