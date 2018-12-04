using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class goToMainGame : MonoBehaviour {

    public GameObject LoadingScreen;
    public Slider slider;
	public void OnClickChangeToMainGame()
    {
        StartCoroutine(LoadAsynchronously("MainGame"));
    }

    IEnumerator LoadAsynchronously(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("MainGame");
        LoadingScreen.SetActive(true);
        operation.allowSceneActivation = false;
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;
            if (slider.value == 1)
            {
                operation.allowSceneActivation = true;
            }
            yield return null;
        }
        {

        }
    }
}
