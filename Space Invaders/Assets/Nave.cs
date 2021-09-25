using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour {

	public GameObject tiro;
	void Start () {
	}
	void NaveMovimento(){
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate(transform.position.y*(Time.deltaTime+0.08f),0,0);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Translate(transform.position.y*-(Time.deltaTime+0.08f),0,0);
		}
		if (Input.GetKeyDown(KeyCode.Space)){
			Instantiate (tiro.gameObject);
		}
	}
	void Update () {
		NaveMovimento ();
		tiro.GetComponent<Transform> ().position = this.transform.position;
	}
}
