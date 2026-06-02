using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnObject;
    public Transform spawnTarget;
    GameObject createdObject;

    // Update is called once per frame
    void Update()
    {
        if (!createdObject)
        {
            createdObject = Instantiate(spawnObject, spawnTarget.position, spawnTarget.rotation);
        }
        else
        {
            if (Vector3.Distance(spawnTarget.position, createdObject.transform.position) > 1f)
                createdObject = null;
        }
    }
}
