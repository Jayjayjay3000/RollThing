using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour {
    // Public variables are initialized
    public TextMeshProUGUI TimeText;

    // Private variables are initialized
    private double time_passed = 0;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        time_passed += Time.deltaTime;
        TimeText.text = $"{time_passed:F1}";
    }
}
