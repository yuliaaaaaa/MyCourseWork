using UnityEngine;
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
