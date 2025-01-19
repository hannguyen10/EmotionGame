using UnityEngine;

public class EnvironmentController : MonoBehaviour
{
    public Camera mainCamera; // Deine Hauptkamera
    public AudioSource backgroundMusic; // Der Hintergrundmusik-Player
    public GameObject[] happyPhaseObjects; // Objekte der glücklichen Phase
    public GameObject[] angryPhaseObjects; // Objekte der wütenden Phase
    public GameObject[] fearPhaseObjects; // Objekte der ängstlichen Phase

    public Sprite happyBackgroundSprite; // Sprite für den Hintergrund in der Happy Phase
    public Sprite angryBackgroundSprite; // Sprite für den Hintergrund in der Angry Phase
    public Sprite fearBackgroundSprite; // Sprite für den Hintergrund in der Fear Phase

    public SpriteRenderer backgroundRenderer; // Der SpriteRenderer für den Hintergrund

    private void Update()
    {
        // Überprüfen, ob die Taste 'G' für die Happy Phase gedrückt wird
        if (Input.GetKeyDown(KeyCode.G))
        {
            SwitchToHappyPhase();
        }
        
        // Überprüfen, ob die Taste 'H' für die Angry Phase gedrückt wird
        if (Input.GetKeyDown(KeyCode.H))
        {
            SwitchToAngryPhase();
        }
        
        // Überprüfen, ob die Taste 'J' für die Fear Phase gedrückt wird
        if (Input.GetKeyDown(KeyCode.J))
        {
            SwitchToFearPhase();
        }
    }

    void SwitchToHappyPhase()
    {
        // Setze den Hintergrund-Sprite für die Happy Phase
        backgroundRenderer.sprite = happyBackgroundSprite;

        // Musik ändern
        backgroundMusic.Stop();
        backgroundMusic.clip = Resources.Load<AudioClip>("HappyMusic"); // Passe den Musikclip an
        backgroundMusic.Play();

        // Umgebungsobjekte wechseln
        SetActivePhaseObjects(happyPhaseObjects);
    }

    void SwitchToAngryPhase()
    {
        // Setze den Hintergrund-Sprite für die Angry Phase
        backgroundRenderer.sprite = angryBackgroundSprite;

        // Musik ändern
        backgroundMusic.Stop();
        backgroundMusic.clip = Resources.Load<AudioClip>("AngryMusic");
        backgroundMusic.Play();

        // Umgebungsobjekte wechseln
        SetActivePhaseObjects(angryPhaseObjects);
    }

    void SwitchToFearPhase()
    {
        // Setze den Hintergrund-Sprite für die Fear Phase
        backgroundRenderer.sprite = fearBackgroundSprite;

        // Musik ändern
        backgroundMusic.Stop();
        backgroundMusic.clip = Resources.Load<AudioClip>("FearMusic");
        backgroundMusic.Play();

        // Umgebungsobjekte wechseln
        SetActivePhaseObjects(fearPhaseObjects);
    }

    // Eine Methode zum Aktivieren der Objekte der jeweiligen Phase
    void SetActivePhaseObjects(GameObject[] activeObjects)
    {
        // Deaktiviere alle Objekte der anderen Phasen
        DeactivateAllObjects();

        // Aktiviere die Objekte der aktuellen Phase
        foreach (GameObject obj in activeObjects)
        {
            obj.SetActive(true);
        }
    }

    // Alle Umgebungsobjekte deaktivieren
    void DeactivateAllObjects()
    {
        foreach (GameObject obj in happyPhaseObjects)
        {
            obj.SetActive(false);
        }
        foreach (GameObject obj in angryPhaseObjects)
        {
            obj.SetActive(false);
        }
        foreach (GameObject obj in fearPhaseObjects)
        {
            obj.SetActive(false);
        }
    }
}
