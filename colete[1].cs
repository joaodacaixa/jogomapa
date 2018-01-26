using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class colete : MonoBehaviour {
	public Slider slcolete;
	private boss chefao;
	private Canvas cv;
	// Use this for initialization
	void Start () {
		chefao = FindObjectOfType (typeof(boss)) as boss;
		cv = FindObjectOfType (typeof(Canvas)) as Canvas;
	}
	
	// Update is called once per frame
	void Update () {

		if (slcolete.value == 0) {
			//GetComponent<PolygonCollider2D>().enabled = false;
			chefao.GetComponentInChildren<PolygonCollider2D> ().enabled = true;
			chefao.slb.enabled = true;

			//GetComponent<SpriteRenderer> ().enabled = false;
			Destroy (this.gameObject);
		} else {
			chefao.GetComponentInChildren<PolygonCollider2D> ().enabled = false;
			chefao.slb.enabled = false;


		}
	}

	void OnCollisionEnter2D(Collision2D col){
		switch (col.gameObject.tag) {
		case ("balaplayer"):
			slcolete.value = slcolete.value - 1;
			break;
		}
	}
}
