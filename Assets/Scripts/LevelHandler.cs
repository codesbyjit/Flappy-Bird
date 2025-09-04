using UnityEngine;

public class LevelHandler : MonoBehaviour
{
    private const float CAMERA_ORTHO_SIZE = 50f;
    private const float PIPE_WIDTH = 7.8f;
    private const float PIPE_HEAD_HEIGHT = 0.53f;

    private void Start()
    {
        CreatePipe(40f, 20f, true);
        CreatePipe(30f, 40f, false);
        CreatePipe(20f, 60f, true);
    }

    private void CreatePipe(float height, float xPosition, bool createBottom)
    {
        // --- Setup Head ---
        Transform pipeHead = Instantiate(GameAssets.GetInstance().pfPipeHead);
        float pipeHeadYPosition;

        if (createBottom)
        {
            pipeHeadYPosition = -CAMERA_ORTHO_SIZE + height - PIPE_HEAD_HEIGHT * 0.5f;
        }
        else
        {
            pipeHeadYPosition = CAMERA_ORTHO_SIZE - height + PIPE_HEAD_HEIGHT * 0.5f;
        }

        pipeHead.position = new Vector3(xPosition, pipeHeadYPosition);

        // --- Setup Body ---
        Transform pipeBody = Instantiate(GameAssets.GetInstance().pfPipeBody);
        if (createBottom)
        {
            pipeBody.position = new Vector3(xPosition, -CAMERA_ORTHO_SIZE);
        }
        else
        {
            pipeBody.position = new Vector3(xPosition, CAMERA_ORTHO_SIZE);
            pipeBody.localScale = new Vector3(1, -1, 1); // Flip for top pipe
        }

        // Resize body sprite
        SpriteRenderer pipeBodySpriteRenderer = pipeBody.GetComponent<SpriteRenderer>();
        pipeBodySpriteRenderer.size = new Vector2(PIPE_WIDTH, height);

        // Resize collider
        BoxCollider2D pipeBodyBoxCollider = pipeBody.GetComponent<BoxCollider2D>();
        pipeBodyBoxCollider.size = new Vector2(PIPE_WIDTH, height);
        pipeBodyBoxCollider.offset = new Vector2(0f, height * 0.5f);
    }
}
