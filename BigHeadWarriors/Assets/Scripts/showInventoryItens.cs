
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class showInventoryItens : MonoBehaviour,IPointerClickHandler
{
    public GameObject panel;

    public void OnPointerClick(PointerEventData eventData)
    {
        panel.SetActive(true);
    }


}
