using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Inputs : MonoBehaviour {


	void Start () {
	
	}
	

	void Update () {

		//print whatever button is pressed
		/*for (int i = 0;i < 20; i++) {
			if(Input.GetKeyDown("joystick 1 button "+i)){
				print("joystick 1 button "+i);
			}
		}*/
	
		Debug.DrawLine(transform.position,transform.forward, Color.red);
		if(Input.GetKeyDown("joystick 1 button "+0) && CrossPlatformInputManager.GetAxis("Horizontal") == 0 && CrossPlatformInputManager.GetAxis("Vertical") == 0 ){ //if you press A & not moving
			transform.position = new Vector3(0,0,0);//reset your position
		}

	}//end of update

}
