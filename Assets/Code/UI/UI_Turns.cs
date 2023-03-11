using TMPro;
using UnityEngine;

public class UI_Turns : MonoBehaviour
{
    [SerializeField] private TMP_Text text = null;
    [SerializeField] private TurnCounter turnCounter = null;
    [SerializeField] private string textPrefix = "Turn:";

    private void OnEnable()
    {
        if (turnCounter != null)
        {
            turnCounter.TurnChanged += onTurnChanged;
        }
    }

    private void OnDisable()
    {
        if (turnCounter != null)
        {
            turnCounter.TurnChanged -= onTurnChanged;
        }
    }

    private void onTurnChanged(int _turn)
    {
        throw new System.NotImplementedException();
    }

    private void updateTurnText(int _turn)
    {
        if (turnCounter == null)
        {
            return;
        }

        text.text = ($"{textPrefix} {_turn}/{turnCounter.GetTurnMax()}");
    }
}
