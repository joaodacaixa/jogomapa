using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _gcmapa : MonoBehaviour {
	public Image b1, b2, b3, b4, b5, b6, b7;
	// Use this for initialization
	void Start () {
		//PlayerPrefs.DeleteKey ("faseconcluida");
		//PlayerPrefs.DeleteAll();
		print(PlayerPrefs.GetInt("faseconluida"));

	}
	
	// Update is called once per frame
	void Update () {
		checafase ();
	}
	public void checafase(){
		print(PlayerPrefs.GetInt("faseconcluida"));
		//PlayerPrefs.GetInt ("faseconcluida");
		if (PlayerPrefs.GetInt ("faseconcluida") == 1) {
			b1.gameObject.SetActive(true);
		}
		if (PlayerPrefs.GetInt ("faseconcluida") == 2) {
			b1.gameObject.SetActive(true);
			b2.gameObject.SetActive(true);
					}
		if (PlayerPrefs.GetInt ("faseconcluida") == 3) {
			b1.gameObject.SetActive(true);
			b2.gameObject.SetActive(true);
			b3.gameObject.SetActive(true);
		}
		if (PlayerPrefs.GetInt ("faseconcluida") == 4) {
			b1.gameObject.SetActive(true);
			b2.gameObject.SetActive(true);
			b3.gameObject.SetActive(true);
			b4.gameObject.SetActive(true);
		}
		if (PlayerPrefs.GetInt ("faseconcluida") == 5) {
			b1.gameObject.SetActive(true);
			b2.gameObject.SetActive(true);
			b3.gameObject.SetActive(true);
			b4.gameObject.SetActive (true);
			b5.gameObject.SetActive(true);
		}
		if (PlayerPrefs.GetInt ("faseconcluida") == 6) {

			b1.gameObject.SetActive(true);
			b2.gameObject.SetActive(true);
			b3.gameObject.SetActive(true);
			b4.gameObject.SetActive (true);

			b5.gameObject.SetActive(true);
			b6.gameObject.SetActive(true);
		}
		if (PlayerPrefs.GetInt ("faseconcluida") == 7) {

			b1.gameObject.SetActive(true);
			b2.gameObject.SetActive(true);
			b3.gameObject.SetActive(true);
			b4.gameObject.SetActive (true);
			b5.gameObject.SetActive(true);
			b6.gameObject.SetActive(true);
			b7.gameObject.SetActive(true);
		}
	}
	public  void mostraesfera(){
		b1.enabled = true;

	}
}
