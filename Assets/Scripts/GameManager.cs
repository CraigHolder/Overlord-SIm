using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static bool isPaused;
    public int speed = 1;
    public int day = 0;
    public int month = 0;
    public int year = 0;
    public float dayTime = 10f;
    public float time;
    public Text timeText;
    public float cameraSpeed = 5;
    public float cameraZoomSpeed = 5;

    private void Awake()
    {
        Resources.InitResources();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isPaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = speed;
        }
        int t = 0;
        for (int i = 49; i < 58; i ++)
        {
            t++;
            if (Input.GetKey((KeyCode)i))
            {
                speed = t;
            }
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            isPaused = !isPaused;
        }
        time += Time.deltaTime;
        if(time >= dayTime)
        {
            time -= dayTime;
            day++;
            if(day > 30)
            {
                day -= 30;
                month++;
                if(month > 12)
                {
                    month -= 12;
                    year++;

                }
            }
            timeText.text = "Year: " + year + "\n" + "Month: " + month + "\n" + "Day: " + day;
        }
        
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Camera.main.transform.position += new Vector3(0, cameraSpeed, 0);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            Camera.main.transform.position += new Vector3(0, -cameraSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Camera.main.transform.position += new Vector3(-cameraSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Camera.main.transform.position += new Vector3(cameraSpeed, 0, 0);
        }
        
    }

    private void Update()
    {
        if (Input.mouseScrollDelta.y != 0)
        {
            Mathf.Clamp(Camera.main.orthographicSize += -Input.mouseScrollDelta.y * cameraZoomSpeed * Time.deltaTime, 2, 20);
        }
    }
}
