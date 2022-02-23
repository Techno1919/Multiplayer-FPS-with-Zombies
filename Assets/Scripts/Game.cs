using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject player = null;

    public static Game game;


    private void Start()
    {
        game = this;
    }
}
