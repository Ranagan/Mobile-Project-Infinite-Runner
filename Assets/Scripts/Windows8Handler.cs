using UnityEngine;
using System.Collections;

public class Windows8Handler : MonoBehaviour {

	public static void PauseGame(bool p)
	{
		// pauses the game when in snap view
		if (p)
		{
			Time.timeScale = 0.0f;
		}
		else Time.timeScale = 1.0f;
	}
}
