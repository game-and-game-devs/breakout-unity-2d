using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UIController : MonoBehaviour
{
    [SerializeField] GameObject _losePanel;
    [SerializeField] GameObject _winnerPanel;
    [SerializeField] GameObject[] _livesImages;
    [SerializeField] GameObject[] _bricksTypes;
    [SerializeField] Text _gameTimeText;

    private void Start()
    {
        // Load bricks to crash with ball dinamically
        for (int i = 0; i < 5; i++) // lines
        {
            for (int j = 0; j < 7; j++) { // columns
                Instantiate(_bricksTypes[i], new Vector2(-6 + (2 * j), -0.5f + i), Quaternion.identity);
            }
        }
    }
    public void ActivePanel(FinishGameStateEnum optionSelect, float gameTime = 0)
    {
        if (optionSelect.ToString() == "WIN")
        {
            _winnerPanel.SetActive(true);
            _gameTimeText.text = string.Format("Tiempo final: {0} seconds", Math.Floor(gameTime));
        } else
        {
            _losePanel.SetActive(true);
        }
        
        
    }

    public void Restart()
    {
        Debug.Log("Reiniciando el juego");
        SceneManager.LoadScene("Game");
    }

    public void GoToMainMenu()
    {
        Debug.Log("Ir al inicio de juego");
        SceneManager.LoadScene("MainMenu");
    }

    public void UpdateUILives(byte playerLives)
    {
        Debug.Log("Vidas: " + playerLives);
        for(int i = 0; i < _livesImages.Length; i++) 
        {
            if (i >= playerLives )
            {
                _livesImages[i].SetActive(false);
            }
        }
    }

   
}
