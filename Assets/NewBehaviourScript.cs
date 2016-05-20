using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start() {
		// Workaround: Give HMD time to initialize (2 frame skip)
		yield return null;
		yield return null;
		// change VRSettings as needed
		UnityEngine.VR.VRSettings.enabled = false;
	}

	// Update is called once per frame
	void Update () {
	
	}
}
