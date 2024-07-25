using System;
using System.Collections.Generic;

namespace MedicalDiagnosis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Medical Diagnosis System");

            // Collect patient data
            string patientName = GetPatientName();
            int age = GetAge();
            string bloodType = GetBloodType();
            string rhFactor = GetRhFactor();
            List<string> symptoms = GetSymptoms();

            // Determine full blood type
            string fullBloodType = bloodType + rhFactor;

            // Identify possible ailments
            List<string> possibleAilments = IdentifyAilments(symptoms);

            // Display results
            DisplayResults(patientName, age, fullBloodType, possibleAilments);
        }

        static string GetPatientName()
        {
            Console.Write("Enter Patient Name: ");
            return Console.ReadLine();
        }

        static int GetAge()
        {
            while (true)
            {
                Console.Write("Enter Age: ");
                if (int.TryParse(Console.ReadLine(), out int age) && age > 0)
                {
                    return age;
                }
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }

        static string GetBloodType()
        {
            while (true)
            {
                Console.Write("Enter Blood Type (A, B, AB, O): ");
                string bloodType = Console.ReadLine().ToUpper();
                if (bloodType == "A" || bloodType == "B" || bloodType == "AB" || bloodType == "O")
                {
                    return bloodType;
                }
                Console.WriteLine("Invalid input. Please enter a valid blood type (A, B, AB, O).");
            }
        }

        static string GetRhFactor()
        {
            while (true)
            {
                Console.Write("Enter Rh Factor (+ or -): ");
                string rhFactor = Console.ReadLine();
                if (rhFactor == "+" || rhFactor == "-")
                {
                    return rhFactor;
                }
                Console.WriteLine("Invalid input. Please enter a valid Rh factor (+ or -).");
            }
        }

        static List<string> GetSymptoms()
        {
            Console.Write("Enter Symptoms (comma-separated): ");
            string symptomsInput = Console.ReadLine();
            List<string> symptoms = new List<string>(symptomsInput.Split(','));
            for (int i = 0; i < symptoms.Count; i++)
            {
                symptoms[i] = symptoms[i].Trim().ToLower();
            }
            return symptoms;
        }

        static List<string> IdentifyAilments(List<string> symptoms)
        {
            // A simple rule-based system to identify possible ailments
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

        static void DisplayResults(string patientName, int age, string fullBloodType, List<string> possibleAilments)
        {
            Console.WriteLine("\n--- Diagnosis Report ---");
            Console.WriteLine($"Patient: {patientName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Blood Type: {fullBloodType}");
            Console.WriteLine("Possible Ailments:");
            foreach (string ailment in possibleAilments)
            {
                Console.WriteLine($"- {ailment}");
            }
        }
    }
}
