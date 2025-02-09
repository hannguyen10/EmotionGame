using UnityEngine;

public class EnvironmentController : MonoBehaviour
{
    public Camera mainCamera; 
    public AudioSource backgroundMusic; 
    public GameObject[] happyPhaseObjects; 
    public GameObject[] angryPhaseObjects; 
    public GameObject[] fearPhaseObjects; 

    public Sprite happyBackgroundSprite; 
    public Sprite angryBackgroundSprite; 
    public Sprite fearBackgroundSprite; 

    public SpriteRenderer backgroundRenderer; 

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.G))
        {
            SwitchToHappyPhase();
        }
        
        
        if (Input.GetKeyDown(KeyCode.H))
        {
            SwitchToAngryPhase();
        }
        
        
        if (Input.GetKeyDown(KeyCode.J))
        {
            SwitchToFearPhase();
        }
    }

    void SwitchToHappyPhase()
    {
        
        backgroundRenderer.sprite = happyBackgroundSprite;

       
        backgroundMusic.Stop();
        backgroundMusic.clip = Resources.Load<AudioClip>("HappyMusic"); 
        backgroundMusic.Play();

        // switch phase objects
        SetActivePhaseObjects(happyPhaseObjects);
    }

    void SwitchToAngryPhase()
    {
        
        backgroundRenderer.sprite = angryBackgroundSprite;

        
        backgroundMusic.Stop();
        backgroundMusic.clip = Resources.Load<AudioClip>("AngryMusic");
        backgroundMusic.Play();

        
        SetActivePhaseObjects(angryPhaseObjects);
    }

    void SwitchToFearPhase()
    {
        
        backgroundRenderer.sprite = fearBackgroundSprite;

        
        backgroundMusic.Stop();
        backgroundMusic.clip = Resources.Load<AudioClip>("FearMusic");
        backgroundMusic.Play();

        
        SetActivePhaseObjects(fearPhaseObjects);
    }

    // active objects from the phases
    void SetActivePhaseObjects(GameObject[] activeObjects)
    {
        
        DeactivateAllObjects();

        
        foreach (GameObject obj in activeObjects)
        {
            obj.SetActive(true);
        }
    }

    
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
