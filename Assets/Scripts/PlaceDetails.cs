using UnityEngine;
using UnityEngine.UI;

public class PlaceDetails : MonoBehaviour
{
    public Text placeName;
    public Text placeDescription;
    public Button routeButton;

    private Place selectedPlace;

    void Start()
    {
        string placeJson = PlayerPrefs.GetString("SelectedPlace");
        selectedPlace = JsonUtility.FromJson<Place>(placeJson);

        placeName.text = selectedPlace.name;
        placeDescription.text = selectedPlace.description;

        routeButton.onClick.AddListener(() =>
        {
            PlayerPrefs.SetString("RouteCoordinates", JsonUtility.ToJson(selectedPlace.coordinates));
            UnityEngine.SceneManagement.SceneManager.LoadScene("Map");
        });
    }
}