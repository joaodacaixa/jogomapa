using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class _gcgopa1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void jogarnovamente(){
		SceneManager.LoadScene("fase2");
	}

	public void menu(){
		SceneManager.LoadScene ("mapa");
	}
}
