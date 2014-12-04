 using UnityEngine;
using System.Collections;

public class Z_ShipControl : MonoBehaviour {

	public float fw = 10;
	public Transform shipKeel;
	public float keelValue=50;
	public float zDamper = 10;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ShipControl ();//engages the ship control function
	}


	void ShipControl(){

		transform.Rotate(0,Input.GetAxis("Horizontal")*30/zDamper,0);//rotates ship in the intended direction
		float angle = Mathf.LerpAngle (shipKeel.rotation.z,Input.GetAxis("Horizontal")*30, Time.time);//sets up the Lerp angle for the keel offset
		shipKeel.localEulerAngles = new Vector3 (0, 0, angle);//sets the movement of the ship on the keel to Lerp to the lerp angle
		//shipKeel.Rotate(0,0,Input.GetAxis("Horizontal")/keelValue);//need to create a reverse action to right the ship keel action when the input is not happening.

		if(Input.GetAxis("Vertical") > 0){
			transform.Translate(0,0,-Input.GetAxis ("Vertical")/fw);//moves the ship forward on the local Z axis
		}
	}
}