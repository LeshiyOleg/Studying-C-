// Обойти директорию

// string path = "C:/Users/parkl/Desktop/GeekBrains/Лекции и семинары/Изучение C#/Examples/Example001_Hello_World";
// DirectoryInfo di = new DirectoryInfo(path);
// Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     Console.WriteLine(fi[i].Name);
// }

void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalogs = new DirectoryInfo(path);
    foreach (var currentCatalog in catalogs.GetDirectories())
    {
        Console.WriteLine($"{indent}{currentCatalog.Name}");
        CatalogInfo(currentCatalog.FullName, indent + " ");
    }
    foreach (var item in catalogs.GetFiles())
    {
        Console.WriteLine($"{indent}{item.Name}");
    }
}
string path = @"C:/Users/parkl/Desktop/GeekBrains/Лекции и семинары/Изучение C#/Examples/Example001_Hello_World";
CatalogInfo(path);