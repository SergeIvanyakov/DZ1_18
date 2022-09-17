using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContr : MonoBehaviour
{
    public Player Player;
    public Vector3 Delta;
    public float Speed;

    void Update()
    {
        if (Player.CurrentPlatform == null) return;

        Vector3 targetPosition = Player.CurrentPlatform.transform.position + Delta;
        transform.position = Vector3.MoveTowards(transform.position,targetPosition,Speed*Time.deltaTime);

    }
}
