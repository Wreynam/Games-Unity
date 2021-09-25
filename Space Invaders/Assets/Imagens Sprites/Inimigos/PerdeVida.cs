using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerdeVida : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other){
		Vida.vida -= 1;
	}
}
