using System.Collections.Generic;

namespace MedicalDiagnosis
{
    static class Diagnosis
    {
        public static List<string> IdentifyAilments(List<string> symptoms)
        {
            List<string> ailments = new List<string>();

            if (symptoms.Contains("fever") && symptoms.Contains("cough"))
            {
                ailments.Add("Common Cold");
            }
            if (symptoms.Contains("chest pain"))
            {
                ailments.Add("Heart Condition");
            }
            if (symptoms.Contains("headache") && symptoms.Contains("sensitivity to light"))
            {
                ailments.Add("Migraine");
            }
            if (symptoms.Contains("shortness of breath"))
            {
                ailments.Add("Asthma or Respiratory Issue");
            }
            if (symptoms.Contains("abdominal pain"))
            {
                ailments.Add("Gastrointestinal Issue");
            }

            if (ailments.Count == 0)
            {
                ailments.Add("General Checkup Advised");
            }

            return ailments;
        }
    }
}
