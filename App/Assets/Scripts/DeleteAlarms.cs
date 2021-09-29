using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAlarms : MonoBehaviour
{
    bool delete = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject Alarm = GameObject.FindGameObjectWithTag("Alarm");
        //if(Input.touchCount > 0 || Input.GetMouseButtonDown(0))

        Vector3 origin = Vector3.forward * -10;
        RaycastHit hit;
        Ray kill = new Ray(origin, Vector3.forward);
        Debug.DrawRay(origin, Vector3.forward);

        if (delete == true)
        {
            if(Physics.Raycast(kill, out hit, 100))
            {
                if(hit.collider.tag == "Alarm")
                {
                    Debug.Log("hit");
                    Destroy(hit.collider.gameObject);
                }
                    
                
            }
        }
        else
        {

        }
    }

    public void delAlarm()
    {
        delete = !delete;
    }
}
