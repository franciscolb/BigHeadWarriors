using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidGoBackButton : MonoBehaviour {

    public GameObject panel;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)){
            panel.SetActive(false);
        }
	}
}
