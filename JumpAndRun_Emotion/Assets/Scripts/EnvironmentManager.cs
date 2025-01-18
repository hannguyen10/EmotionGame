using UnityEngine;
using UnityEngine.SceneManagement;

public class PhaseSwitcher : MonoBehaviour
{
    void Update()
    {
        // Wechsel zur Happy-Phase
        if (Input.GetKeyDown(KeyCode.G))
        {
            SceneManager.LoadScene("HappyPhase");
        }
        // Wechsel zur Angry-Phase
        if (Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene("AngryPhase");
        }
        // Wechsel zur Fear-Phase
        if (Input.GetKeyDown(KeyCode.J))
        {
            SceneManager.LoadScene("FearPhase");
        }
    }
}
