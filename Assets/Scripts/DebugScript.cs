using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugScript : MonoBehaviour
{
    public float TapsOnScreen;
    public float TapsOnHouse;
    public float PausedTimes;

    public Text TapsOnScreenint; 
    public Text TapsOnHouseint; 
    public Text PausedTimesint;

    void Update()
    {
        TapsOnScreenint.text = TapsOnScreen.ToString();
        TapsOnHouseint.text = TapsOnHouse.ToString();
        PausedTimesint.text = PausedTimes.ToString();
        if (Input.GetMouseButtonDown(0))
        {
            TapsOnScreen += 1;
        }
    }

    public void pausedTimes()
    {
        PausedTimes += 1;
    }
    public void HouseTapTimes()
    {
        TapsOnHouse += 1;
    }
}
