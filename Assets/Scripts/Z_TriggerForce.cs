//using UnityEngine;
//using System.Collections;
//
//public class Z_TriggerForce : MonoBehaviour {
//
//	public int zforce;
//	public Rigidbody rbody;
//
//
//	// Use this for initialization
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//	}
//
//	void OnTriggerEnter(Collider thing){
//
//		if (thing.gameObject.tag == "Player")
//		{
//			rbody.constraints = RigidbodyConstraints.None;
//			rbody.AddRelativeForce (Vector3.back*zforce);
//			audio.Play();
//		}
//	}
//}
