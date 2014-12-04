using UnityEngine;
using System.Collections;

public class Z_CannonFire : MonoBehaviour {

	//global variables

	public GameObject cannonBall;
	private GameObject ballpfab;
	public float zforce;
	public float exforce;
	private bool reset = true;
	public Transform cball;
	private Transform p;
	private Transform h;
	public bool fire;
	public Transform offsetX;
	//public Transform offsetY;

	// Use this for initialization
	void Start () {

		ballpfab = Resources.Load<GameObject> ("CannonBall2");
		cball = GameObject.Find ("CannonBall2").GetComponent<Transform> ();
		p = GameObject.Find ("VerticalAxis").GetComponent<Transform> ();
		h = GameObject.Find ("HorizontalAxis").GetComponent<Transform> ();


	}
	
	// Update is called once per frame
	void Update () {

		SpaceBarFire ();
	}

	void OnMouseDown(){



		//cannonball fires at player if the reset condition has been met
		if (Z_GameMaster.reload) {

			Vector3 rot = new Vector3 ((p.transform.localEulerAngles.x + offsetX.localEulerAngles.x), h.transform.localEulerAngles.y + offsetX.localEulerAngles.y, 0);
			Debug.Log(rot);
			rot = new Vector3 (rot.x, rot.y, rot.z);
			Debug.Log("hrotObject " + rot);
			Quaternion quatrot = Quaternion.Euler (rot);
//			Debug.Log(quatrot.eulerAngles);
			Vector3 ballspot = cball.transform.position;
			GameObject ball = Instantiate (ballpfab, ballspot, quatrot) as GameObject;
			//Debug.Log (ball.transform.localEulerAngles);

			if(fire){
				ball.rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
				ball.rigidbody.AddRelativeForce ((-zforce*1000),0,0);
				//Debug.Log (ball.transform.forward);
			}
			audio.Play ();
		}

	}

	void SpaceBarFire(){

		if (Z_GameMaster.reload && Input.GetKeyDown("space")) {
			
			Vector3 rot = new Vector3 ((p.transform.localEulerAngles.x + offsetX.localEulerAngles.x), h.transform.localEulerAngles.y + offsetX.localEulerAngles.y, 0);
			Debug.Log(rot);
			rot = new Vector3 (rot.x, rot.y, rot.z);
			Debug.Log("hrotObject " + rot);
			Quaternion quatrot = Quaternion.Euler (rot);
			//			Debug.Log(quatrot.eulerAngles);
			Vector3 ballspot = cball.transform.position;
			GameObject ball = Instantiate (ballpfab, ballspot, quatrot) as GameObject;
			//Debug.Log (ball.transform.localEulerAngles);
			
			if(fire){
				ball.rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
				ball.rigidbody.AddRelativeForce ((-zforce*1000),0,0);
				//Debug.Log (ball.transform.forward);
			}
			audio.Play ();
		}


	}
}
