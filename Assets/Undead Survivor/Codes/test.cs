using UnityEngine;
public class TestSound : MonoBehaviour
{
    void Start()
    {
        AudioManager.instance.PlayBgm(true);
    }
}