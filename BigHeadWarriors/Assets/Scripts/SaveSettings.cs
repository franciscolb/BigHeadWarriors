using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveSettings : MonoBehaviour {

    public Text username;
    public void saveData()
    {
        PlayerPrefs.SetString("username", username.text);
        SSTools.ShowMessage("Saved username " + PlayerPrefs.GetString("username"), SSTools.Position.bottom, SSTools.Time.oneSecond);
        PlayerPrefs.Save();
    }
    
    public void loadData()
    {
        SSTools.ShowMessage(PlayerPrefs.GetString("username"), SSTools.Position.bottom, SSTools.Time.oneSecond);
        username.text = PlayerPrefs.GetString("username");
    }
}
