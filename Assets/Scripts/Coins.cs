using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Coins : MonoBehaviour
{
    public float CoinsInt;
    public Text coinsTXT;    


    void Update()
    {

        coinsTXT.text = CoinsInt.ToString();

    }
}
