using UnityEngine;
using System.Collections;

public class Z_spawnPins : MonoBehaviour {

	public Vector2 circle;
	public Transform center;
	public float area;
	public float radius=1;



	// Use this for initialization
	void Start () {


		GameObject pinset = Resources.Load<GameObject> ("BowlingPins");

		for(int i=0;i<3;i++){

			circle = Random.insideUnitCircle * radius;
			Instantiate(pinset,new Vector3(circle.x + transform.position.x, pinset.transform.position.y, circle.y + transform.position.z),Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
