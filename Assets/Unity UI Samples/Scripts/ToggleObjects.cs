using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleObjects : MonoBehaviour {

	public GameObject[] objects;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onGUI(){
		foreach (GameObject go in objects){
			bool active = GUILayout.Toggle (go.activeSelf, go.name);
			if (active != go.activeSelf)
				go.SetActive (active);
		}

	}

}
