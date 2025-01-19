using UnityEngine;
using UnityEngine.SceneManagement;

public class PhaseSwitcher : MonoBehaviour
{
    // switch the phases
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.G))
        {
            SceneManager.LoadScene("HappyPhase");
        }
        
        if (Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene("AngryPhase");
        }
        
        if (Input.GetKeyDown(KeyCode.J))
        {
            SceneManager.LoadScene("FearPhase");
        }
    }
}
