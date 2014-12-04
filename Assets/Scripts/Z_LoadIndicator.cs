using UnityEngine;
using System.Collections;

public class Z_LoadIndicator : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Z_GameMaster.reload){
			this.guiText.text = "Cannon Loaded";
		}else{
			this.guiText.text = "";
		}
			
		}
}
