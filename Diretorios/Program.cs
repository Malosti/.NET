using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

var salesJson = File.ReadAllText($"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales.json");
var salesData = JsonConvert.DeserializeObject<SalesTotal>(salesJson);
Console.WriteLine(salesData?.Total);


var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");
var salesFile = FindFile(storesDirectory);

var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
Directory.CreateDirectory(salesTotalDir);

File.AppendAllText(Path.Combine(salesTotalDir, "totals.txt"), $"{salesData?.Total}{Environment.NewLine}");



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


/*
//Verifica se existe a o diretorio passado
bool doesDirectioryExist = Directory.Exists(storesDirectory);
System.Console.WriteLine(doesDirectioryExist);

// Cria uma nova pasta
//Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "stores", "201", "newDir"));

//Cria um novo arquivo
File.WriteAllText(Path.Combine(storesDirectory, "greeting.txt"), "Hello World!");
*/


class SalesTotal{
    public double Total { get; set; }
}