using UnityEngine;
using System.Collections;
using UnityEngine.UI;




public class gui: MonoBehaviour {


	void OnGUI() {
		GUI.Label(new Rect(10, 10, 100, 20), "Hello World!");
	}


	// Use this for initialization
	void Start () {

	}


	// Update is called once per frame
	void Update () {
	}
}

