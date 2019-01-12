using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePointing : MonoBehaviour {

    private Vector2 middleOfScreen;
    private Vector2 mousePos;

    [SerializeField]
    CharacterControllerCustom playerController;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        middleOfScreen = new Vector2(Screen.width / 2, Screen.height / 2);
        mousePos = Input.mousePosition;

        Vector2 dir =  middleOfScreen - mousePos;
        dir.Normalize();

        playerController.SetPlayerDirection(dir);
	}
}
