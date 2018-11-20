using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Auth;
using UnityEngine.SceneManagement;


public class FirebaseAuthenticationScript : MonoBehaviour {

    public InputField email, password;

    public void LoginButtonPressed()
    {
        Debug.Log("hey");
        FirebaseAuth.DefaultInstance.SignInWithEmailAndPasswordAsync(email.text, password.text).
            ContinueWith((obj) =>
            {
                SSTools.ShowMessage(email.text, SSTools.Position.bottom, SSTools.Time.oneSecond);
                SceneManager.LoadSceneAsync("MainGame");
            });

    }

    public void CreateUserButtonPressed()
    {
        FirebaseAuth.DefaultInstance.CreateUserWithEmailAndPasswordAsync(email.text,password.text).
             ContinueWith((obj) =>
             { 
                 SceneManager.LoadSceneAsync("MainGame");
             });
    }
}
