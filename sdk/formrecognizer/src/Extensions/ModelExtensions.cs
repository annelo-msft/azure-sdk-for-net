// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Models;
using Azure.AI.FormRecognizer.Prediction;
using Azure.AI.FormRecognizer.Custom;

namespace Azure.AI.FormRecognizer
{
    internal static class ModelExtensions
    {
        public static bool IsModelComplete(this TrainingStatus modelStatus)
        {
            return modelStatus != TrainingStatus.Training;
        }

        public static bool IsModelSuccess(this TrainingStatus modelStatus)
        {
            return modelStatus == TrainingStatus.Ready;
        }

        public static bool IsAnalysisComplete(this Analysis analysis)
        {
            return analysis.Status == AnalysisStatus.Succeeded || analysis.Status == AnalysisStatus.Failed;
        }

        public static bool IsAnalysisSuccess(this Analysis analysis)
        {
            return analysis.Status == AnalysisStatus.Succeeded;
        }
    }
}