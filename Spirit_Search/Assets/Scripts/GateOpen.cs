using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpen : MonoBehaviour
{
	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.name == "Player" && GameVariables.keyCount>2){
			GameVariables.keyCount --;
			Destroy (gameObject);
		}
	}

}