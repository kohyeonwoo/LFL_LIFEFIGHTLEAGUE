using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UnitBuyingUI : MonoBehaviour
{
    public Image images;

    public List<Sprite> unitImages;

    private void Start()
    {

        int rand = Random.Range(0, unitImages.Count);

        images.sprite = unitImages[rand];
       
    }
}
