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
            Patient patient = new Patient
            {
                Name = GetPatientName(),
                Age = GetAge(),
                BloodType = GetBloodType(),
                RhFactor = GetRhFactor(),
                Symptoms = GetSymptoms()
            };

            // Identify possible ailments
            List<string> possibleAilments = Diagnosis.IdentifyAilments(patient.Symptoms);

            // Display results
            DisplayResults(patient, possibleAilments);
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

        static void DisplayResults(Patient patient, List<string> possibleAilments)
        {
            Console.WriteLine("\n--- Diagnosis Report ---");
            Console.WriteLine($"Patient: {patient.Name}");
            Console.WriteLine($"Age: {patient.Age}");
            Console.WriteLine($"Blood Type: {patient.BloodType} {patient.RhFactor}");
            Console.WriteLine("Possible Ailments:");
            foreach (string ailment in possibleAilments)
            {
                Console.WriteLine($"- {ailment}");
            }
        }
    }
}
