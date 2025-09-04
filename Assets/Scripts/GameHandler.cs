using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;

public class GameHandler : MonoBehaviour
{
    private int counter = 0;
    private void Start()
    {
        Debug.Log("GameHandler.Start");

        // GameObject pipeGameObject = new GameObject("Pipe", typeof(SpriteRenderer));
        // pipeGameObject.GetComponent<SpriteRenderer>().sprite = GameAssets.GetInstance().pipeHeadSprite;
        // // pipeGameObject.transform.position = new Vector3(50, -20, 0);
        // pipeGameObject.GetComponent<SpriteRenderer>().sortingOrder = 10;

        // // Add this line to make the pipe twice as big
        // pipeGameObject.transform.localScale = new Vector3(10, 10, 1);
    }
}
