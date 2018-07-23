using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;
public class Player : NetworkBehaviour {

    private Vector3 inputValue;

	
	// Update is called once per frame
	void Update () {
        if (!isLocalPlayer){
            return;
        }
        inputValue.x = CrossPlatformInputManager.GetAxis("Horizontal");
        inputValue.z = CrossPlatformInputManager.GetAxis("Vertical");
        inputValue.y = 0f;

        transform.Translate(inputValue);
    }

    public override void OnStartLocalPlayer(){
        GetComponentInChildren<Camera>().enabled = true;
    }
}
