
using ConsoleApp.Test;

Console.WriteLine("----------------- START: CLASS ---------------------");

var patient = new Patient();
patient.FirstName = "Patient Fullname";
Console.WriteLine($"Patient FistName [patient]: {patient.FirstName}");

string patientFullName = patient.GetFullName("Taulant", "Tahiri");
Console.WriteLine($"Patient Full Name [patient]: {patientFullName}");

// 
string patientFullNameStatic = PatientStatic.GetFullName(firstName: "Taulant",
                                                         lastName: "Tahiri");
Console.WriteLine($"Patient Full Name [patient]: {patientFullNameStatic}");

//var lastPatient = new Patient("Patient Fullname 2");
//Console.WriteLine($"Patient FistName [lastPatient]: {lastPatient.FirstName}");


Console.WriteLine("----------------- START: CLASS ---------------------");








