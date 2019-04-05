using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
    public static bool hasKey = false;
    public static bool hasTooth = false;

    public GameObject toothButton;
    public GameObject keyButton;

    public static bool keySelected;
    public static bool toothSelected;

    public GameObject keyPanel;
    public GameObject toothPanel;
    
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
            keyPanel.SetActive(keySelected);
        }

        if (hasTooth)
        {
            toothButton.SetActive(true);
            toothPanel.SetActive(toothSelected);
        }
        
        
    }

    public void UseKey()
    {
        keySelected = !keySelected;       
        toothSelected = false;
    }

    public void UseTooth()
    {
        toothSelected = !toothSelected;
        keySelected = false;
    }
}
