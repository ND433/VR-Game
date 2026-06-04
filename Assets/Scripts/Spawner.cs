using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnObject;
    public Transform spawnTarget;
    GameObject createdObject;
    float spawnTimer = 3f;

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer > 0) return;

        if (!createdObject)
        {
            createdObject = Instantiate(spawnObject, spawnTarget.position, spawnTarget.rotation);
            spawnTimer = 5f;
        }
        else
        {
            if (Vector3.Distance(spawnTarget.position, createdObject.transform.position) > 1f)
                createdObject = null;
        }
    }
}
