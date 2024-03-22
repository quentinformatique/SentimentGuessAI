//charger les données
using SentimentGuessAI;

var sampleData = new MLModel1.ModelInput()
{
    Col0 = "C# is such an amazing language !",
};

// charger le pmodele et prédire
var result = MLModel1.Predict(sampleData);

// Si la prédiction est 1, le sentiment est "Positif"; sinon, le sentiment est "Negatif"
var sentiment = result.PredictedLabel == 1 ? "Positif" : "Negatif";
Console.WriteLine($"Texte: {sampleData.Col0}\nSentiment: {sentiment}");