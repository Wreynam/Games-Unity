using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedra : MonoBehaviour {
	public GameObject Jogo;
	void OnMouseDown(){
		Jogo.GetComponent<Jogada> ().jogada = "Pedra";
		Jogo.GetComponent<Jogada> ().Resultado ();
	}
}
