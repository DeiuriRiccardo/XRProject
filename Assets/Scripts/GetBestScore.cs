using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetBestScore : MonoBehaviour
{
    #region ----------------- Fields -----------------

    [SerializeField] private TextMeshProUGUI tmproBestScore; // Reference to the TextMeshPro UI element for displaying the best score

    #endregion

    #region ----------------- Unity Methods -----------------

    /// <summary>
    /// Called at the start of the scene.
    /// Updates the TextMeshPro UI element to display the best score stored in PlayerPrefs.
    /// </summary>
    private void Start()
    {
        // Retrieve the best score from PlayerPrefs and update the UI
        tmproBestScore.SetText("Best Score: " + PlayerPrefs.GetInt("BestScore"));
    }

    #endregion
}
