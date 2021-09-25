using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverInimigo : MonoBehaviour {
	public int pontuacaoQueVale = 10;
	void Start () {
	}
	void Update () {
		transform.Translate (0, -Mundo.velocidade*Time.deltaTime,0);
	}
	void OnTriggerEnter2D(Collider2D collider){
		if(collider.gameObject.name == "Tiro1(Clone)"){
			Score.score += pontuacaoQueVale;
			Destroy (this.gameObject);	
		}

	}
}
