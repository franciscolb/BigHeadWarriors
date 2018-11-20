using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToArScript : MonoBehaviour {

	public void changeToArButtonClick()
    {
        SceneManager.LoadSceneAsync("ArMainGame");
    }
}
