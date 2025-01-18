using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchScript : MonoBehaviour
{
    void Update()
    {
        // Überprüfen, ob die Taste G gedrückt wurde
        if (Input.GetKeyDown(KeyCode.G))
        {
            // Wechsel zur Szene "AngryPhase"
            SceneManager.LoadScene("AngryPhase");
        }
    }
}
