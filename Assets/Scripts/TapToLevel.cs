using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToLevel : MonoBehaviour
{
    public DebugScript TapHouseCounter;

    public float HouseLevel;
    public GameObject oldModel;
    public GameObject NewModel;
    public Animator GameAnim;

    void Start()
    {
        TapHouseCounter = GameObject.FindObjectOfType<DebugScript>();
    }
    void Update()
    {
        if(HouseLevel > 10)
        {
            oldModel.SetActive(false);
            NewModel.SetActive(true);
        }
    }

    public void tapToLevelUp()
    {
        TapHouseCounter.TapsOnHouse += 1;
        HouseLevel += 1;
        GameAnim.Play("ClickAnim");
    }
}
