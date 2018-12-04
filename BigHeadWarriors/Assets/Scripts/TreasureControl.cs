using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreasureControl : MonoBehaviour
{

    private List<Treasure> playerTreasures;
    private int TREASURES_COUNT = 16;

    [SerializeField]
    private GameObject buttonTemplate;
    [SerializeField]
    private GridLayoutGroup gridGroup;
    [SerializeField]
    private Sprite[] iconSprites;

    void Start()
    {
        playerTreasures = new List<Treasure>();
        SSTools.ShowMessage(iconSprites[0].name, SSTools.Position.bottom, SSTools.Time.oneSecond);

        for (int i = 1; i <= TREASURES_COUNT; i++)
        {
            Treasure newTreasure = new Treasure();
            newTreasure.iconSprite = iconSprites[i];
            
            playerTreasures.Add(newTreasure);
        }

        GenInventory();
    }

    void GenInventory()
    {
        if (playerTreasures.Count < 4)
        {
            gridGroup.constraintCount = playerTreasures.Count;
        }
        else
        {
            gridGroup.constraintCount = 3;
        }
        foreach (Treasure newTreasure in playerTreasures)
        {
            GameObject newButton = Instantiate(buttonTemplate) as GameObject;
            newButton.SetActive(true);

            newButton.GetComponent<InventoryButton>().SetIcon(newTreasure.iconSprite);
            newButton.transform.SetParent(buttonTemplate.transform.parent, false);

        }

    }

    public class Treasure
    {
        private string treasureId;
        private bool captured;
        private int quant;
        public Sprite iconSprite;

        public Treasure()
        {
            TreasureId = "???";
            Captured = false;
            Quant = 0;
        }

        public Treasure(string treasureId, bool captured, int quant)
        {
            TreasureId = treasureId;
            Captured = captured;
            Quant = quant;
        }

        public string TreasureId
        {
            get
            {
                return treasureId;
            }

            set
            {
                treasureId = value;
            }
        }

        public bool Captured
        {
            get
            {
                return captured;
            }

            set
            {
                captured = value;
            }
        }

        public int Quant
        {
            get
            {
                return quant;
            }

            set
            {
                quant = value;
            }
        }
    }
}
