// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

foreach (string dir in Directory.EnumerateDirectories(@"D:\Music Videos"))
{


    List<string> fileList = Directory.EnumerateFiles(dir).ToList();

    foreach (string file in fileList)
    {
        if (file.Contains("["))
        {
            var regex = new Regex(@"\[+(\w{11})\]?]");
            regex.Replace("[", "");
            regex.Replace("]", "");
            
            string id = ((file.Substring(file.IndexOfAny(("[".ToCharArray())))).Split(".")[0]);
            //regex.Match((id));
     //       Console.WriteLine(id + " had these items:");
     foreach (var item in regex.Matches(id) )
            {
              //  Console.WriteLine("https://www.youtube.com/watch?v=" + ((string) item).Replace("[","").Replace("]",""));
            }

     if (regex.Match(id).Success)
     {
       string tmp=regex.Match(id).Value;
       tmp=tmp.Substring(1, 11);
       Console.WriteLine("https://www.youtube.com/watch?v="+tmp);
     }
         //  Console.WriteLine(regex.Match(id));
        }
    }
}
