using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject _losePanel;
    [SerializeField] GameObject _winnerPanel;
    public void ActivePanel(FinishGameStateEnum optionSelect)
    {
        _losePanel.SetActive(optionSelect.Equals("LOSE"));
        _winnerPanel.SetActive(optionSelect.Equals("WIN"));
    }

    public void Restart()
    {
        Debug.Log("Reiniciando el juego");
        SceneManager.LoadScene("Game");
    }
}
