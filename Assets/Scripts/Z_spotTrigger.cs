using UnityEngine;
using System.Collections;

public class Z_spotTrigger : MonoBehaviour {

	public float lightIntensity = 1.0f;




	void OnTriggerEnter(Collider thing){//this determines when an object enters into the trigger collider space

		if (thing.gameObject.tag == "Player"){
			print ("trigger entered");
			audio.Play();
			this.light.intensity = lightIntensity;
		}
	}

	void OnTriggerExit(Collider thing){//this determines when an object leave the trigger space

		if (thing.gameObject.tag == "Player"){
			audio.Play();
			this.light.intensity = 0.0f;
		}
		
	}
	void OnTriggerStay(Collider thing){//this will occur while the object is staying in the trigger space

		if (thing.gameObject.tag == "Player"){
			this.light.intensity = Random.Range (0f,1.5f);
		}
	}
}
