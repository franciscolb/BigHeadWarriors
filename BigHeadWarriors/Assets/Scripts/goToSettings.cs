using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class goToSettings : MonoBehaviour, IPointerClickHandler
{

    public GameObject panel;
    public Text username;

    public void OnPointerClick(PointerEventData eventData)
    {
        panel.SetActive(true);
    }
}
