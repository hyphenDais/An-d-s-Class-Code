using UnityEngine;
using System.Collections;

public class AddBulletForce : MonoBehaviour {

	public int myForce = 500;
	public Vector3 startLocation;
	private Rigidbody myRB;

	public void OnReload (){
		myRB.Sleep ();
		transform.position = startLocation;
	}
	// Use this for initialization
	void Start () 
	{
	//OnFire
		myRB = GetComponent<Rigidbody> ();
		startLocation = transform.position;
	}

	public void OnFire () {
		myRB.AddForce (0,0,myForce);
	}

}
