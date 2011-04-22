using UnityEngine;
using System.Collections;

public class VilliKuutio : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.right*Time.deltaTime*150);
		transform.Rotate(Vector3.up*Time.deltaTime*190);
	}
}
