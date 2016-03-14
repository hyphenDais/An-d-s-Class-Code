using UnityEngine;
using System.Collections;

public class weapon : MonoBehaviour {

	public AddBulletForce[] myBullets;

	private int i = 0;

	void FireNextBullet ()
	{
		myBullets [i].OnReload ();
		myBullets [i].OnFire ();

		if (i < myBullets.Length-1) {
		i++;
		}else
			i = 0;
	}


	void OnMouseDown (){
		FireNextBullet ();
	}

}
