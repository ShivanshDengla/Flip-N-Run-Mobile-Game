using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(Button))]
public class AdButton : MonoBehaviour, IUnityAdsListener
{
    
    public GameObject RewardPanel;

    private string gameId = "3586301";

    Button myButton;
    public string myPlacementId = "rewardedVideo";

    void Start()
    {
        myButton = GetComponent<Button>();

        // Set interactivity to be dependent on the Placement’s status:
        myButton.interactable = Advertisement.IsReady(myPlacementId);

        // Map the ShowRewardedVideo function to the button’s click listener:
        if (myButton) myButton.onClick.AddListener(ShowRewardedVideo);

        // Initialize the Ads listener and service:
        Advertisement.AddListener(this);
        Advertisement.Initialize(gameId);
    }

    // Implement a function for showing a rewarded video ad:
    void ShowRewardedVideo()
    {
        Advertisement.Show(myPlacementId);
    }

    // Implement IUnityAdsListener interface methods:
    public void OnUnityAdsReady(string placementId)
    {
        // If the ready Placement is rewarded, activate the button: 
        if (placementId == myPlacementId)
        {
            myButton.interactable = true;
        }
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        { 
            RewardPanel.SetActive(true);   
        }
        else if (showResult == ShowResult.Skipped)
        {
            SceneManager.LoadScene(0);
        }
        else if (showResult == ShowResult.Failed)
        {
            SceneManager.LoadScene(0);
            Debug.LogWarning("The ad did not finish due to an error");
        }
    }

    public void OnUnityAdsDidError(string message)
    {
        // Log the error.
        Debug.Log("Error");
        SceneManager.LoadScene(0);
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        // Optional actions to take when the end-users triggers an ad.
    }
}
