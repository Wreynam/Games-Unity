using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogada : MonoBehaviour {
	
	public string jogada;
	public int numeroAleatorio;
	string[] maquinaJogada = new string[3];
	public GameObject[] jogadaInimigo = new GameObject[3];
	public GameObject numerYou, numerBot, empate;
	public int Win = 0,Loss = 0,Empate = 0;
	void Start () {
		jogada = null;
		maquinaJogada[0] = "Papel";
		maquinaJogada[1] = "Pedra";
		maquinaJogada[2] = "Tesoura";
	}
	public void Resultado(){
			numeroAleatorio = Random.Range (0, 3);
		GameObject objetoDestruir = Instantiate (jogadaInimigo [numeroAleatorio]);
			if (jogada == maquinaJogada [numeroAleatorio]) {
				Debug.Log ("Empate");
			Empate++;
			} else {
			if (jogada == maquinaJogada[0]) {
				if (maquinaJogada[numeroAleatorio] != maquinaJogada [2]) {
					Debug.Log ("Voçê Venceu da Pedra");
					Win++;
				} else {
					Debug.Log ("Você Perdeu");
					Loss++;
				}
				}
			if (jogada == maquinaJogada[1]){
				if (maquinaJogada [numeroAleatorio] != maquinaJogada [0]) {
					Debug.Log ("Você Venceu do Tesoura");
					Win++;
				} else {
					Debug.Log ("Você perdeu");
					Loss++;
				}
			}
			if (jogada == maquinaJogada [2]) {
				if (maquinaJogada[numeroAleatorio] != maquinaJogada [1]) {
					Debug.Log ("Você Venceu da Papel");
					Win++;
				}else{
					Debug.Log("Você perdeu");
					Loss++;
				}
			}
			}
		Destroy (objetoDestruir.gameObject,1f);
	}
	void Update () {
		numerYou.GetComponent<TextMesh> ().text = Win.ToString ();
		numerBot.GetComponent<TextMesh> ().text = Loss.ToString ();
		empate.GetComponent<TextMesh> ().text = Empate.ToString ();
	}
}
