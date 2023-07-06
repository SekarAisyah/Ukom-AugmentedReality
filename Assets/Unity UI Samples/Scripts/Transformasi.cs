using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformasi : MonoBehaviour {
	

	public Transform player;




	public void gotoA (bool clicked){
		if (clicked == true) {
			player.transform.position = new Vector3 (-7,0,26);

		} 
	}



}