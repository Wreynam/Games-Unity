using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour {
	void Start () {
	}
	void Update () {
		transform.Translate (0, 5f*Time.deltaTime, 0);
		Destroy (this.gameObject, 5f);
	}
	void OnTriggerEnter2D(Collider2D collider){
		Destroy (this.gameObject);
	}
}
