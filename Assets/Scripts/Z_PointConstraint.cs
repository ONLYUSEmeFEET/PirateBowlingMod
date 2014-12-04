using UnityEngine;
using System.Collections;

public class Z_PointConstraint : MonoBehaviour {

	public bool x = false;
	public bool y = false;
	public bool z = false;
	public Transform target;
	private float tx;
	private float ty;
	private float tz;

	// Use this for initialization
	void Start () {

		tx = transform.position.x;
		ty = transform.position.y;
		tz = transform.position.z;

		Debug.Log (transform.position);
		Debug.Log (transform.localPosition);
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3(transform.position.x,target.position.y,transform.position.z);


	}
}