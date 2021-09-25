using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tesoura : MonoBehaviour{
	public GameObject Jogo;
	void OnMouseDown(){
		Jogo.GetComponent<Jogada>().jogada = "Tesoura";
		Jogo.GetComponent<Jogada> ().Resultado ();
	}
}
