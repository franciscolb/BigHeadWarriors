using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onClickFight : MonoBehaviour {
    private string playerId = FirebaseAuthenticationScript.uid;

    private void OnMouseDown()
    {
        if (this.tag.Equals("Warrior")){
            SSTools.ShowMessage("Caught a " + this.tag, SSTools.Position.bottom, SSTools.Time.twoSecond);
            Destroy(this.gameObject);
            Warrior warrior = new Warrior("jose", "warrior", "Aveiro", 50, false, 100, "11");
            string json = JsonUtility.ToJson(warrior);
            FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://bigheadwarriors.firebaseio.com/");
            DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
            reference.Child("Players").Child(playerId).Child("warriors").Child("11").SetRawJsonValueAsync(json);
        }
        if (this.tag.Equals("Village"))
        {
            SSTools.ShowMessage("Entering a" + this.name, SSTools.Position.bottom, SSTools.Time.twoSecond);
            
        }
    }
}
