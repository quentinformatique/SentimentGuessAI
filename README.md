# SentimentGuessAI

A simple machine learning model to guess the sentiment in a sentence, either positive or negative.

It's built using ML.NET in Visual Studio

## exemple : 

```cs
using SentimentGuessAI;

var sampleData = new MLModel1.ModelInput()
{
    Col0 = "C# is such an amazing language !",
};

// load model and predict
var result = MLModel1.Predict(sampleData);

var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");
````

Output : 

```
Text: C# is such an amazing language !
Sentiment: Positive
```
