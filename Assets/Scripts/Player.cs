﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public float speed;
	public float jump;
	private Animator anim;
	public Rigidbody2D rgb;
	private bool CondPulo;

	public bool direita;
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator>();
		CondPulo = false;
		direita = true;
		//rgb = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Horizontal")>0){
			transform.Translate(Vector2.right*speed*Time.deltaTime,0);
			transform.eulerAngles = new Vector2(0,0);
			direita = true;
			

		}
		if(Input.GetAxis("Horizontal")<0){
			transform.Translate(-Vector2.right*speed*Time.deltaTime,0);
			transform.eulerAngles = new Vector2(0,180);
			direita = false;

			
		}
		if(Input.GetButtonDown("Jump") && CondPulo == true){
			rgb.AddForce(new Vector2(0,jump));
			anim.SetBool("Jump", true);
			CondPulo = false;




		}
		anim.SetFloat("Run", Mathf.Abs(Input.GetAxis("Horizontal")));

	}
	void OnCollisionEnter2D (Collision2D col)
    {
        if(col.gameObject.name == "Chao")
        {
            CondPulo = true;
            anim.SetTrigger("IsGround");
            anim.SetBool("Jump", false);
        }
    }

}
