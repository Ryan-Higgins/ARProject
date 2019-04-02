using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    private GameObject mainCamera;
    public GameObject aRCamera;
    bool switchCheck = false;
    
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.Find("Main Camera");
        aRCamera.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchCamera()
    {
        //mainCamera.SetActive(false);
        switchCheck = !switchCheck;
        aRCamera.SetActive(switchCheck);
    }
}
