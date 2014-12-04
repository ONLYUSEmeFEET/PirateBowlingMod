using UnityEngine;
using System.Collections;

public class Z_Reload : MonoBehaviour {

	public GameObject cannonball;
	public static bool cannonfired = false;
	public static bool cannonground = false;

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(cannonball.transform.position.y <= -3.2f){

			cannonground = true;
		}
	}

	void OnTriggerEnter(Collider thing){

		if (thing.gameObject.tag == "cannonball"){

			cannonfired = true;

		}
	}
}
