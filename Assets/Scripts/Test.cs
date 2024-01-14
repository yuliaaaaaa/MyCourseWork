using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class Test : MonoBehaviour
{
    IEnumerator Start()
    {

        UnityWebRequest request = UnityWebRequest.Get("http://localhost/sqlconnect/test.php");
        yield return request.SendWebRequest();
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.LogError("Network request failed: " + request.error);
        }
        else
        {
            Debug.Log(request.downloadHandler.text);
        }
        //Debug.Log(request.downloadHandler.text);
    }


}
