using UnityEngine;
using System.Collections;

public class Z_Splash : MonoBehaviour {

	private GameObject splashobj;//this will be our instatiated object.

	// Use this for initialization
	void Start () {

		splashobj = Resources.Load<GameObject> ("Splash_OBJ");//prefab with audio node attached

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision thing){

		//1:  Determine the position where the collision occurred
		//2:  Destroy the object that collided
		//2:  Instantiate an Object with audio where the collision occurred
		//3:  Play the audio of the instantiated object
		//4:  After the audio is done playing, destroy the instantiated object 

	}
}
