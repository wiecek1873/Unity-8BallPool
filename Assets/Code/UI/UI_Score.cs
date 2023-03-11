using TMPro;
using UnityEngine;

namespace Pool.UI
{
    public class UI_Score : MonoBehaviour
    {
        [SerializeField] private TMP_Text text = null;
        [SerializeField] private ScoreCounter scoreCounter = null;
        [SerializeField] private string textPrefix = "Score:";

        private void OnEnable()
        {
            if (scoreCounter != null)
            {
                scoreCounter.ScoreChanged += onScoreChanged;
            }
        }

        private void Start()
        {
            if (scoreCounter != null)
            {
                updateScoreText(scoreCounter.GetScore());
            }
        }

        private void OnDisable()
        {
            if (scoreCounter != null)
            {
                scoreCounter.ScoreChanged -= onScoreChanged;
            }
        }

        private void onScoreChanged(int _score)
        {
            updateScoreText(_score);
        }

        private void updateScoreText(int _score)
        {
            if (text == null)
            {
                return;
            }

            text.text = $"{textPrefix} {_score}";
        }
    }
}