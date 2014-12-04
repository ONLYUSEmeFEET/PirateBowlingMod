using UnityEngine;
using System.Collections;

public class Z_WaterSplash : MonoBehaviour {

	private GameObject splashobj;

	// Use this for initialization
	void Start () {

		splashobj = Resources.Load<GameObject> ("Splash_OBJ");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator OnCollisionEnter(Collision thing){
			
		if (thing.gameObject.tag == "cannonball") {

			print (thing.gameObject.name);
			ContactPoint point = thing.contacts[0];
			GameObject splash = Instantiate(splashobj,point.point,Quaternion.identity) as GameObject;
			splash.audio.Play();
			Destroy (thing.gameObject);
			yield return new WaitForSeconds(splash.audio.clip.length);
			Destroy(splash);
		}
	}
}
