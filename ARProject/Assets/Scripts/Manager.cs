using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static bool hasKey = false;
    public static bool hasTooth = false;

    public GameObject toothButton;
    public GameObject keyButton;

    public static bool keySelected;
    public static bool toothSelected;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasKey)
        {
            keyButton.SetActive(true);
        }

        if (hasTooth)
        {
            toothButton.SetActive(true);
        }
    }

    public void UseKey()
    {
        if (!keySelected && !toothSelected)
        {
            keySelected = true;
        }
    }

    public void UseTooth()
    {
        if (!toothSelected && !keySelected)
        {
            toothSelected = true;
        }
    }
}
