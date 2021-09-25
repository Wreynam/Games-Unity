using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo2 : MonoBehaviour {
	int contador;
	int pontuacapQueVale;
	void Start () {
		contador = 2;
		pontuacapQueVale = 25;
	}
	void Update () {
		transform.Translate (0, -Mundo.velocidade*Time.deltaTime,0);
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "Tiro1(Clone)"){
			contador--;
			if (contador == 0) {
				Score.score += pontuacapQueVale;
				Destroy (this.gameObject);
			}	
		}

			
	}
}
