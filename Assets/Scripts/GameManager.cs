using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject TitleScreen;
    public TMP_InputField NameInput;
    public TextMeshProUGUI NameText;
    public TextMeshProUGUI ScoreText;
    public int ScoreCount;

    void Start()
    {
       GoToMenu();
    }

    void Update()
    {

    }

    public void StartGame()
    {
        TitleScreen.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void GoToMenu()
    {
        TitleScreen.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void SetName()
    {
        NameText.text = NameInput.text;
    }
    public void AddScore(int value)
    {
        ScoreCount += value;
        ScoreText.text = $"Score:{ScoreCount}";
    }
}
