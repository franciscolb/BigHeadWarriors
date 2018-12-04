using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class onClickFight : MonoBehaviour {

    private void OnMouseDown()
    {
        if (this.tag.Equals("Warrior")){
            SSTools.ShowMessage("Caught a " + this.tag, SSTools.Position.bottom, SSTools.Time.twoSecond);
            Destroy(this.gameObject);
        }
        if (this.tag.Equals("Village"))
        {
            SSTools.ShowMessage("Entering a" + this.name, SSTools.Position.bottom, SSTools.Time.twoSecond);
            
        }
    }
}
