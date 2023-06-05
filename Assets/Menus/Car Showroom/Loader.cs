using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    public int SceneToLoad;

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}
