using UnityEngine;
using System.Collections;

public class Z_Cam2ShipConstraint : MonoBehaviour {

	public Transform ship;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3(ship.position.x,transform.position.y,ship.position.z);

	}
}
