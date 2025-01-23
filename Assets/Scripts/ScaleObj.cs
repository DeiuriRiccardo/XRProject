using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScaleObj : MonoBehaviour
{
    #region ----------------- Fields -----------------

    [SerializeField] private GameObject targetObject;
    [SerializeField] private GameObject slider;

    private Vector3 initialScale;

    #endregion

    #region ----------------- Unity Methods -----------------

    /// <summary>
    /// Initializes the initial scale of the target object at the start of the scene.
    /// </summary>
    void Start()
    {
        if (targetObject != null)
        {
            initialScale = targetObject.transform.localScale;
        }
    }

    #endregion

    #region ----------------- Public Methods -----------------

    /// <summary>
    /// Adjusts the scale of the target object based on the slider's value.
    /// </summary>
    public void ScaleObjOnValueChanged()
    {
        if (targetObject != null)
        {
            targetObject.transform.localScale = initialScale / slider.GetComponent<Slider>().value;
        }
    }

    #endregion
}