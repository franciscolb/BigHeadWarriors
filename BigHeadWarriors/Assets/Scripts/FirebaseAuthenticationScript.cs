using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Auth;
using UnityEngine.SceneManagement;


public class FirebaseAuthenticationScript : MonoBehaviour {

    public InputField EmailAddress, Password;
    private bool signed = false;
    private bool loginError = false;
    private bool signUpError = false;

    public void buttonClickLogin()
    {
        Firebase.Auth.FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        auth.SignInWithEmailAndPasswordAsync(EmailAddress.text, Password.text).ContinueWith(task =>
        {
            if (task.IsCanceled)
            {
                Debug.LogError("SignInWithEmailAndPasswordAsync canceled.");
                loginError = true;
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("SignInWithEmailAndPasswordAsync error: " + task.Exception);
                loginError = true;
                if (task.Exception.InnerExceptions.Count > 0)
                    //UpdateErrorMessage(task.Exception.InnerExceptions[0].Message);
                    return;
            }

            FirebaseUser user = task.Result;
            Debug.LogFormat("User signed in successfully: {0} ({1})",
                user.DisplayName, user.UserId);

            //SceneManager.LoadScene("LoginResults");
            this.signed = true;
        });
    }

    public void ButtonClickSignUp()
    {
        Firebase.Auth.FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        auth.CreateUserWithEmailAndPasswordAsync(EmailAddress.text, Password.text).ContinueWith(task => {
            if (task.IsCanceled)
            {
                Debug.LogError("CreateUserWithEmailAndPasswordAsync was canceled.");
                signUpError = true;
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("CreateUserWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                signUpError = true;
                return;
            }

            // Firebase user has been created.
            Firebase.Auth.FirebaseUser newUser = task.Result;
            Debug.LogFormat("Firebase user created successfully: {0} ({1})",
                newUser.DisplayName, newUser.UserId);
        });
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (signed)
        {
            SceneManager.LoadScene("MainGame");
        }
        if (loginError)
        {
            SSTools.ShowMessage("Email or Password not correct",SSTools.Position.bottom,SSTools.Time.threeSecond);
            loginError = false;
        }

        if (signUpError)
        {
            SSTools.ShowMessage("Sign up error. Try again", SSTools.Position.bottom, SSTools.Time.threeSecond);
            signUpError = false;
        }
    }
}
