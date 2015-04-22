using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour 
{
	public float prevScore;
	public float playerScore;
    public GUIStyle labelStyle;

	void Start()
	{
		// get last highest score from playerprefs  
		prevScore = PlayerPrefs.GetFloat ("highScore");
	}
	
	void Update()
	{
		playerScore += Time.deltaTime;
	}
	
	public void IncreaseScore(int amount)
	{
		playerScore += amount;
	}
	
	void OnGUI ()
	{
		// make the text bigger
		labelStyle.fontSize = 45;
		labelStyle.fontStyle = FontStyle.Bold;
		labelStyle.normal.textColor = Color.black;

		GUI.Label (new Rect (10, 30, 100, 30), "High Score: " + (int)prevScore, labelStyle);

		GUI.Label (new Rect (10, 90, 100, 30), "Score: " + (int)(playerScore), labelStyle);

	}

}