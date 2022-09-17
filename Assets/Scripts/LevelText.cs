using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelText : MonoBehaviour
{

    public Text Text;
    public Game Game;

    void Start()
    {
        Text.text = "Level" + (Game.LevelIndex + 1).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
