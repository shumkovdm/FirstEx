using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Заданный текст, для которого нужно подсчитать частоту слов
        string text = "Это пример текста. Текст должен быть проанализирован. Это важно.";

        // Вызываем метод для подсчёта частоты слов
        Dictionary<string, int> wordCounts = WordFrequency(text);

        // Выводим результат: каждое слово и сколько раз оно встретилось
        foreach (var item in wordCounts)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }

    // Метод для подсчёта частоты слов в тексте
    static Dictionary<string, int> WordFrequency(string text)
    {
        // Указываем символы, которые считаем разделителями между словами
        char[] delimiters = { ' ', '.', ',', '!', '?', ';', ':' };

        // Разделяем текст на слова. 
        // Все буквы переводим в маленький регистр, чтобы "Пример" и "пример" считались одним словом.
        // Убираем пустые элементы, которые могут возникнуть при разделении текста.
        string[] words = text.ToLower().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        // Создаём словарь для подсчёта слов (слово — ключ, частота — значение)
        Dictionary<string, int> wordCounts = new Dictionary<string, int>();

        // Проходим по каждому слову
        foreach (string word in words)
        {
            // Если слово уже есть в словаре, увеличиваем его частоту на 1
            if (wordCounts.ContainsKey(word))
            {
                wordCounts[word]++;
            }
            // Если слова в словаре ещё нет, добавляем его с частотой 1
            else
            {
                wordCounts[word] = 1;
            }
        }

        // Возвращаем словарь с подсчитанными частотами слов
        return wordCounts;
    }
}
// В оригинальном коде был этап копирования словаря, который ничего не давал, я его уничтожил*)