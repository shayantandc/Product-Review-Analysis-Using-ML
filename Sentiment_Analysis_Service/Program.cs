﻿
// This file was auto-generated by ML.NET Model Builder. 

using Sentiment_Analysis_Service;

// Create single instance of sample data from first line of dataset for model input
MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
{
    Col0 = @"This laptop heats very quickly and after heating it hangs.",
};

// Make a single prediction on the sample data and print results
var predictionResult = MLModel1.Predict(sampleData);

Console.WriteLine("Using model to make single prediction -- Comparing actual Col1 with predicted Col1 from sample data...\n\n");




Console.WriteLine($"\n\nPredicted Col1: {predictionResult.PredictedLabel}\n\n");
Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();

