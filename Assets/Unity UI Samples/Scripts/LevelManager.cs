using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
	public Transform menuUtama, menuPlay,menuBantuan, MenuTentangSMK, MenuTentangApk;
	public void LoadScene(string nama){
		Application.LoadLevel (nama);
	}

	public void QuitGame(){
		Application.Quit ();
	}

	public void play (bool clicked) {
		if (clicked == true) {
			menuPlay.gameObject.SetActive (clicked);
			menuUtama.gameObject.SetActive (false);
			menuBantuan.gameObject.SetActive (false);
			MenuTentangSMK.gameObject.SetActive (false);
			MenuTentangApk.gameObject.SetActive (false);
		} else {
			menuPlay.gameObject.SetActive (clicked);
			menuUtama.gameObject.SetActive (true);
			menuBantuan.gameObject.SetActive (false);
			MenuTentangSMK.gameObject.SetActive (false);
			MenuTentangApk.gameObject.SetActive (false);
		}
	}

	public void bantuan (bool clicked) {
		if (clicked == true) {
			menuBantuan.gameObject.SetActive (clicked);
			menuUtama.gameObject.SetActive (false);
			menuPlay.gameObject.SetActive (false);
			MenuTentangSMK.gameObject.SetActive (false);
			MenuTentangApk.gameObject.SetActive (false);
		} else {
			menuBantuan.gameObject.SetActive (clicked);
			menuUtama.gameObject.SetActive (true);
			menuPlay.gameObject.SetActive (false);
			MenuTentangSMK.gameObject.SetActive (false);
			MenuTentangApk.gameObject.SetActive (false);
		}
	}

	public void tentangSMK (bool clicked) {
		if (clicked == true) {
			MenuTentangSMK.gameObject.SetActive (clicked);
			menuBantuan.gameObject.SetActive (false);
			menuUtama.gameObject.SetActive (false);
			menuPlay.gameObject.SetActive (false);
			MenuTentangApk.gameObject.SetActive (false);
		} else {
			MenuTentangSMK.gameObject.SetActive (clicked);
			menuBantuan.gameObject.SetActive (false);
			menuUtama.gameObject.SetActive (true);
			menuPlay.gameObject.SetActive (false);
			MenuTentangApk.gameObject.SetActive (false);
		}
	}


	public void tentangApk (bool clicked) {
		if (clicked == true) {
			MenuTentangApk.gameObject.SetActive (clicked);
			MenuTentangSMK.gameObject.SetActive (false);
			menuBantuan.gameObject.SetActive (false);
			menuUtama.gameObject.SetActive (false);
			menuPlay.gameObject.SetActive (false);

		} else {
			MenuTentangApk.gameObject.SetActive (clicked);
			MenuTentangSMK.gameObject.SetActive (false);
			menuBantuan.gameObject.SetActive (false);
			menuUtama.gameObject.SetActive (true);
			menuPlay.gameObject.SetActive (false);

		}
	}

}
