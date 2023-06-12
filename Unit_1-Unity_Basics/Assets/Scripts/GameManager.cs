using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private static GameManager instance;

    // Provide a static method to access the GameManager instance
    public static GameManager Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        // Check if an instance of GameManager already exists
        if (instance == null)
        {
            // If not, set the instance to this
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If an instance already exists, destroy this instance
            Destroy(gameObject);
        }
    }

    public void ReloadScene()
    {
        StartCoroutine(ReloadSceneCoroutine());
    }

    private IEnumerator ReloadSceneCoroutine()
    {
        // Wait for 3 seconds
        yield return new WaitForSeconds(3f);

        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
