using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectOnlyFirstSelect : MonoBehaviour
{
    #region ----------------- Fields -----------------

    [SerializeField] private ScoreManager scoreManager; // Riferimento al gestore del punteggio
    private bool isAlreadySelected = false; // Flag per controllare se è già stato selezionato

    #endregion

    #region ----------------- Public Methods -----------------

    /// <summary>
    /// Increments the score in the ScoreManager, but only the first time this method is called.
    /// </summary>
    public void IncrementScoreOnlyFirstSelect()
    {
        if (!isAlreadySelected)
        {
            scoreManager.Score++;
        }

        isAlreadySelected = true; // Imposta il flag per evitare incrementi successivi
    }

    #endregion
}
