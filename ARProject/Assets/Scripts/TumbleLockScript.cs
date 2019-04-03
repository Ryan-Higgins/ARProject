using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class TumbleLockScript : MonoBehaviour {


    [Range(0, 9)] public int Code0, Code1, Code2;

    public Tumbler Tumbler0, Tumbler1, Tumbler2;


    private bool Locked = true;


    public GameObject Chest;
    public GameObject Lock;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Locked) {

            if (Tumbler0.CurrentValue == Code0 && Tumbler1.CurrentValue == Code1 && Tumbler2.CurrentValue == Code2) {

               // if (Manager.has

                Unlock();
                
                
            }



            RaycastHit hit;
/*
            for (int i = 0; i < Input.touchCount; ++i)
                if (Input.GetTouch(i).phase.Equals(TouchPhase.Began)) {
                    // Construct a ray from the current touch coordinates
                    Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);

                    if (Physics.Raycast(ray, out hit, 100f)) {


                        if (hit.collider.CompareTag("Tumbler")) {

                            //ActivateTeeth();

                            //Unlock();

                            hit.collider.GetComponent<Tumbler>().UpdateValue();
                            
                            

                        }


                        Debug.Log("You selected the " + hit.transform.name);

                    }

                    // hit.transform.gameObject.SendMessage("OnMouseDown");
                }
                
                */


            if (Input.GetMouseButtonDown(0)) {

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit, 100.0f)) {
                    //StartCoroutine(ScaleMe(hit.transform));

                    if (hit.collider.CompareTag("Tumbler")) {

                        //ActivateTeeth();

                        hit.collider.GetComponent<Tumbler>().UpdateValue();
                        
                        //Unlock();

                    }

                    Debug.Log("You selected the " + hit.transform.name); // ensure you picked right object
                }
            }




        }
        
        
        
        
        



    }



    void Unlock() {


        Locked = false;
        
        Debug.Log("Unlocked with code: " + Code0 + Code1 + Code2);


        Manager.hasKey = true; 
        
        Chest.SetActive(true);
       Lock.SetActive(false);
        

    }





}



