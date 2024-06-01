using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARTRackerManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void LionIsVisible()
    {
        MainManager.Instance.isLionVisible = true;
    }

    public void LionIsNotVisible()
    {
        MainManager.Instance.isLionVisible = false;
    }
}
