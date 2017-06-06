using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeColorCubeToRed() {
        GetComponent<Renderer>().material.color = new Color(255, 0, 0);
    }

    public void ChangeColorCubeToBlue()  {
        GetComponent<Renderer>().material.color = new Color(0, 0, 255);
    }
}
