using UnityEngine;
using System.Collections;

public class Z_Horizontal : MonoBehaviour {

	public Transform aimh;
	public float mult;
	public int ylimit=90;
	private float rfix;
	public float clickstep=2;

	// Use this for initialization
	void Start () {

		 rfix = transform.localEulerAngles.y;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDrag(){

		if(Input.GetAxis("Mouse X")> .12f){

			//rotate the cannon and gear to the left
			transform.Rotate(0,-.5f * mult,0);
			aimh.Rotate(0,-.1f * mult,0);
			//get current value of Euler Angle Y backwards, so it must be divided by 360
			float radd = transform.localEulerAngles.y;
			Debug.Log (radd);
			//click only on certain intervals
			if(Mathf.Abs(radd-rfix) >= clickstep){
				audio.Play();
				rfix = radd;
			}


		}
		if(Input.GetAxis("Mouse X")< -0.12f ){

			//rotate the cannon and gear to the right
			transform.Rotate(0,.5f * mult,0);
			aimh.Rotate(0,.1f * mult,0);
			//get the current value of the Euler angle Y
			float radd = transform.localEulerAngles.y;
			//check to see if the angle has passed a value of clickstep.  This makes the audio "click" on a custom interval
			if(Mathf.Abs(radd-rfix) >= clickstep){
				audio.Play();
				rfix = radd;
			}
		}
	}
}