public class GuessNumberModel {
    public int GuessNumber { get; set; }
    public string GuessResult { get; set; }
    public bool GameOver { get; set; }

    // Метод для обработки пост-запроса
    public void OnPost()
    {
        int correctNumber = 42; // Например, правильное число для игры
        if (GuessNumber == correctNumber)
        {
            GuessResult = "Поздравляем, вы угадали число!";
            GameOver = true;
        }
        else
        {
            GuessResult = "Попробуйте снова!";
        }
    }
}
