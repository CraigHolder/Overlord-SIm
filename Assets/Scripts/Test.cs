using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    int myInt = 5;
    [SerializeField]
    float myFloat = 10;
    [SerializeField]
    myEnum wasd;

    private void Awake()
    {
        Debug.Log(myInt);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(myFloat);
    }

    // Update is called once per frame
    void Update()
    {
        if (myFloat > 20)
        {
            Debug.Log("Wow large number");
        }

        for (int i = 0; i < 5; i++)
        {
            Debug.Log("i is " + i);
        }

        while(myFloat == 10)
        {

        }

        switch(wasd)
        {
            case myEnum.apple:
                Debug.Log("You must be cool");
                break;
            case myEnum.bannana:
                Debug.Log("meh");
                break;
        }

        if(myInt == 1)
        {
            Debug.Log("You must be cool");
        }
        else if(myInt == 4)
        {
            Debug.Log("meh");
        }
        else if(myInt == 5)
        {
            Debug.Log("default value lame");
        }
        else
        {
            Debug.Log("Wasnt expecting this huh");
        }
    }

    public enum myEnum
    {
        apple,
        bannana
    }
}
