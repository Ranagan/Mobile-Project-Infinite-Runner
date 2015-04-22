using UnityEngine;
using System.Collections;

public class SpawnObstacles : MonoBehaviour {


	public GameObject obstacle;
	public float spawnMin = 1f;
	public float spawnMax = 2f;

	Vector3 position;

	// Use this for initialization
	void Start () 
	{
		// call the spawn for the first time.
		Spawn ();
	}


	void Spawn () 
	{


		// Spawns a random object we give it, in the position of the spawner with normal rotation.
		Instantiate (obstacle, transform.position, transform.rotation);

		//Makes it coninuously spawn obstacles
		Invoke ("Spawn", Random.Range(spawnMin, spawnMax));
	}
}
