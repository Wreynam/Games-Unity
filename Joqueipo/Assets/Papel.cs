using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Papel : MonoBehaviour {
	public GameObject Jogo;
	void OnMouseDown(){
		Jogo.GetComponent<Jogada>().jogada = "Papel";
		Jogo.GetComponent<Jogada> ().Resultado ();
	}
}
