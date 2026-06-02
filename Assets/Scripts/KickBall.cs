using UnityEngine;

public class KickBall : MonoBehaviour
{
    public GameObject football;
    private void FixedUpdate()
    {
        football.GetComponent<Rigidbody>().AddExplosionForce(3f, transform.position, 1f);
    }
}
