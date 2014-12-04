using UnityEngine;
using System.Collections;

public class Z_GameMaster : MonoBehaviour {

	public static int score=0;
	public static bool reset = false;
	public static bool reload = true;
	public float wait = 6.0f;
	public static int firecount = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//if (firecount >= 2)reload = false;

	}

	IEnumerator OnTriggerEnter(Collider thing){

		if(thing.gameObject.tag =="cannonball"){
			reload = false;
			yield return new WaitForSeconds(wait);
			reload = true;
			firecount +=1;
		}

	}
}
