using UnityEngine;
using System.Collections;

public class Z_CamSwitch : MonoBehaviour {

	public Camera littlecam;
	public Camera bigcam;
	public Camera tempcam;
	private Rect lcamrect;
	// Use this for initialization
	void Start () {

		bigcam = Camera.main;
		lcamrect = littlecam.rect;

	}
	
	// Update is called once per frame
	void Update () {

		if(this.guiTexture.HitTest(Input.mousePosition,Camera.main) && Input.GetMouseButtonDown(0)){

			bigcam = Camera.main;//establish that the current big cam var is the current main camera in the scene

			//change which camera is the main camera
			littlecam.tag = "MainCamera";//sets the new main camera to have the correct game tag
			bigcam.gameObject.tag = null;//remove the original main camera tag from the old camera
			tempcam = bigcam;

			//resize the big camera and send behing new big camera
			bigcam.depth = 5;//send the old camera back in layer order
			bigcam.rect = lcamrect;//resize the original main cam

			//resize the little camera and put in front of former big camera
			littlecam.depth = 4;//bring the new main camera to the foreground
			littlecam.rect = new Rect(0,0,1,1);//make the new main camera fill the screen
			bigcam = Camera.main;//establish that the new camera is the main camera

			//flip the camera variables to enable another swap
			littlecam = tempcam;//makes the little cam the big cam var

		}
	
	}
}
