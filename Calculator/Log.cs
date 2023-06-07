using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator;

public class Log
{
    readonly string equation;

    public Log(string equation)
    {
        this.equation = equation;
    }

    public override string ToString()
    {
        return string.IsNullOrEmpty(equation) || string.IsNullOrWhiteSpace(equation) ? "" : equation;
    }

    public static string ReadFromFileInfo(string calcInfoPath) => File.ReadAllText(calcInfoPath);

    public void UploadLog(string path)
    {
        FileStream stream = new FileStream(path, FileMode.Append);
        StreamWriter writer = new StreamWriter(stream);

        writer.Write($"{equation}\n");
        writer.Flush();
        writer.Close();
    }

}
