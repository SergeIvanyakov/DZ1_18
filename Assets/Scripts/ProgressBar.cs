using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{

    public Player Player;
    public Transform FinishPlatform;
    public Slider Slider;
    public float RadiusPlayer = 1.5f;

    private float _startY;
    private float _minY;
    private void Start()
    {
        _startY = Player.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        _minY = Mathf.Min(_minY, Player.transform.position.y);
        float finishY = FinishPlatform.position.y;
        float t = Mathf.InverseLerp(_startY, finishY + RadiusPlayer, _minY);
        Slider.value = t;
    }
}
