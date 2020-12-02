using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int highscore = GameObject.Find("GameScore").GetComponent<GameScore>().highscore;
        if(highscore!=0)
            GameObject.Find("Score").GetComponent<TextMeshProUGUI>().SetText("High Score: " + highscore);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("Scenes/Start");
        }
        
    }
}
