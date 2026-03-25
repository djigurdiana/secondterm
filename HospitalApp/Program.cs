using System;
using System.Globalization;

class Program
{
    static void Main()
    {


        Console.WriteLine("=== Библиотека Пациентов Больницы ===\n");


        var patient1 = new Patient("Иван", "Петров", "ПОЛИС-001");
        patient1.AdmissionDate = DateTime.Now;
        patient1.ServiceType = ServiceType.Страховое;
        patient1.TreatmentCost = 0m;

        var patient2 = new Patient("Мария", "Сидорова", "ПОЛИС-002");
        patient2.AdmissionDate = DateTime.Parse("25.03.2026 14:30:00");
        patient2.DischargeDate = DateTime.Parse("28.03.2026 10:00:00");
        patient2.ServiceType = ServiceType.Платное;
        patient2.TreatmentCost = 15000.50m;


        Console.WriteLine("1. " + patient1.GetInfo());
        Console.WriteLine($"   Дата поступления: {patient1.AdmissionDate:dd.MM.yyyy HH:mm}");
        Console.WriteLine($"   Тип: {patient1.ServiceType}, Стоимость: {patient1.TreatmentCost:C}");

        Console.WriteLine("\n2. " + patient2.GetInfo());
        Console.WriteLine($"   Поступление: {patient2.AdmissionDate:dd.MM.yyyy HH:mm}");
        Console.WriteLine($"   Выписка: {patient2.DischargeDate:dd.MM.yyyy HH:mm}");
        Console.WriteLine($"   Тип: {patient2.ServiceType}, Стоимость: {patient2.TreatmentCost:C}");

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey(true);
    }
}
