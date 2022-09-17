using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public Control Control;
    public enum State
    {
        Play,
        Win,
        Loss,
    }

    public State CurrentState { get; private set; }

    public void OnPlayerDied()
    {
        if (CurrentState != State.Play) return;

        CurrentState = State.Loss;
        Control.enabled = false;
        PlatformIndex--;
        Debug.Log("Game Over !");
        ReloadLevel();
    }

    public void OnPlayerReachedFinish()
    {
        if(CurrentState != State.Play) return;

        CurrentState = State.Win;
        Control.enabled = false;
        LevelIndex++;
        PlatformIndex++;
        Debug.Log("You won!");
        ReloadLevel();
    }

    private const string LevelIndexKey = "LevelIndex";

    public int LevelIndex
    {
        get => PlayerPrefs.GetInt(LevelIndexKey, 0);
        private set
        {
            PlayerPrefs.SetInt(LevelIndexKey, value);
            PlayerPrefs.Save();
        }
    }
    
    private const string PlatformIndexKey = "PlatformIndex";
    
    public int PlatformIndex
    {
        get => PlayerPrefs.GetInt(PlatformIndexKey, 0);
        private set
        {
            PlayerPrefs.SetInt(PlatformIndexKey, value);
            PlayerPrefs.Save();
        }
    }
    
    public Player Player1;
    
    private float _startY;
    private float _minY;
    private void Start()
    {
      _startY = Player1.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        _minY = Mathf.Min(_minY, Player1.transform.position.y);
        float delta = _minY - _startY;
        int Number = (int) (-delta / 6.5f);
        Debug.Log(Number);
        if (Number ==1)
        {
            PlatformIndex++;
            _startY = _minY;
        }
                
    }


    private void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
