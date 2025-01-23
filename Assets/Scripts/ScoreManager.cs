using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour, IScoreManager
{
    #region ----------------- Fields ----------------------

    [SerializeField] private TextMeshProUGUI tmproScore;
    private int _score;

    #endregion

    #region ----------------- Properties ----------------------

    /// <summary>
    /// Gets or sets the player's score. 
    /// Updates the best score in PlayerPrefs if the current score exceeds it.
    /// </summary>
    public int Score
    {
        get { return _score; }
        set
        {
            if (value >= 0)
            {
                _score = value;
                if (_score > PlayerPrefs.GetInt("BestScore"))
                {
                    PlayerPrefs.SetInt("BestScore", _score);
                }
            }
        }
    }

    #endregion

    #region ---------------------- Unity Methods ----------------------

    /// <summary>
    /// Updates the score display in the UI every frame.
    /// </summary>
    private void Update()
    {
        tmproScore.SetText("Score: " + _score);
    }

    #endregion

    #region ---------------------- Public Methods ----------------------

    /// <summary>
    /// Increments the player's score by one.
    /// </summary>
    public void IncrementScore()
    {
        Score++;
    }

    #endregion
}
