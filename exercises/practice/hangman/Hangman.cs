using System.Collections.Immutable;

public class HangmanState
{
    public string MaskedWord { get; }
    public ImmutableHashSet<char> GuessedChars { get; }
    public int RemainingGuesses { get; }

    public HangmanState(string maskedWord, ImmutableHashSet<char> guessedChars, int remainingGuesses)
    {
        MaskedWord = maskedWord;
        GuessedChars = guessedChars;
        RemainingGuesses = remainingGuesses;
    }
}

public class TooManyGuessesException : Exception
{
}

public class Hangman
{
    public IObservable<HangmanState> StateObservable { get => throw new NotImplementedException("You need to implement this method."); }
    public IObserver<char> GuessObserver { get => throw new NotImplementedException("You need to implement this method."); }
  
    public Hangman(string word)
    {
        throw new NotImplementedException("You need to implement this method.");
    }
}
