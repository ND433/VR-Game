using UnityEngine;

public class KickBall : MonoBehaviour
{
    private void FixedUpdate()
    {
        foreach (var football in GameObject.FindGameObjectsWithTag("Football"))
        {
            football.GetComponent<Rigidbody>().AddExplosionForce(10f, transform.position, 1f, 0, ForceMode.VelocityChange);
        }
    }
}
