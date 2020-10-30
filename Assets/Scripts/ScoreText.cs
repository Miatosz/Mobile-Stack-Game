using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    private int score = 0;
    private TextMeshProUGUI text;
    private void Start()
    {
        text = GetComponent<TMPro.TextMeshProUGUI>();
        GameManager.OnCubeSpawned += GameManager_OnCubeSpawned;
    }

    private void OnDestroy()
    {
        GameManager.OnCubeSpawned -= GameManager_OnCubeSpawned;
    }

    private void GameManager_OnCubeSpawned()
    {
        score += 10;
        text.text = "Score: " + score;
    }
}
