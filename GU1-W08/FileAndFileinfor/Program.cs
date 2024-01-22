internal class Program
{
    private static void Main(string[] args)
    {
       /*
       string sourcepath = @"D:\DATA\Map.txt";
       string destination =@"D:\DATA\Des.txt";
       if(File.Exists(sourcepath))
       {
       File.Copy(sourcepath,destination,overwrite:true);
       //File.Delete(sourcepath);
       }
       */

      /* string sourcepath = @"D:\DATA\map.txt";
       string destination =@"D:\DATA\des.txt";
       FileInfo fileInfo = new FileInfo(sourcepath);
       fileInfo.CopyTo(destination,overwrite: true);
      // fileInfo.Delete();
       Console.WriteLine(fileInfo.Length);
       */

       /*
       string sourcepath = @"D:\DATA\directorymap";
       //Directory.CreateDirectory(sourcepath);
       Console.WriteLine(Directory.GetFiles(sourcepath));
       */
        string sourcepath = @"D:\DATA/Name";
        DirectoryInfo directoryInfo = new DirectoryInfo(sourcepath);

        directoryInfo.Create();

    }
}