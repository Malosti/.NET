using System.IO;
using System.Collections.Generic;
/*
var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores", "201", "newDir");
var salesFile = FindFile(storesDirectory);

foreach(var file in salesFile){
    Console.WriteLine(file);
}

//Verifica se existe a o diretorio passado
bool doesDirectioryExist = Directory.Exists(storesDirectory);
System.Console.WriteLine(doesDirectioryExist);

// Cria uma nova pasta
//Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "stores", "201", "newDir"));

//Cria um novo arquivo
File.WriteAllText(Path.Combine(storesDirectory, "greeting.txt"), "Hello World!");

// Método localiza os arquivos .json na pasta stores
IEnumerable<string> FindFile(string folderName){
    List<string> salesFile = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach(var file in foundFiles){
        var extension = Path.GetExtension(file);
        if(extension == ".json"){
            salesFile.Add(file);
        }
    }
    return salesFile;
}
*/

var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");

var salesFile = FindFile(storesDirectory);

foreach(var file in salesFile){
    System.Console.WriteLine(file);
}

IEnumerable<string> FindFile(string folderName){
    List<string> salesFile = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach(var file in foundFiles){
        var extension = Path.GetExtension(".json");
        if(extension == ".json"){
            salesFile.Add(file);
        }
    }

    return salesFile;
}

