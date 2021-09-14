using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewAlarms : MonoBehaviour
{
    [SerializeField] GameObject Alarm;
    [SerializeField] GameObject Canvas;

    public Button AddAlarm;
    //public GameObject Alarm;

    // Start is called before the first frame update
    void Start()
    {
        Alarm = GameObject.Find("Alarm");

        Button btn = AddAlarm.GetComponent<Button>();
        btn.onClick.AddListener(CreateAlarm);
    }

    private void Update()
    {
        //if(Input.)
    }


    public void CreateAlarm()
    {
        GameObject alarm = Instantiate(Alarm, transform.position, Quaternion.identity);
        alarm.transform.SetParent(Canvas.transform);
    }
}
