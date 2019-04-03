using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class OnScanPainting : MonoBehaviour,
                                            ITrackableEventHandler
{

    public GameObject painting;
    public bool open;

    private TrackableBehaviour mTrackableBehaviour;

    public static OnScanPainting instance;

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }

        instance = this;
    }

    void Update()
    {
        if (open)
        {
            painting.SetActive(true);
        }
        else
        {
            painting.SetActive(false);
        }
    }




    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            if (!open)
            {
                painting.SetActive(true);
                painting.GetComponent<ScaleUp>().SetCurrentPos(transform.position.x, transform.position.y, transform.position.z);
                open = true;
            }
        }
    }

    public static void TurnOff(){
        instance.open = false;
    }

    public void TurnOffNormal()
    {
        open = false;
    }
}
