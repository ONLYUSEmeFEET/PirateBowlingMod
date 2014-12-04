using UnityEngine;
using System.Collections;

public class Z_pinHit : MonoBehaviour {

	float knockedAngle = 85.0f;
	Vector3 InitAngles;
	Vector3 origPosition; 
	public bool pinDown = false;
	private bool scoremade = false;
	public static int score = 0; 
	public AudioClip clack = new AudioClip();
	public Ray pinRay = new Ray();
	RaycastHit pinhit;
	private float distance;
	public static bool ballhitpin;

	// Use this for initialization
	void Awake(){

		print ("pin awake");
		InitAngles = transform.localEulerAngles;
		origPosition = transform.position;
		pinRay = new Ray (origPosition, transform.up);
		distance = 12.0f;
		clack = Resources.Load<AudioClip> ("clack");
	}
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		IsKnockedOver ();
		//Physics.Raycast (pinRay, out pinhit, distance);
		//Debug.DrawLine (origPosition, origPosition + new Vector3 (0,12, 0), Color.cyan);
		//Debug.DrawRay (transform.position, transform.up * 10, Color.blue);
		//Debug.Log (Vector3.Dot (Vector3.up, transform.up));


	
	}

	void OnCollisionEnter(Collision thing){

		if (thing.relativeVelocity.magnitude > 6){
				audio.PlayOneShot (clack);
		}
		if (thing.gameObject.tag == "cannonball") {

			ballhitpin=true;		
		}

	}

	public void IsKnockedOver(){

		if(Vector3.Dot(Vector3.up,transform.up)<=.1){

			pinDown = true;
			if(!audio.isPlaying && !scoremade) {
				audio.Play();
				scoremade = true;
				Z_GameMaster.score+=1;
				print (Z_GameMaster.score);

			}

		}				
		
	}
}
