
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class showInventoryItems: MonoBehaviour,IPointerClickHandler
{
    public GameObject panel;

    public void OnPointerClick(PointerEventData eventData)
    {
        panel.SetActive(true);
    }


}
