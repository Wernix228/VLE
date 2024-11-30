using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UserAuth : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TMP_InputField passwordInput;
    public TMP_Text messageText;

    private void Start()
    {
        messageText.text = "";
    }

    // ����� ��� �����������
    public void Register()
    {
        string username = usernameInput.text;
        string password = passwordInput.text;

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            messageText.text = "������� ��� ������������ � ������.";
            return;
        }

        if (PlayerPrefs.HasKey(username))
        {
            messageText.text = "������������ ��� ����������.";
        }
        else
        {
            PlayerPrefs.SetString(username, password);
            messageText.text = "����������� �������.";
        }
    }

    // ����� ��� ������
    public void Login()
    {
        string username = usernameInput.text;
        string password = passwordInput.text;

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            messageText.text = "������� ��� ������������ � ������.";
            return;
        }

        if (PlayerPrefs.HasKey(username))
        {
            string savedPassword = PlayerPrefs.GetString(username);
            if (savedPassword == password)
            {
                messageText.text = "���� �������� �������.";
                SceneManager.LoadScene("MainMenu");
            }
            else
            {
                messageText.text = "�������� ������.";
            }
        }
        else
        {
            messageText.text = "������������ �� ������.";
        }
    }
    public void nonRegister()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // ����� ��� ������ ������ (������ ��� ������������)
    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
        messageText.text = "��� ������ ��������.";
    }
}