using UnityEngine;
using System.Collections;

public class Z_loading : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		this.guiText.text = "-";
	}
	
	// Update is called once per frame
	void Update () {

		//this.guiText.text += ".";
		Debug.Log(Application.GetStreamProgressForLevel(2));
		StartCoroutine (WaitForLoad ());
	}

	public IEnumerator WaitForLoad(){

		if (Application.CanStreamedLevelBeLoaded (2)) {

			print ("load ready");
			yield return new WaitForSeconds(1);
			this.guiText.text += "-";
			Application.LoadLevel(2);

		}else{
			yield return new WaitForSeconds(.1f);
			this.guiText.text += "-";
		}

	}

}
