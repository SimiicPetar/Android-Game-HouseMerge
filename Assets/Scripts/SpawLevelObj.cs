using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawLevelObj : MonoBehaviour
{
    public Transform SpawnPoint;


    public float level2house;
    public float level3house;
    public float level4house;
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public Coins moneycost;

    public void SpawnLevel1()
    {
        if(moneycost.CoinsInt > 9)
        {
            Instantiate(level1, SpawnPoint.position, SpawnPoint.rotation);
            moneycost.CoinsInt -= 10;
        }
    }



    public void SpawnNewBuild()
    {
        if (level2house == 2)
        {
            Instantiate(level2, SpawnPoint.position, SpawnPoint.rotation);
        }

        if (level2house == 4)
        {
            Instantiate(level2, SpawnPoint.position, SpawnPoint.rotation);
        }
        
        if (level2house == 6)
        {
            Instantiate(level2, SpawnPoint.position, SpawnPoint.rotation);
        }
        
        if (level2house == 8)
        {
            Instantiate(level2, SpawnPoint.position, SpawnPoint.rotation);
        }
        
        if (level2house == 10)
        {
            Instantiate(level2, SpawnPoint.position, SpawnPoint.rotation);
        }

        if (level2house == 12)
        {
            Instantiate(level2, SpawnPoint.position, SpawnPoint.rotation);
        }
        
        if (level2house == 14)
        {
            Instantiate(level2, SpawnPoint.position, SpawnPoint.rotation);
        }
        
        if (level2house == 16)
        {
            Instantiate(level2, SpawnPoint.position, SpawnPoint.rotation);
        }
        if (level2house == 18)
        {
            Instantiate(level2, SpawnPoint.position, SpawnPoint.rotation);
        }

        if (level2house == 20)
        {
            Instantiate(level2, SpawnPoint.position, SpawnPoint.rotation);
        }
        
        if (level2house == 22)
        {
            Instantiate(level2, SpawnPoint.position, SpawnPoint.rotation);
        }
        
        if (level2house == 24)
        {
            Instantiate(level2, SpawnPoint.position, SpawnPoint.rotation);
        }
    }
        public void SpawnNewBuild2()
        {
        
        if (level3house == 2)
        {
            Instantiate(level3, SpawnPoint.position, SpawnPoint.rotation);
        }

        if (level3house == 4)
        {
            Instantiate(level3, SpawnPoint.position, SpawnPoint.rotation);
        }
        
        if (level3house == 6)
        {
            Instantiate(level3, SpawnPoint.position, SpawnPoint.rotation);
        }
        
        if (level3house == 8)
        {
            Instantiate(level3, SpawnPoint.position, SpawnPoint.rotation);
        }
        
        if (level3house == 10)
        {
            Instantiate(level3, SpawnPoint.position, SpawnPoint.rotation);
        }

        if (level3house == 12)
        {
            Instantiate(level3, SpawnPoint.position, SpawnPoint.rotation);
        }
        
        if (level3house == 14)
        {
            Instantiate(level3, SpawnPoint.position, SpawnPoint.rotation);
        }
        
        if (level3house == 16)
        {
            Instantiate(level3, SpawnPoint.position, SpawnPoint.rotation);
        }
        if (level3house == 18)
        {
            Instantiate(level3, SpawnPoint.position, SpawnPoint.rotation);
        }

        if (level3house == 20)
        {
            Instantiate(level3, SpawnPoint.position, SpawnPoint.rotation);
        }
        
        if (level3house == 22)
        {
            Instantiate(level3, SpawnPoint.position, SpawnPoint.rotation);
        }
        
        if (level3house == 24)
        {
            Instantiate(level3, SpawnPoint.position, SpawnPoint.rotation);
        }
        }
        public void SpawnNewBuild3()
        {

        //LEVEL4HOUSE

        if (level4house == 2)
        {
            Instantiate(level4, SpawnPoint.position, SpawnPoint.rotation);
        }

        if (level4house == 4)
        {
            Instantiate(level4, SpawnPoint.position, SpawnPoint.rotation);
        }
        
        if (level4house == 6)
        {
            Instantiate(level4, SpawnPoint.position, SpawnPoint.rotation);
        }
        
        if (level4house == 8)
        {
            Instantiate(level4, SpawnPoint.position, SpawnPoint.rotation);
        }
        
        if (level4house == 10)
        {
            Instantiate(level4, SpawnPoint.position, SpawnPoint.rotation);
        }

        if (level4house == 12)
        {
            Instantiate(level4, SpawnPoint.position, SpawnPoint.rotation);
        }
        
        if (level4house == 14)
        {
            Instantiate(level4, SpawnPoint.position, SpawnPoint.rotation);
        }
        
        if (level4house == 16)
        {
            Instantiate(level4, SpawnPoint.position, SpawnPoint.rotation);
        }
        if (level4house == 18)
        {
            Instantiate(level4, SpawnPoint.position, SpawnPoint.rotation);
        }

        if (level4house == 20)
        {
            Instantiate(level4, SpawnPoint.position, SpawnPoint.rotation);
        }
        
        if (level4house == 22)
        {
            Instantiate(level4, SpawnPoint.position, SpawnPoint.rotation);
        }
        
        if (level4house == 24)
        {
            Instantiate(level4, SpawnPoint.position, SpawnPoint.rotation);
        }
    }
}
