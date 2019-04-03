using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PopulatePopUp : MonoBehaviour
{
    public Sprite[] targets;

    public Image img;
    public TextMeshProUGUI text;


    public void SetPopUp(int numberOfSprite, string popUpText)
    {
        img.preserveAspect = true;

        img.sprite = targets[numberOfSprite];
        text.text = popUpText;
        gameObject.SetActive(true);
    }

    public void ClearPopUp(){
        img.sprite = null;
        text.text = "";
    }
}
