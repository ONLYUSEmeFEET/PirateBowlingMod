using UnityEngine;
using System.Collections;

public class Z_Vertical : MonoBehaviour {

	public Transform aimv;
	public float mult;
	public float limit;
	private float rfix;
	public float clickstep=2;


	// Use this for initialization
	void Start () {

		rfix = transform.localEulerAngles.x;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDrag(){

		if(Input.GetAxis("Mouse Y")> .12f){
			
			//rotate the cannon and gear to the left
			transform.Rotate(-.5f * mult,0,0);
			aimv.Rotate(-.1f * mult,0,0);
			//get current value of Euler Angle Y backwards, so it must be divided by 360
			float radd = transform.localEulerAngles.x;
			Debug.Log (radd);
			//click only on certain intervals
			if(Mathf.Abs(radd-rfix) >= clickstep){
				audio.Play();
				rfix = radd;
			}
			
			
		}
		if(Input.GetAxis("Mouse Y")< -0.12f ){
			
			//rotate the cannon and gear to the right
			transform.Rotate(.5f * mult,0,0);
			aimv.Rotate(.1f * mult,0,0);
			//get the current value of the Euler angle Y
			float radd = transform.localEulerAngles.x;
			//check to see if the angle has passed a value of clickstep.  This makes the audio "click" on a custom interval
			if(Mathf.Abs(radd-rfix) >= clickstep){
				audio.Play();
				rfix = radd;
			}
		}
	}
}
