using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UnitBuyingUI : MonoBehaviour
{

    public Text unitNameText;

    public Image images;

    public List<Sprite> unitImages;

    public Unit buyUnit;

    private void Start()
    {

        int rand = Random.Range(0, unitImages.Count);

        int rand2 = Random.Range(0, GameMananger.Instance.allUnits.Count);

        images.sprite = unitImages[rand];

        buyUnit = GameMananger.Instance.allUnits[rand2];

    }

    public void PushToPlayerUnitQue()
    {
        Instantiate(buyUnit);
    }

    public void EraseUI()
    {
        this.gameObject.SetActive(false);
    }

}
