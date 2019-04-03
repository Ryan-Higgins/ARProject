using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickInScene : MonoBehaviour
{
    public int numberOfObject;
    public string messageToDisplay;

    public PopulatePopUp popUp;

    private void Awake()
    {
        //popUp = GameObject.Find("Pop Up").GetComponent<PopulatePopUp>();
        print(popUp.gameObject);
    }

    void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0)){
            print("test");

            popUp.SetPopUp(numberOfObject, messageToDisplay);
        }
    }
}
