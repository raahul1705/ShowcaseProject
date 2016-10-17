using UnityEngine;
using System.Collections;

public class AxeAttack : MonoBehaviour {
	GameObject axeM;
	[SerializeField]Animator axeAnim;
	// Use this for initialization
	void Start () {
		
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
