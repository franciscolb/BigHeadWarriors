using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroManager : MonoBehaviour {

    [SerializeField]
    private float DELAY_TIME = 3f;

    public GameObject introMenu;
    public GameObject goMenu;

    private float timeElapsed;

    // Update is called once per frame
    void Update () {
        timeElapsed += Time.deltaTime;

        if ( timeElapsed > DELAY_TIME )
        {
            goMenu.SetActive(true);
            introMenu.SetActive(false);
        }
	}
}
