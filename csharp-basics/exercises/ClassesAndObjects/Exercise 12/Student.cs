using System.Collections.Generic;
using System;

class Student : IStudent
{
    public List<string> TestsTaken { get; } = new List<string>();

    string[] IStudent.TestsTaken => throw new NotImplementedException();

    public void TakeTest(ITestpaper paper, string[] answers)
    {
        int numCorrect = 0;
        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == paper.MarkScheme[i])
            {
                numCorrect++;
            }
        }
        double percentCorrect = (double)numCorrect / paper.MarkScheme.Length * 100;
        string result = percentCorrect >= double.Parse(paper.PassMark.Replace("%", "")) ? "Passed" : "Failed";
        TestsTaken.Add($"{paper.Subject}: {result}! ({percentCorrect.ToString("0")}%)");
    }
}