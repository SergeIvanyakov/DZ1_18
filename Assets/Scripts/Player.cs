using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed; //высота прыжка
    public Rigidbody Rigidbody;
    public Platform CurrentPlatform;
    public Game Game;

    public void Prijok ()
    {
        Rigidbody.velocity = new Vector3(0, Speed, 0);
    }

    public void ReachFinish()
    {
        Game.OnPlayerReachedFinish();
        Rigidbody.velocity = Vector3.zero;
    }

    public void Die()
    {
        Game.OnPlayerDied();
        Rigidbody.velocity = Vector3.zero;
    }
}
