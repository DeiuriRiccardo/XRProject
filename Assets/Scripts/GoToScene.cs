using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
    #region ----------------- Fields -----------------

    [SerializeField] private GameObject xrOrigin;

    #endregion

    #region ----------------- Unity Methods -----------------

    /// <summary>
    /// Sets the local position of the XR Origin to zero at the start of the scene.
    /// </summary>
    private void Start()
    {
        if (xrOrigin != null)
        {
            xrOrigin.GetComponent<Transform>().localPosition = Vector3.zero;
        }
    }

    #endregion

    #region ----------------- Public Methods -----------------

    /// <summary>
    /// Loads the specified scene by name.
    /// </summary>
    /// <param name="nameScene">The name of the scene to load.</param>
    public void GoToAScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }

    #endregion
}
