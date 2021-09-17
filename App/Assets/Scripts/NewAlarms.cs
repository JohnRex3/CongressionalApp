using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewAlarms : MonoBehaviour
{
    [SerializeField] GameObject Alarm;
    [SerializeField] GameObject Canvas;
    [SerializeField] GameObject Canvas1;
    [SerializeField] GameObject Canvas2;

    public Button AddAlarm1;
    public Button AddAlarm2;
    public Button RemoveAlarm;
    public Button Done;
    //public GameObject Alarm;

    private Canvas CanvasObject1;
    private Canvas CanvasObject2;

    bool add = true;
    int a;

    // Start is called before the first frame update
    void Start()
    {
        

        CanvasObject1 = Canvas1.GetComponent<Canvas>();
        CanvasObject2 = Canvas2.GetComponent<Canvas>();
        Alarm = GameObject.Find("Alarm");

        Button btn = AddAlarm1.GetComponent<Button>();
        btn.onClick.AddListener(CreateAlarm);

        Button ntb = AddAlarm2.GetComponent<Button>();
        ntb.onClick.AddListener(CreateAlarm);

        Button tnb = RemoveAlarm.GetComponent<Button>();
        tnb.onClick.AddListener(OnClick);

        Button tbn = Done.GetComponent<Button>();
        tbn.onClick.AddListener(OnClick);

    }

    private void Update()
    {
        GameObject[] alarm = GameObject.FindGameObjectsWithTag("Alarm");
        int alarmCount = alarm.Length;
        a = alarmCount;
        //print(alarm.Length + a);
        //print(a);

        if(add == true)
        {
            CanvasObject1.enabled = true;
            CanvasObject2.enabled = false;
        }
        else
        {
            CanvasObject1.enabled = false;
            CanvasObject2.enabled = true;
        }

        //if(Input.)
    }

    public void OnClick()
    {
        add = !add;
    }

    public void CreateAlarm()
    {
        var b = 140 / 19.04762f;
        var c = 73 * a;
        var d = c / 19.04762f;
        //var y = 140 - b;
        var y = b - c;
        print(a);
        print(b);
        print(c);
        GameObject alarm = Instantiate(Alarm, transform.position = new Vector3(0, b - d, 0), Quaternion.identity);
        alarm.transform.SetParent(Canvas.transform);
        alarm.transform.localScale = new Vector3(50, 50, 1);
        //alarm.transform.position = new Vector3(0,1,0);
    }

    
}
