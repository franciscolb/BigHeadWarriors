﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class goToChallenges : MonoBehaviour, IPointerClickHandler{

    public GameObject panel;

    public void OnPointerClick(PointerEventData eventData)
    {
        panel.SetActive(true);
    }
}
