using UnityEngine;
using System.Collections;

public class Z_ExplosiveForce : MonoBehaviour {

	public Rigidbody[] pins;
	public Vector3 center;
	public float frce;
	public float radius;
	public float up;

	// Use this for initialization
	void Start () {

		pins = GameObject.Find ("BowlingPins").GetComponentsInChildren<Rigidbody> ();
		center = gameObject.transform.position;

	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown ("space")){
			foreach(Rigidbody pin in pins){
				print ("pin");
				pin.AddExplosionForce(frce,center,radius,up);
			}
		}
	}

	void OnMouseDown(){

		foreach(Rigidbody pin in pins){
			print ("pin");
			pin.AddExplosionForce(frce,center,radius,up);
		}

	}
}
