using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch2 : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;


void Start() {
    camera1.enabled = true;
    camera2.enabled = false;
}

void Update() {
	if(Input.GetButtonDown("AltCamera2")) {
	    camera1.enabled = !camera1.enabled;
        camera2.enabled = !camera2.enabled;
	}
}
}