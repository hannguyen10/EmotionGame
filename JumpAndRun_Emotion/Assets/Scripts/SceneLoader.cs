using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // categorize Tag
    public string tagToCheck;
    public string sceneName;

    public void LoadMyScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // controls tag or player
        if(collision.CompareTag(tagToCheck))
        {
            LoadMyScene(sceneName);
        }
    }
}