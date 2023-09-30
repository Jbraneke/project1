using UnityEngine;

public class ObstacleHandler : MonoBehaviour
{
    public Vector2 moveDirection = Vector2.left;
    public float moveSpeed = 2.0f;

    private void Update()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
    }
}

