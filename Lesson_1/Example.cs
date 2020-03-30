using static View;

public class Example
{
    public void MaxNumber()
    {
        Print("Введите первое число");
        int firstNumber = GetInt();

        Print("Введите второе число");
        int secondNumber = GetInt();

        Print("Введите третье число");
        int thirdNumber = GetInt();

        Print("----------------------");

        int maxNumber = 0;

        if (firstNumber > secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                maxNumber = firstNumber;
            }
            else
            {
                maxNumber = thirdNumber;
            }
        }
        else
        {
            if (secondNumber > thirdNumber)
            {
                maxNumber = secondNumber;
            }
            else
            {
                maxNumber = thirdNumber;
            }
        }

        //int maxNumber = firstNumber > secondNumber ? firstNumber : secondNumber;
        Print(maxNumber);
    }

    public void ExampleIf()
    {
        // && и
        // || или
        if (false)
        {
            Print("No");
        }
        else if (true || false)
        {
            Print("Yes");
        }
        else
        {
            Print("MB");
        }
    }

    public void GetJob()
    {
        Print("Сколько тебе лет?");

        int age = GetInt();

        if (age >= 18)
        {
            Print("Го работать");
        }
        //else
        {
            GetJob();
        }
    }
}