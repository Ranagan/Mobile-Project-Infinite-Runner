using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public void LoadOnClick(int level)
	{
		Application.LoadLevel (level);



	}

	public void QuitGame()
	{
		Application.Quit ();
	}
}
