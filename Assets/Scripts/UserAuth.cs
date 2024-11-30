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

    // Метод для регистрации
    public void Register()
    {
        string username = usernameInput.text;
        string password = passwordInput.text;

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            messageText.text = "Введите имя пользователя и пароль.";
            return;
        }

        if (PlayerPrefs.HasKey(username))
        {
            messageText.text = "Пользователь уже существует.";
        }
        else
        {
            PlayerPrefs.SetString(username, password);
            messageText.text = "Регистрация успешна.";
        }
    }

    // Метод для логина
    public void Login()
    {
        string username = usernameInput.text;
        string password = passwordInput.text;

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            messageText.text = "Введите имя пользователя и пароль.";
            return;
        }

        if (PlayerPrefs.HasKey(username))
        {
            string savedPassword = PlayerPrefs.GetString(username);
            if (savedPassword == password)
            {
                messageText.text = "Вход выполнен успешно.";
                SceneManager.LoadScene("MainMenu");
            }
            else
            {
                messageText.text = "Неверный пароль.";
            }
        }
        else
        {
            messageText.text = "Пользователь не найден.";
        }
    }
    public void nonRegister()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Метод для сброса данных (только для тестирования)
    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
        messageText.text = "Все данные сброшены.";
    }
}