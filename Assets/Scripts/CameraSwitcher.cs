using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    // Array to store all the cameras you want to switch between
    public Camera[] cameras;

    // Index of the camera to activate when the game starts
    public int initialCameraIndex = 0;

    // Call this function to switch to the specified camera
    public void SwitchCamera(int cameraIndex)
    {
        // Deactivate all cameras
        foreach (Camera cam in cameras)
        {
            cam.gameObject.SetActive(false);
        }

        // Activate the selected camera
        if (cameraIndex >= 0 && cameraIndex < cameras.Length)
        {
            cameras[cameraIndex].gameObject.SetActive(true);
        }
    }

    // This function will be called when the Start button is clicked
    public void OnStartButtonClicked()
    {
        // Assuming Hole 1 camera is at index 0, you can adjust the index as needed
        int hole1CameraIndex = 0;
        SwitchCamera(hole1CameraIndex);
    }
}
