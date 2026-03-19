namespace HRLibrary;

public enum ServiceType
{
    Insurance,
    Paid
}

public class Patient
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string PolicyNumber { get; }

    private DateTime admissionDate;
    public DateTime AdmissionDate
    {
        get => admissionDate;
        set
        {
            admissionDate = value;
            if (DischargeDate != default && DischargeDate < admissionDate)
                throw new ArgumentException("Дата выписки не может быть раньше даты поступления.");
        }
    }

    private DateTime dischargeDate;
    public DateTime DischargeDate
    {
        get => dischargeDate;
        set
        {
            if (value < AdmissionDate)
                throw new ArgumentException("Дата выписки не может быть раньше даты поступления.");
            dischargeDate = value;
        }
    }

    public ServiceType ServiceType { get; set; }

    private decimal treatmentCost;
    public decimal TreatmentCost
    {
        get => treatmentCost;
        set
        {
            if (value < 0)
                throw new ArgumentException("Стоимость лечения не может быть отрицательной.");
            treatmentCost = value;
        }
    }

    public Patient(string firstName, string lastName, string policyNumber)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            throw new ArgumentException("Имя не может быть пустым.");

        if (string.IsNullOrWhiteSpace(lastName))
            throw new ArgumentException("Фамилия не может быть пустой.");

        if (string.IsNullOrWhiteSpace(policyNumber))
            throw new ArgumentException("Номер полиса не может быть пустым.");

        FirstName = firstName;
        LastName = lastName;
        PolicyNumber = policyNumber;
    }

    public string GetInfo()
    {
        return $"Пациент: {LastName} {FirstName}, полис: {PolicyNumber}, поступление: {AdmissionDate:d}, выписка: {DischargeDate:d}, тип обслуживания: {ServiceType}, стоимость лечения: {TreatmentCost}";
    }
}
