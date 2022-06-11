using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp : MonoBehaviour
{

    public GameObject HouseDestroy;
    public SpawLevelObj ScriptLevelUpManager;
    public bool level_1;
    public bool level_2;
    public bool level_3;


    // Start is called before the first frame update
    void Start()
    {
        ScriptLevelUpManager = GameObject.FindObjectOfType<SpawLevelObj>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "level1" & level_1 == true & level_2 == false & level_3 == false)
        {
            ScriptLevelUpManager.level2house += 1;
            ScriptLevelUpManager.SpawnNewBuild();
            Destroy(HouseDestroy);
        }


        if (other.tag == "level2" & level_1 == false & level_2 == true & level_3 == false)
        {
            ScriptLevelUpManager.level3house += 1;
            ScriptLevelUpManager.SpawnNewBuild2();
            Destroy(HouseDestroy);
        
        }


        if (other.tag == "level3" & level_1 == false & level_2 == false & level_3 == true)
        {
            ScriptLevelUpManager.level4house += 1;
            ScriptLevelUpManager.SpawnNewBuild3();
            Destroy(HouseDestroy);
        }
    }
}
