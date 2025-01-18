using UnityEngine;
using TMPro;
using OpenCVForUnity.TextModule;

public class GemManager : MonoBehaviour
{
    public int gemCount;
    public TMP_Text gemText;

    void Start() {

    }

    void Update(){
        gemText.text = gemCount.ToString();
    }
   
}
