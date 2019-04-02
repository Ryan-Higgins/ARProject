using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tumbler : MonoBehaviour
{
    

        public void UpdateValue() {


                CurrentValue++;

                if (CurrentValue >= 10) {

                        CurrentValue = 0;

                        rotations++;

                        //desiredTheta =

                } else 



                        desiredTheta = (CurrentValue * (360 / 10) + (360 * rotations));
                

                //Quaternion.AngleAxis(CurrentValue * (360 / 10), Vector3.up);

                

        }


        private void Update() {


                currentTheta = Mathf.Lerp(currentTheta, desiredTheta, 3f * Time.deltaTime);
                
                transform.localRotation = Quaternion.Euler(currentTheta, 0f, 90f);
                
                
        }


        public GameObject TumblerRing;

        public int CurrentValue;


        private float currentTheta;
        private float desiredTheta;

        private int rotations;






}
