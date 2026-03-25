using System;
namespace HRLibrary;

public enum ServiceType
{
    Страховое,
    Платное
}


public class Patient
{

    private readonly string insuranceNumber;

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string InsuranceNumber => insuranceNumber;
    public DateTime AdmissionDate { get; set; }
    public DateTime DischargeDate { get; set; }
    public ServiceType ServiceType { get; set; }
    public decimal TreatmentCost { get; set; }


    public Patient(string firstName, string lastName, string insuranceNumber)
    {
        FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
        LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        this.insuranceNumber = insuranceNumber ?? throw new ArgumentNullException(nameof(insuranceNumber));
        AdmissionDate = DateTime.Now;
    }


    public string GetInfo()
    {
        return $"Пациент: {FirstName} {LastName}, полис: {InsuranceNumber}";
    }
}



