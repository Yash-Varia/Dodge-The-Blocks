using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float slowness = 10;

    public void EndGame()
    {   
        StartCoroutine("RestartLevel");
    }
    IEnumerator RestartLevel()
    {
        Time.timeScale = Time.timeScale / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        yield return new WaitForSeconds(3f / slowness);

        Time.timeScale = Time.timeScale * slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
