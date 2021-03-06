﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeethCollectScript : MonoBehaviour {


    public GameObject TeethModel;


    private bool Activated; 
    
    
    

    // Update is called once per frame
    void Update()
    {

        if (!Activated) {

            RaycastHit hit;

            for (int i = 0; i < Input.touchCount; ++i)
                if (Input.GetTouch(i).phase.Equals(TouchPhase.Began)) {
                    // Construct a ray from the current touch coordinates
                    Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);

                    if (Physics.Raycast(ray, out hit, 100f)) {


                        if (hit.collider.CompareTag("Teeth")) {

                            ActivateTeeth();

                        }


                        Debug.Log("You selected the " + hit.transform.name);

                    }

                    // hit.transform.gameObject.SendMessage("OnMouseDown");
                }


            if (Input.GetMouseButtonDown(0)) {

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit, 100.0f)) {
                    //StartCoroutine(ScaleMe(hit.transform));

                    if (hit.collider.CompareTag("Teeth")) {

                        ActivateTeeth();

                    }

                    Debug.Log("You selected the " + hit.transform.name); // ensure you picked right object
                }
            }
        }


    }



    void ActivateTeeth() {

        Activated = true;

        Manager.hasTooth = true; 
        

        try {

            TeethModel.GetComponent<Animator>().SetTrigger("RemoveTeeth");
        } catch {

            TeethModel.SetActive(false);
            
        }

       
        

    }




}
