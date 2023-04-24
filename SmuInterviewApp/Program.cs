// See https://aka.ms/new-console-template for more information
using SmuInterviewApp;

Console.WriteLine("Hello, World!");

List<StudentProgrammeInfo> ListA = new List<StudentProgrammeInfo>()

{

    new StudentProgrammeInfo() { StudentID = "01003434", ProgrammeID = "101", Status = "AP", LastUpdateDateTime = new DateTime(2021, 3, 1) },

    new StudentProgrammeInfo() { StudentID = "01003435", ProgrammeID = "103", Status = "AD", LastUpdateDateTime = new DateTime(2021, 3, 2) },

    new StudentProgrammeInfo() { StudentID = "01003436", ProgrammeID = "102", Status = "PM", LastUpdateDateTime = new DateTime(2021, 3, 3) },

    new StudentProgrammeInfo() { StudentID = "01003437", ProgrammeID = "101", Status = "AC", LastUpdateDateTime = new DateTime(2021, 3, 4) },

};



List<StudentProgrammeInfo> ListB = new List<StudentProgrammeInfo>()

{

    new StudentProgrammeInfo() { StudentID = "01003434", ProgrammeID = "101", Status = "AP", LastUpdateDateTime = new DateTime(2021, 3, 1) },

    new StudentProgrammeInfo() { StudentID = "01003435", ProgrammeID = "102", Status = "AD", LastUpdateDateTime = new DateTime(2021, 3, 2) },

    new StudentProgrammeInfo() { StudentID = "01003436", ProgrammeID = "102", Status = "AC", LastUpdateDateTime = new DateTime(2021, 3, 5) },

    new StudentProgrammeInfo() { StudentID = "01003437", ProgrammeID = "101", Status = "AC", LastUpdateDateTime = new DateTime(2021, 3, 4) },

};

SmuClass smuClass = new SmuClass();

// Elements of ListA not in ListB
List<StudentProgrammeInfo> resultA = smuClass.GetListAElementsNotInListB(ListA, ListB);
Console.WriteLine("Elements of ListA not in ListB:");
foreach (var item in resultA)
{
    Console.WriteLine(item.StudentID + ",  " + item.ProgrammeID + ",  " + item.Status + ",  " + item.LastUpdateDateTime);
}
Console.WriteLine();

// Elements of ListA which are also in ListB, but having different non-primary-key values
List<StudentProgrammeInfo> resultB = smuClass.GetListAElementsInListBWithDifferentValues(ListA, ListB);
Console.WriteLine("Elements of ListA which are also in ListB, but having different non-primary-key values:");
foreach (var item in resultB)
{
    Console.WriteLine(item.StudentID + ",  " + item.ProgrammeID + ",  " + item.Status + ",  " + item.LastUpdateDateTime);
}
Console.WriteLine();

// Elements of ListB not in ListA
List<StudentProgrammeInfo> resultC = smuClass.GetListBElementsNotInListA(ListA, ListB);
Console.WriteLine("Elements of ListB not in ListA:");
foreach (var item in resultC)
{
    Console.WriteLine(item.StudentID + ",  " + item.ProgrammeID + ",  " + item.Status + ",  " + item.LastUpdateDateTime);
}
Console.WriteLine();
