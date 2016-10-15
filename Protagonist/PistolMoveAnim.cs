using UnityEngine;
using System.Collections;

public class PistolMoveAnim : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire2")) {
			anim.SetBool ("Aiming", true);
		} 
		else {
			anim.SetBool ("Aiming", false);
		}

		if (Input.GetButtonDown("Fire1")) {
			anim.SetBool ("Shoot", true);
		} else {
			anim.SetBool ("Shoot", false);
		}



		if (Input.GetKeyDown("r")) {
			anim.SetBool ("Reload", true);
		} 
		else {
			anim.SetBool ("Reload", false);
		}


	}
}
