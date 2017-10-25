using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectMouseInput : MonoBehaviour {
	
	//Detects what Mouse Button is pressed
	public void MouseInput() {
        if (Input.GetMouseButtonDown(0)) //Button 0 = Left; Button 1 = Right; Button 2 = Middle/Scroll
        {
            Debug.Log("Left");
        }

        if (Input.GetMouseButtonDown(1)) //Input.[] Detects what type of input is being given + Specifies which input ("R" or Left Click)
        {
            Debug.Log("Right");
        }
	}
}
