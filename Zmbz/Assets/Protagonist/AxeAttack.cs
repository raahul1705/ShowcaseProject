using UnityEngine;
using System.Collections;

public class AxeAttack : MonoBehaviour {
	GameObject axeM;
	Animator axeAnim;
	// Use this for initialization
	void Start () {
		axeM = GameObject.FindGameObjectWithTag ("playerAxe");
		axeAnim = axeM.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col) {
		Debug.Log ("Done");
		if (col.gameObject.tag == "zombie") {
			if (axeAnim.GetCurrentAnimatorStateInfo (0).IsName ("Attack")) {
				Destroy (col.gameObject);
			}
		}
	}
}
