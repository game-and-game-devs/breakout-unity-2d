using UnityEngine;


public class UIController : MonoBehaviour
{
    [SerializeField] GameObject _losePanel;
    [SerializeField] GameObject _winnerPanel;
    public void ActivePanel(FinishGameStateEnum optionSelect)
    {
        bool winActiveScreen = optionSelect.Equals("WIN");
        _losePanel.SetActive(!winActiveScreen);
        _winnerPanel.SetActive(winActiveScreen);
    }
}
