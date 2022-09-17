using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformText : MonoBehaviour
{
    public Text Text;
    public Game Game;

    void Start()
    {
        
    }

 
    void Update()
    {
        Text.text = "Platforms " + Game.PlatformIndex.ToString();
    }
}
