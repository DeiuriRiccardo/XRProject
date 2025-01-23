using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveUI : MonoBehaviour
{
    #region ----------------- Public Methods -----------------

    /// <summary>
    /// Toggles the active state of the specified GameObject.
    /// If the GameObject is active, it will be deactivated; if it is inactive, it will be activated.
    /// </summary>
    /// <param name="gobj">The GameObject whose active state will be toggled.</param>
    public void SetActiveUI(GameObject gobj)
    {
        gobj.SetActive(!gobj.activeSelf); // Toggle the active state of the GameObject
    }

    #endregion
}
