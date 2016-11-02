using UnityEngine;
using System.Collections;

public class PistolMoveAnim : MonoBehaviour {
	Animator anim;
	[SerializeField]ParticleSystem mFlash;
	bool shot = false;
	// Use this for initialization
	void Start () {
		Debug.Log (Time.timeScale);
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetButton ("Fire2") && !anim.GetCurrentAnimatorStateInfo (0).IsName ("Reload")) {
			anim.SetBool ("Aiming", true);
			Camera.main.fieldOfView = 48;
		} 
		else {
			anim.SetBool ("Aiming", false);
			Camera.main.fieldOfView = 60;
		}

		if (Input.GetMouseButtonDown(0)) {
			
			if (!anim.GetCurrentAnimatorStateInfo (0).IsName ("ShootRelaxed") 
				|| !anim.GetCurrentAnimatorStateInfo (0).IsName ("ShootAim")) {


				if (shot == false) {
					anim.SetBool ("Shoot", true);
					mFlash.Play ();
					shot = true;
					StartCoroutine (shoot ());
				} 
			}


		} else {
			//mFlash.Stop ();
			anim.SetBool ("Shoot", false);
		}



		if (Input.GetKeyDown("r")) {
			Camera.main.fieldOfView = 60;
			anim.SetBool ("Reload", true);
		} 
		else {
			anim.SetBool ("Reload", false);
		}
	}

	IEnumerator shoot() {
		Debug.Log ("RUN");
		yield return new WaitForSeconds (0.3f);
		shot = false;
	}
}
