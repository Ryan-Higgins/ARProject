using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleUp : MonoBehaviour
{
    Vector3 targetScale;

    Vector3 targetpos;


    // Start is called before the first frame update
    void Awake()
    {
        targetScale = transform.localScale;
        transform.localScale = Vector3.zero;
        targetpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.activeSelf == true){
            transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * 2f);
            transform.position = Vector3.Lerp(transform.position, targetpos, Time.deltaTime);
        }else{
            transform.localScale = Vector3.zero;
        }
    }

    public void SetCurrentPos(float x, float y, float z){
        transform.position = new Vector3(x, y, z);
    }
}
