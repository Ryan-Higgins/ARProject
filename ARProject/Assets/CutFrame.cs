using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutFrame : MonoBehaviour
{
    LineRenderer trail;

    public float vectorDistance;

    public GameObject cutter;

    public CheckCorner[] corners;

    public LayerMask mask;


    private void Awake()
    {
        trail = GetComponent<LineRenderer>();
        trail.positionCount = 0;
        trail.startWidth = 0.05f;
        trail.endWidth = 0.05f;

    }

    private void Update()
    {
        if(gameObject.activeSelf){
            if (Input.GetMouseButton(0))
            {

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                Debug.DrawRay(ray.origin, ray.direction * 10000f);

                if (Physics.Raycast(ray, out RaycastHit hit, 10000.0f, mask))
                {
                    cutter.transform.position = hit.point;

                    if (hit.collider.CompareTag("Border"))
                    {
                        print("test");
                        if (trail.positionCount == 0)
                        {
                            trail.positionCount++;
                            trail.SetPosition(trail.positionCount - 1, hit.point);
                        }else if(Vector3.Distance(trail.GetPosition(trail.positionCount -1), hit.transform.position) > vectorDistance)
                        {
                            trail.positionCount++;
                            trail.SetPosition(trail.positionCount - 1, hit.point);
                        }

                        int num = 0;
                        foreach (CheckCorner corner in corners)
                        {
                            if(corner.cut){
                                num++;
                            }
                        }

                        if(num == 4){
                            print("done");
                        }
                    }
                }else{
                    trail.positionCount = 0;
                    foreach(CheckCorner corner in corners){
                        corner.Reset();
                    }

                }

            }
        }



    }

}
