using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class _gcgopa7: MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void jogarnovamente(){
		SceneManager.LoadScene("final");
	}

	public void menu(){
		SceneManager.LoadScene ("mapa");
	}
}
