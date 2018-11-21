using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject balaPrefab;
	public Transform nem;
	public float speed;

	public float currentTime;
	public GameObject nem2;
	public bool direct;
	

	void Awake ()
   	{
       
       
    }


	// Use this for initialization
	void Start () {
	currentTime = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		direct = nem2.GetComponent<Player>().direita;

		if (Input.GetAxis("Fire1") > 0 & currentTime > 1){

			GameObject tempPrefab = Instantiate (balaPrefab) as GameObject;

			tempPrefab.transform.position = new Vector3 (transform.position.x,transform.position.y, transform.position.z);

			if(direct == true){
			tempPrefab.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed,0));
			
			}
			if(direct == false){
			tempPrefab.GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed,0));
			tempPrefab.transform.eulerAngles = new Vector2(0,180);
	
			}
			currentTime = 0;
		}
	}
}
