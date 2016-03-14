using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NewBehaviourScript : MonoBehaviour {

	public List<string> myStringList;


	// adds power up once and the removes it from the game
	void OnTriggerEnter (Collider _c) {
		myStringList.Add (_c.gameObject.name);
		_c.gameObject.SetActive (false);
	}



	// Use this for initialization
	void Start () 
	{
		myStringList = new List<string> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}











