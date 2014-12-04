using UnityEngine;
using System.Collections;

public class Z_DetectCollision : MonoBehaviour {

	public GameObject hitIndicator;
	public float hitStrength = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision thing){

		Debug.Log (thing.gameObject.name);//this is the name of any object that contacts the object collided with
		Debug.Log (thing.relativeVelocity.magnitude);//this is the float value of how "hard" the contact was
		Debug.Log (thing.contacts [0].point);//this is the first point of contact in 3D space

		//create an object at the point of contact, just like we would indicate an explosion
		Vector3 hitPoint = thing.contacts [0].point;//this is a variable to store the 3D position of the point where the collision occurred
		Instantiate (hitIndicator, hitPoint, Quaternion.identity);//this creates a game object where the hit occurred
		audio.Play ();//played attached audio
	}
}
