// See https://aka.ms/new-console-template for more information
using ShapeMaster.Domain.Entities;
using ShapeMaster.InfraStructure.Sevices;

Console.WriteLine("Hello, World!");


Triangle triangle = new()
{
    Base = 10,
    Heigth = 5,

};

NotepadService notepadService = new();
notepadService.SaveToNotePad(triangle);


