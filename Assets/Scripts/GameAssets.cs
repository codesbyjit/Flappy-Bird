using UnityEngine;

public class GameAssets : MonoBehaviour
{
    // static accesser
    private static GameAssets instance;
    public static GameAssets GetInstance()
    {
        return instance;
    }

    private void Awake()
    {
        instance = this;
    }

    public Sprite pipeHeadSprite;
    public Transform pfPipeHead;
    public Transform pfPipeBody;
}
