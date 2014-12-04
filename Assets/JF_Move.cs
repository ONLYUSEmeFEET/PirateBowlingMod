using UnityEngine;
using System.Collections;

public class JF_Move : MonoBehaviour {

	private float v;
	private float h;
	public float rotMult = 1;
	public float transMult = 1;
	public float rollMult;
	public Transform roller;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		v = Input.GetAxis ("Vertical");
		h = Input.GetAxis ("Horizontal");

		transform.Translate (0, 0, v * transMult);
		transform.Rotate (0, h * rotMult, 0);
		roller.Rotate (v * rollMult, 0, 0); 
	
	}
}
