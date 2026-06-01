using UnityEngine;

public class Goal : MonoBehaviour
{
    public Score score;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            score.AddScore();
        }
    }
}
