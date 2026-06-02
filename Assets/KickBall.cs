using UnityEngine;

public class KickBall : MonoBehaviour
{
    public GameObject football;
    private void FixedUpdate()
    {
        football.GetComponent<Rigidbody>().AddExplosionForce(100f, transform.position, 3f);
    }
}
