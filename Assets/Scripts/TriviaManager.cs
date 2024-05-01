using UnityEngine;

public class TriviaManager : MonoBehaviour
{
    public Question[] questions;
    public int totalTrivias;
    private int currentQuestionIndex = 0;

    public void LoadTrivia(int triviaIndex)
    {
        // Cargar la trivia desde la base de datos usando triviaIndex
        // Inicializar questions con las preguntas cargadas
        // Llamar a DisplayQuestion para mostrar la primera pregunta
        DisplayQuestion(currentQuestionIndex);
    }

    public void DisplayQuestion(int questionIndex)
    {
        // Mostrar la pregunta en la interfaz de usuario
        // Mostrar las opciones de respuesta
    }

    public void CheckAnswer(int selectedAnswerIndex)
    {
        // Verificar si la respuesta seleccionada es correcta
        // Calcular el puntaje
        // Guardar el puntaje en el intento
        // Llamar a NextQuestion para pasar a la siguiente pregunta
    }
}