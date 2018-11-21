using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {
	public GameObject bl;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Destroy(bl, 1.0f);
		
	}
	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag =="TijoloCerto") {
			Destroy (transform.gameObject);

		}
		if (collider.tag =="TijoloErrado") {
			Destroy (transform.gameObject);

		}
	}
}
