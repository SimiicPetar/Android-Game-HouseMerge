using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{

    public DebugScript pausemenu;
    // Start is called before the first frame update
    void OnDisable() 
    {
        Time.timeScale = 1.0f;
        AudioListener.pause = false;
    }
  void OnEnable() 
    {
        Time.timeScale = 0.0f;
        pausemenu.PausedTimes += 1;
        AudioListener.pause = true;
    }
    void Update()
    {
        
    }
}
