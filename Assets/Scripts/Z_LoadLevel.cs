using UnityEngine;
using System.Collections;

public class Z_LoadLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//doesn't show the start button until the scene can be loaded
		if(Application.CanStreamedLevelBeLoaded(1)){
			this.guiText.text = "Start";
		}else{
			this.guiText.text = "";
		}
		//loads the loading screen when clicked
		if (this.guiText.HitTest (Input.mousePosition) && Input.GetMouseButtonDown(0)) {
			if(Application.CanStreamedLevelBeLoaded(1)){
				Application.LoadLevel(1);//jump to Load Scene
			}
		}
	
	}
}
