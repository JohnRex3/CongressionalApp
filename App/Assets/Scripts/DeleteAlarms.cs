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
        GameObject[] alarm = GameObject.FindGameObjectsWithTag("Alarm");
        //if(Input.touchCount > 0 || Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("tap");
        //    delAlarm();
        //}
        

        if (delete == true)
        {
            if(Input.touchCount > 0 || Input.GetMouseButtonDown(0))
            {
                Debug.Log("touch");
                Destroy(alarm);
            }
        }
        else
        {

        }
    }

    private void Destroy(GameObject[] alarm)
    {
        throw new NotImplementedException();
    }

    public void delAlarm()
    {
        delete = !delete;
    }
}
