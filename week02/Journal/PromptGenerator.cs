//Supplies random prompt
public class PromptGenerator()
{
    /*Attributes:
        -promptList
    */
    public List<string> _promptList = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What song mirrors my mood today?",
        "What's taking up too much space in my head?",
        "Describe what love is supposed to feel like.",
        "What is something that I'd do differently if I didn't care what anyone thought?",
        "What makes you smile?",
        "If you were a ghost who or what would you haunt? And why?"
    }
    ;
    /*Method:
        -DisplayRandom():string
    */
    static Random random = new Random();
    public string DisplayRandom()
    {
        int listTotal = _promptList.Count();
        int randomNumber = random.Next(0, listTotal);
        string randomPrompt = _promptList[randomNumber];
        return randomPrompt;
    }
}