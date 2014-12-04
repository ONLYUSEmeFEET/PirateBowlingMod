using UnityEngine;
using System.Collections;

public class Z_HUD : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		this.guiText.text = "Score: " + Z_GameMaster.score.ToString();
	}
}
