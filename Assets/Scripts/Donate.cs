using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class Donate : MonoBehaviour
{
    public Button okDonate;
    public Button playDonate;

    public void fromFalseToTrue()
    {
        okDonate.onClick.AddListener(Check);
    }

    public void Check()
    {

        playDonate.interactable = true;
    }

}
