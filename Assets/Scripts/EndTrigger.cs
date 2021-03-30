using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D()
    {
        FindObjectOfType<GameManager>().LevelComplete();
    }
}
