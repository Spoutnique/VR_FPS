using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class MoveFPSController : MonoBehaviour {
	public GameObject FpsController;


	void Start () {
	
	}


	void Update () {
		//FpsController.transform.Translate(CrossPlatformInputManager.GetAxis("Horizontal")*0.1f,0,CrossPlatformInputManager.GetAxis("Vertical")*0.1f,spa);
	}
}
