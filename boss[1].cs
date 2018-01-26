using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class boss : MonoBehaviour {
	public Transform pontadaarmaboss;
	private int i;
	public GameObject tiroprefab;
	public Slider slb;
	public bool morre, anda;
	public int vidaboss, velocidade;
	public Animator bossanim;
	public colete colsc;


	void Start () {
		colsc = GetComponentInChildren<colete>() as colete;
		bossanim = GetComponentInChildren<Animator> ();
		bossanim.SetBool ("anda", true);
		morre = false;
		StartCoroutine ("tiro");
		StartCoroutine ("tirotriplo");
	}
	
	// Update is called once per frame
	void Update () {
		//StartCoroutine ("andando");
		print(vidaboss);


		if (vidaboss == 0) {
			bossanim.SetBool ("anda", false);
			bossanim.SetBool ("morre", true);
			StopCoroutine ("tiro");
			StopCoroutine ("tirotriplo");
			StartCoroutine ("gameover");
		}

			
	}

	IEnumerator tiro(){
		while (!morre) {
			GameObject tiro = Instantiate (tiroprefab, pontadaarmaboss.transform.position, Quaternion.Euler (0, 0, 0)) as GameObject;
			tiro.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (-400, 0));
			Destroy (tiro, 5.0f);
		
			yield return new WaitForSeconds (4.0f);

		}
	}

		IEnumerator tirotriplo(){
		while (!morre) {
			GameObject tiro = Instantiate (tiroprefab, pontadaarmaboss.transform.position, Quaternion.Euler (0, 0, 0)) as GameObject;
			GameObject tiro2 = Instantiate (tiroprefab, pontadaarmaboss.transform.position, Quaternion.Euler (0, 0, 0)) as GameObject;
			GameObject tiro3 = Instantiate (tiroprefab, pontadaarmaboss.transform.position, Quaternion.Euler (0, 0, 0)) as GameObject;
			tiro.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (-400, 0));
			tiro2.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (-200, 15));
			tiro3.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (-200, -15));
			Destroy (tiro, 5.0f);
			Destroy (tiro2, 5.0f);
			Destroy (tiro3, 5.0f);
			yield return new WaitForSeconds (5.0f);
		}
	}
		IEnumerator gameover(){
			yield return new WaitForSeconds (3.0f);
			SceneManager.LoadScene ("gameovervenceu7");
		

	}
	void OnCollisionEnter2D(Collision2D col){
		if (colsc.slcolete.value == 0) {
			switch (col.gameObject.tag) {
			case ("balaplayer"):
				slb.value = slb.value - 1;
				vidaboss = vidaboss - 1;
				break;
			}
		}
	}

}
