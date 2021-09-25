using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mundo : MonoBehaviour {

	public static float velocidade;
	public int valorDeSpawn;
	public GameObject Inimigo;
	public GameObject Inimigo2;
	float posicaoAleatoria;                                                                                                                                                                                                                                                                                                   
	int spawnAleatorio;
	int tempo;
	void Start () {
		valorDeSpawn = 10;
		tempo = 1;
		velocidade = 1f;

	}
	void Update () {
		spawnAleatorio = Random.Range (-1000, valorDeSpawn);
		if (Score.score < 250) {
			if (tempo < spawnAleatorio) {
				posicaoAleatoria = Random.Range (-6.0f, 6.0f);
				Inimigo.GetComponent<Transform> ().position = new Vector3 (posicaoAleatoria, Inimigo.GetComponent<Transform> ().position.y, Inimigo.GetComponent<Transform> ().position.z);
				Instantiate (Inimigo.gameObject);
			}
		}
		if (Score.score >= 100) {
			valorDeSpawn = 11;
			if (Score.score >= 200) {
				valorDeSpawn = 15;
				velocidade = 1.5f;
				if (tempo < spawnAleatorio) {
					posicaoAleatoria = Random.Range (-6.0f, 6.0f);
					Inimigo2.GetComponent<Transform> ().position = new Vector3 (posicaoAleatoria,Inimigo.GetComponent<Transform>().position.y,Inimigo.GetComponent<Transform>().position.z);
					Instantiate (Inimigo2.gameObject);
				}
				if(Score.score >= 500){
					valorDeSpawn = 17;
					velocidade = 1.7f;
					
				}
			}
		}
	}
}
