namespace MedicalDiagnosis
{
    class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string BloodType { get; set; }
        public string RhFactor { get; set; }
        public List<string> Symptoms { get; set; }
    }
}
