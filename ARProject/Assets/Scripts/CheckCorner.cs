using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCorner : MonoBehaviour
{

    public bool cut;
    // Start is called before the first frame update
    void OnEnable()
    {
        cut = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Cut"){
            cut = true;
        }
    }

    public void Reset()
    {
        cut = false;
    }
}
