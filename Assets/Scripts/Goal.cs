using UnityEngine;

public class Goal : MonoBehaviour
{
    public string tagName;
    public Score score;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagName))
            score.AddScore();
    }
}
