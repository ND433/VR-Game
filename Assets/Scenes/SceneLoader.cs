using UnityEngine;
using UnityEngine.SceneManagement; 
public class SceneLoader : MonoBehaviour
{
    float timer = 5f;

    [Tooltip("The exact name of the scene to load.")]
    public string sceneName;

    public void LoadTargetScene()
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogWarning("Scene name is not set on " + gameObject.name);
        }
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0) LoadTargetScene();
    }
}