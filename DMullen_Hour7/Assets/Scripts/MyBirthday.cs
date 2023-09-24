using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    //When count reaches 5, it will print
    //it's my birthday
    {
    int count = 1;
    while (count <=12)
    {
        print(count);
        count++;
        if(count == 5)
        {
        print("It's my Birthday");
        }
    }
    //When count reaches 3 it will print
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



