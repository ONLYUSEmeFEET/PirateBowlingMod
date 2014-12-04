using UnityEngine;
using System.Collections;

public class Z_CubeMove : MonoBehaviour {

	private bool u;
	private bool j; 
	private float v;
	private float h;
	public float zMultiplier;
	public float yMultiplier;
	private float rollMultiplier;
	public Transform roller;

	// Use this for initialization - never updates or changes
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
		j = Input.GetButtonDown ("Jump");
		u = Input.GetButtonUp ("Jump");
		//fixes the roll to translation ratio
		rollMultiplier = zMultiplier * 22;

		//triggers the Anticipation animation
		if (j) {
			animation.Play("Squash");
		}

		if (u) {
			animation.Play ("Stretch");
			//Add Component -> Audio -> Audio Source
			audio.Play();
		}

		v = Input.GetAxis ("Vertical"); //initialize 'v' value
		h = Input.GetAxis ("Horizontal");
		transform.Translate (0, 0, v * zMultiplier); //always updates and adds the value to the current position
		transform.Rotate (0, h * yMultiplier, 0);
		roller.Rotate (v * rollMultiplier, 0, 0);

	}
}
