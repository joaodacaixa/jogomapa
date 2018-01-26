using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cbgeral : MonoBehaviour {
	private cb sccb;
	// Use this for initialization
	void Start () {
		sccb = FindObjectOfType (typeof(cb)) as cb;
	}
	
	// Update is called once per frame
	void Update () {
		if (sccb.GetComponent<BoxCollider2D> ().enabled == false) {
			Destroy (this.gameObject);
		}
	}

}
