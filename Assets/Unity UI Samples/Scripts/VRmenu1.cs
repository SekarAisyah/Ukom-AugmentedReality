using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRmenu1 : MonoBehaviour {
	
	public Transform menuS, menuB, menuU, menuT, map;
	public Transform subMs, subMb, subMu,subMt;
	public Transform menuSpintas;
	public Transform menuBpintas;
	public Transform menuUpintas;
	public Transform menuTpintas;
	public GameObject player;
	public void LoadScene(string nama){
		Application.LoadLevel (nama);
	}


	public void S (bool clicked){
		if (clicked == true) {
			subMs.gameObject.SetActive (clicked);	
			menuS.gameObject.SetActive (false);
			menuB.gameObject.SetActive (false);
			menuU.gameObject.SetActive (false);
			menuT.gameObject.SetActive (false);
			map.gameObject.SetActive (false);
			menuSpintas.gameObject.SetActive (false);
		} else {
			subMs.gameObject.SetActive (clicked);
			menuS.gameObject.SetActive (true);
			menuB.gameObject.SetActive (true);
			menuU.gameObject.SetActive (true);
			menuT.gameObject.SetActive (true);
			map.gameObject.SetActive (true);
			menuSpintas.gameObject.SetActive(false);
		}
	}


	public void Spintas (bool clicked){
		if (clicked == true) {
			menuSpintas.gameObject.SetActive (clicked);
			subMs.gameObject.SetActive (false);
			menuS.gameObject.SetActive (false);
			menuB.gameObject.SetActive (false);
			menuU.gameObject.SetActive (false);
			menuT.gameObject.SetActive (false);
			map.gameObject.SetActive (false);
		} else {
			menuSpintas.gameObject.SetActive (clicked);
			subMs.gameObject.SetActive (true);
			menuS.gameObject.SetActive (false);
			menuB.gameObject.SetActive (false);
			menuU.gameObject.SetActive (false);
			menuT.gameObject.SetActive (false);
			map.gameObject.SetActive (false);
		}
	}

	//=========================================================
	public void B (bool clicked){
		if (clicked == true) {
			subMb.gameObject.SetActive (clicked);	
			menuS.gameObject.SetActive (false);
			menuB.gameObject.SetActive (false);
			menuU.gameObject.SetActive (false);
			menuT.gameObject.SetActive (false);
			map.gameObject.SetActive (false);
			menuBpintas.gameObject.SetActive (false);
		} else {
			subMb.gameObject.SetActive (clicked);
			menuS.gameObject.SetActive (true);
			menuB.gameObject.SetActive (true);
			menuU.gameObject.SetActive (true);
			menuT.gameObject.SetActive (true);
			map.gameObject.SetActive (true);
			menuBpintas.gameObject.SetActive(false);
		}
	}

	public void Bpintas (bool clicked){
		if (clicked == true) {
			menuBpintas.gameObject.SetActive (clicked);
			subMb.gameObject.SetActive (false);
			menuS.gameObject.SetActive (false);
			menuB.gameObject.SetActive (false);
			menuU.gameObject.SetActive (false);
			menuT.gameObject.SetActive (false);
			map.gameObject.SetActive (false);
		} else {
			menuBpintas.gameObject.SetActive (clicked);
			subMb.gameObject.SetActive (true);
			menuS.gameObject.SetActive (false);
			menuB.gameObject.SetActive (false);
			menuU.gameObject.SetActive (false);
			menuT.gameObject.SetActive (false);
			map.gameObject.SetActive (false);
		}
	}

	//=======================================================
	public void U (bool clicked){
		if (clicked == true) {
			subMu.gameObject.SetActive (clicked);	
			menuS.gameObject.SetActive (false);
			menuB.gameObject.SetActive (false);
			menuU.gameObject.SetActive (false);
			menuT.gameObject.SetActive (false);
			map.gameObject.SetActive (false);
			menuUpintas.gameObject.SetActive (false);
		} else {
			subMu.gameObject.SetActive (clicked);
			menuS.gameObject.SetActive (true);
			menuB.gameObject.SetActive (true);
			menuU.gameObject.SetActive (true);
			menuT.gameObject.SetActive (true);
			map.gameObject.SetActive (true);
			menuUpintas.gameObject.SetActive(false);
		}
	}

	public void Upintas (bool clicked){
		if (clicked == true) {
			menuUpintas.gameObject.SetActive (clicked);
			subMu.gameObject.SetActive (false);
			menuS.gameObject.SetActive (false);
			menuB.gameObject.SetActive (false);
			menuU.gameObject.SetActive (false);
			menuT.gameObject.SetActive (false);
			map.gameObject.SetActive (false);
		} else {
			menuUpintas.gameObject.SetActive (clicked);
			subMu.gameObject.SetActive (true);
			menuS.gameObject.SetActive (false);
			menuB.gameObject.SetActive (false);
			menuU.gameObject.SetActive (false);
			menuT.gameObject.SetActive (false);
			map.gameObject.SetActive (false);
		}
	}
	//=======================================================

	public void T (bool clicked){
		if (clicked == true) {
			subMt.gameObject.SetActive (clicked);	
			menuS.gameObject.SetActive (false);
			menuB.gameObject.SetActive (false);
			menuU.gameObject.SetActive (false);
			menuT.gameObject.SetActive (false);
			map.gameObject.SetActive (false);
			menuTpintas.gameObject.SetActive (false);
		} else {
			subMt.gameObject.SetActive (clicked);
			menuS.gameObject.SetActive (true);
			menuB.gameObject.SetActive (true);
			menuU.gameObject.SetActive (true);
			menuT.gameObject.SetActive (true);
			map.gameObject.SetActive (true);
			menuTpintas.gameObject.SetActive(false);
		}
	}

	public void Tpintas (bool clicked){
		if (clicked == true) {
			menuTpintas.gameObject.SetActive (clicked);
			subMt.gameObject.SetActive (false);
			menuS.gameObject.SetActive (false);
			menuB.gameObject.SetActive (false);
			menuU.gameObject.SetActive (false);
			menuT.gameObject.SetActive (false);
			map.gameObject.SetActive (false);
		} else {
			menuTpintas.gameObject.SetActive (clicked);
			subMt.gameObject.SetActive (true);
			menuS.gameObject.SetActive (false);
			menuB.gameObject.SetActive (false);
			menuU.gameObject.SetActive (false);
			menuT.gameObject.SetActive (false);
			map.gameObject.SetActive (false);
		}
	}

	//=============================================
	public void gotoA (bool clicked){
		if (clicked == true) {
			player.transform.position = new Vector3 (-15,9,-4);
		} 
	}

	public void gotoB (bool clicked){
		if (clicked == true) {
			player.transform.position = new Vector3 (-16,9,15); //4
		} 
	}

	public void gotoC (bool clicked){
		if (clicked == true) {
			player.transform.position = new Vector3 (-11,9,52); //2
		} 
	}

	public void gotoD (bool clicked){
		if (clicked == true) {
			player.transform.position = new Vector3 (-36,9,90); //0
		} 
	}
}