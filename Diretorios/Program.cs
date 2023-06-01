using System.IO;
using System.Collections.Generic;

var salesFile = FindFile("stores");

foreach(var file in salesFile){
    Console.WriteLine(file);
}

IEnumerable<string> FindFile(string folderName){
    List<string> salesFile = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach(var file in foundFiles){
        if(file.EndsWith("sales.json")){
            salesFile.Add(file);
        }
    }
    return salesFile;
}