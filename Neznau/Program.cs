using Neznau;
using System.Reflection.PortableExecutable;
using System.Security.AccessControl;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
string filePath = Path.Combine(
   Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
  "infoLoomadest.txt");


Koer koer = new Koer(Koer.toug.zachem, "Sharik", "punane", Koduloom.sugu.isane, 35.5, 7);
Koer veelkoer = new Koer(koer);
Kuulik kuulik = new Kuulik(Kuulik.toug.Dutch, 10.0, "Заяц", "Black", Koduloom.sugu.isane, 6, 7);



using (StreamWriter sw = new StreamWriter(filePath))
{
    foreach (Koer loom in new Koer[] {koer, veelkoer})
    {
        sw.WriteLine("--KOER--");
        sw.WriteLine($"nimi: {loom.nimi}\ntõug: {(int)loom.Toug}\nkaal: {loom.kaal}" +
            $"\nvarv: {loom.varv}\nsugu: {loom.loomaSugu}\nvanus: {loom.vanus}");
        sw.Write("-\n");
    }
    sw.WriteLine("--KUULIK--");
    sw.WriteLine($"nimi: {kuulik.nimi}\ntõug: {(int)kuulik.Toug}\nkaal: {kuulik.kaal}\nvarv: {kuulik.varv}\nsugu: {kuulik.loomaSugu}" +
        $"\nvanus: {kuulik.vanus}\nSpeed: {kuulik.Speed}m/s");
    sw.Close();
}

Koer CreateADog(string data)
{
    Koer obj;
    string[] vars = data.Split('\n');
    List<string> a = new List<string>();
    for (int i = 0; i < vars.Length; i++)
    {
        a.Add(vars[i].Split(':')[1]);
    }
    Koer.toug toug = (Koer.toug)Enum.Parse(typeof(Koer.toug), a[1]);
    Koer.sugu sugu = (Koer.sugu)Enum.Parse(typeof(Koer.sugu), a[4]);
    obj = new Koer(toug, a[0], a[3], sugu, toDouble(a[2]), Convert.ToInt32(a[5]));
    return obj;
}

Kuulik CreateARabbit(string data)
{
    Kuulik obj;
    string[] vars = data.Split('\n');
    List<string> a = new List<string>();
    for (int i = 0; i < vars.Length; i++)
    {
        a.Add(vars[i].Split(':')[1].Trim(' '));
    }
    Kuulik.toug toug = (Kuulik.toug)Enum.Parse(typeof(Kuulik.toug), a[1]);
    Kuulik.sugu sugu = (Kuulik.sugu)Enum.Parse(typeof(Kuulik.sugu), a[2]);
    obj = new Kuulik(toug, toDouble(a[6].Substring(0, a[6].Length-3)), a[0], a[3], sugu, toDouble(a[2]), Convert.ToInt32(a[5]));
    return obj;
}

using (StreamReader sr = new StreamReader(filePath))
{
    List<Kuulik> kuuliks = new List<Kuulik>();
    List<Koer> koers = new List<Koer>();
    string[] lines = sr.ReadToEnd().Split('-', StringSplitOptions.RemoveEmptyEntries);
    for (int i = 0; i < lines.Length; i++)
    {
        switch (lines[i])
        {
            case "\n":
                continue;
            case "KOER":
                koers.Add(CreateADog(trimString(lines[i + 1])));
                i++;
                break;
            case "KUULIK":
                kuuliks.Add(CreateARabbit(trimString(lines[i + 1])));
                i++;
                break;
            default:
                break;
        }
    }
    foreach (Kuulik loom in kuuliks)
    {
        loom.printInfo();
    }
    foreach (Koer loom in koers)
    {
        loom.printInfo();
    }
    sr.Dispose();
}

string trimString(string text) { return text.Trim(new Char[] { '\r','\n' }); }
double toDouble(string text) { return Convert.ToDouble(text);  }
    