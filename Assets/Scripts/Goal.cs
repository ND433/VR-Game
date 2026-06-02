using UnityEngine;

public class Goal : MonoBehaviour
{
    public Score score;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Basketball") || other.CompareTag("Football"))
        {
            score.AddScore();
        }
    }
}
