using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryControl : MonoBehaviour {

    private List<PlayerWarrior> playerInventory;

    [SerializeField]
    private GameObject buttonTemplate;
    [SerializeField]
    private GridLayoutGroup gridGroup;
    [SerializeField]
    private Sprite[] iconSprites;

    private int inventorySize = 100;

    void Start()
    {
        playerInventory = new List<PlayerWarrior>();

        for (int i = 1; i <= inventorySize; i++)
        {
            PlayerWarrior newWarrior = new PlayerWarrior();
            newWarrior.iconSprite = iconSprites[Random.Range(0, iconSprites.Length)];

            playerInventory.Add(newWarrior);
        }

        GenInventory();
    }

    void GenInventory()
    {
        if (playerInventory.Count < 4)
        {
            gridGroup.constraintCount = playerInventory.Count;
        }
        else
        {
            gridGroup.constraintCount = 3;
        }
        foreach (PlayerWarrior newWarrior in playerInventory)
        {
            GameObject newButton = Instantiate(buttonTemplate) as GameObject;
            newButton.SetActive(true);

            newButton.GetComponent<InventoryButton>().SetIcon(newWarrior.iconSprite);
            newButton.transform.SetParent(buttonTemplate.transform.parent, false);

        }

    }

    public class PlayerWarrior
    {
        public Sprite iconSprite;
    }
}
