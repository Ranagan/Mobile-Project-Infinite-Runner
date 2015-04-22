using UnityEngine;
using System.Collections;

public class DeathScene : MonoBehaviour {

	float score = 0;
	float highscore;
	public GUIStyle labelStyle;

	
	// Use this for initialization
	void Start () 
	{
		score = PlayerPrefs.GetFloat ("deathScore");
		highscore = PlayerPrefs.GetFloat ("highScore");
	
	}
	
	
	void OnGUI()
	{

		// make the text bigger
		labelStyle.fontSize = 45;
		labelStyle.fontStyle = FontStyle.Bold;
		labelStyle.normal.textColor = Color.black;


		GUI.Label (new Rect (Screen.width / 2 - 200, Screen.height/2 - 300, 80, 30), "GAME OVER", labelStyle);
		
		GUI.Label (new Rect(Screen.width / 2 - 200, Screen.height/2 - 200, 80, 40), "Your Score Was: " + (int)(score), labelStyle);

		GUI.Label (new Rect(Screen.width / 2 - 200, Screen.height/2 - 100, 80, 40), "Your HighScore: " + (int)(highscore), labelStyle);

		if (GUI.Button (new Rect (Screen.width / 2 - 200, Screen.height/2, 160, 30), "Retry?"))
		{
			Application.LoadLevel(1);
		}

		if (GUI.Button (new Rect (Screen.width / 2 + 50, Screen.height/2, 160, 30), "Main Menu"))
		{
			Application.LoadLevel(0);
		}
	}
}
