using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    float time = 15;
    [SerializeField]
    TextMeshProUGUI timeText = default;

    void FixedUpdate()
    {
        time -= Time.fixedDeltaTime;
        if (time <= 0)
        {
            time = 0;
        }
        UpdateTimeText();
        ToClear();
    }
    void ToClear()
    {
        if (time <= 0)
        {
            SceneManager.LoadScene("Clear", LoadSceneMode.Additive);
            Time.timeScale = 0;
        }
    }

    void UpdateTimeText()
    {
        timeText.text = $"{time:0.0}";
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateTimeText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
