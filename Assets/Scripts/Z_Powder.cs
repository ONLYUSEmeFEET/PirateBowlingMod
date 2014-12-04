using UnityEngine;
using System.Collections;

public class Z_Powder : MonoBehaviour {

	//new variable for Z_CannonFire script
	public Z_CannonFire zc;
	//new variable for gameobject with Z_CannonFireScript
	private GameObject trigger;
	//variable to tweak the amount of powder or explosion force
	public float zforcemult=17;
	// Use this for initialization
	void Start () {

		//load script instance here
		trigger = GameObject.Find ("FireButton");
		zc = trigger.GetComponent<Z_CannonFire> ();
		zc.zforce = transform.localPosition.y * zforcemult;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDrag(){

		//set value of zforce to reflect the value of the slider transform.position.y
		zc.zforce = transform.localPosition.y * zforcemult;

		if(Input.GetAxis("Mouse Y")>0 && transform.localPosition.y < 8.8f){
			transform.Translate(0,.01f,0);
		}
		if(Input.GetAxis("Mouse Y")<0 && transform.localPosition.y > 4.5f){
			transform.Translate(0,-.01f,0);
		}

		//transform.localPositionY = range for Z_CannonFire zforce variable 
	}
}
