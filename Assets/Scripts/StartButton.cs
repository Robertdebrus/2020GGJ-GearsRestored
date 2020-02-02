using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UI;
public class StartButton : MonoBehaviour
{
    public string level;
    public int cogsToWin;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        if (FirstPersonAIO.won)
        {
            FirstPersonAIO.won = false;
            SceneManager.LoadScene(level);
        }
        if (SceneManager.GetActiveScene().name.Equals("start"))
            if (Input.GetKeyDown(KeyCode.Return))
            {
                FirstPersonAIO.won = true;
            }
        if (FirstPersonAIO.cogCounter >= cogsToWin)
        {
            FirstPersonAIO.cogCounter = 0;
            FirstPersonAIO.won = true;
            //SceneManager.LoadScene("start");
        }
    }
}
