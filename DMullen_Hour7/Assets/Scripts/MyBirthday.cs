using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    //When month reaches 5, it will print
    //it's my birthday
    {
    int month = 1;
    while (month <=12)
    {
        print(month);
        month++;
        if(month == 5)
        {
        print("It's my Birthday");
        }
    }
    //When day reaches 3 it will print
    //it's my birthday
    int day = 1;
    while (day <=30)
    {
        print(day);
        day++;
        if(day == 3)
        {
            print("It's my Birthday");
        }
    }
    
        
    }



    }



