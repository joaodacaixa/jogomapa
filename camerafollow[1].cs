using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour {
	public float velocidade;
	private Transform alvo;
	public GameObject pl;
	private Vector3 pospl;


	// Use this for initialization
	void Start () {
		alvo = GameObject.FindGameObjectWithTag ("player").transform;

	}
	
	// Update is called once per frame
	void Update () {
		follow ();
	}
	void follow(){
		pospl = new Vector3 (pl.transform.position.x, pl.transform.position.y, transform.position.z);
		Vector3 tempposition = Vector3.Lerp (transform.position, pospl, velocidade);
		transform.position = tempposition;
	}
}
