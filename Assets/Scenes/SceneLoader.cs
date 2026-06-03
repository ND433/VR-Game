using UnityEngine;
using UnityEngine.SceneManagement; 
public class SceneLoader : MonoBehaviour
{
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
}