using UnityEngine;
using System.Collections;

public class x_spotTrigger : MonoBehaviour {

	public float lightIntensity = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider thing){

		if(thing.gameObject.tag == "Player")

			this.light.intensity = lightIntensity;
		audio.Play ();

	}
}
