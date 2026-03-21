using HRLibrary;

Patient patient = new Patient("Nikulina", "Diana", "Denisovna");

patient.AdmissionDate = new DateTime(2026, 3, 18);
patient.DishargeDate = new DateTime(2026, 3, 22);
patient.ServiceType = ааа;
patient.TreatmentCost = 10000;

Console.WriteLine(patient.GetInfo());
